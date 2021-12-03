using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enity_Framework.Models;
namespace Enity_Framework
{
    public partial class Form1 : Form
    {
        private RestaurantContext _context;
        public Form1()
        {
            _context = new RestaurantContext();
            InitializeComponent();
        }

        private void btn_reload_category_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }
        private List<Category> GetCategories()
        {
            return _context.Categories.OrderBy(x => x.Name).ToList();
        }
        private void ShowCategories()
        {
            tv_Category.Nodes.Clear();
            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink] = "Thức uống"
            };
            var rootNode = tv_Category.Nodes.Add("Tất cả");
            var categories = GetCategories();
            foreach(var cateType in cateMap)
            {
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;
                foreach(var category in categories)
                {
                    if (category.Type != cateType.Key) continue;
                    var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }
            tv_Category.ExpandAll();
            tv_Category.SelectedNode = rootNode;
        }
        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            var dbContext = new RestaurantContext();
            var foods = dbContext.Foods.AsQueryable();
            if(categoryId!=null && categoryId > 0)
            {
                foods = foods.Where(x => x.FoodCategoryId == categoryId);
            }
            return foods.OrderBy(x => x.Name).Select(x => new FoodModel()
            {
                Id = x.Id,
                Name = x.Name,
                Unit = x.Unit,
                Price = x.Price,
                Notes = x.Notes,
                CategoryName = x.Category.Name
            }).ToList();
        }
        private List<FoodModel> GetFoodByCategoryType(CategoryType categoryType)
        {
            var dbContext = new RestaurantContext();
            
            return dbContext.Foods.Where(x=>x.Category.Type==categoryType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                }).ToList();
        }
        private void ShowFoodsForNode(TreeNode node)
        {
            lv_food.Items.Clear();
            if (node == null) return;
            List<FoodModel> foods = null;
            if(node.Level == 1)
            {
                var cateType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(cateType);
            }
            else
            {
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.Id);
            }
            ShowFoodsOnListView(foods);
        }

        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach(var foodItem in foods)
            {
                var item = lv_food.Items.Add(foodItem.Id.ToString());

                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }

        private void tv_Category_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if(dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void tv_Category_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;
            var category = e.Node.Tag as Category;
            var dialog = new UpdateCategoryForm(category?.Id);
            if(dialog.ShowDialog(this) == DialogResult.OK)
            {
                _context = new RestaurantContext();
                ShowCategories();
            }
        }

        private void btn_reload_food_Click(object sender, EventArgs e)
        {
            ShowFoodsForNode(tv_Category.SelectedNode);
        }

        private void btn_remove_food_Click(object sender, EventArgs e)
        {
            if (lv_food.SelectedItems.Count == 0)
                return;
            var dbContext = new RestaurantContext();
            var selectedFoodId = int.Parse(lv_food.SelectedItems[0].Text);
            var selectedFood = dbContext.Foods.Find(selectedFoodId);
            if (selectedFood != null)
            {
                dbContext.Foods.Remove(selectedFood);
                dbContext.SaveChanges();
                lv_food.Items.Remove(lv_food.SelectedItems[0]);
            }
        }

        private void btn_add_food_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateFoodForm();
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                ShowFoodsForNode(tv_Category.SelectedNode);
            }
        }

        private void lv_food_DoubleClick(object sender, EventArgs e)
        {
            if (lv_food.SelectedItems.Count == 0) return;
            var foodId = int.Parse(lv_food.SelectedItems[0].Text);
            var dialog = new UpdateFoodForm(foodId);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _context = new RestaurantContext();
                ShowFoodsForNode(tv_Category.SelectedNode);
            }
        }
    }
}
