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
    public partial class UpdateFoodForm : Form
    {
        private RestaurantContext _dbContext;
        private int _foodId;
        public UpdateFoodForm(int ? foodId = null)
        {
            InitializeComponent();
            _dbContext = new RestaurantContext();
            _foodId = foodId ?? 0;
        }

        private void LoadCategoriesToCombboBox()
        {
            var categories = _dbContext.Categories.OrderBy(x => x.Name).ToList();
            cbb_category.DisplayMember = "Name";
            cbb_category.ValueMember = "Id";
            cbb_category.DataSource = categories;

        }

        private void UpdateFoodForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToCombboBox();
            ShowFoodInfo();
        }
        private Food GetFoodById(int foodId)
        {
            return foodId > 0 ? _dbContext.Foods.Find(foodId) : null;
        }
        private void ShowFoodInfo()
        {
            var food = GetFoodById(_foodId);
            if (food == null) return;
            txt_id.Text = food.Id.ToString();
            txt_name.Text = food.Name.ToString();
            txt_unit.Text = food.Unit.ToString();
            txt_description.Text = food.Notes==null? " ": food.Notes.ToString();
            nud_price.Value = food.Price;
            cbb_category.SelectedIndex = food.FoodCategoryId;
        }
        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Tên thức ăn không thể để trống!", "Thông báo");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_unit.Text))
            {
                MessageBox.Show(" thức ăn không thể để trống!", "Thông báo");
                MessageBox.Show("Đợn vị thức ăn không thể để trống!", "Thông báo");
                return false;
            }
            if (nud_price.Value.Equals(0))
            {
                MessageBox.Show("Đơn giá thức ăn không thể là 0!", "Thông báo");
                return false;
            }

            if (cbb_category.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn nhóm thức ăn!", "Thông báo");
                return false;
            }
            return true;
        }
        private Food GetUpdateFood()
        {
            var food = new Food()
            {
                Name = txt_name.Text,
                Unit = txt_unit.Text,
                FoodCategoryId = (int)cbb_category.SelectedValue,
                Price = (int)nud_price.Value,
                Notes = txt_description.Text
            };
            if(_foodId > 0)
            {
                food.Id = _foodId;
            }
            return food;
      }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                var newFood = GetUpdateFood();
                var oldFood = GetFoodById(_foodId);
                if(oldFood == null)
                {
                    _dbContext.Foods.Add(newFood);
                }
                else
                {
                    oldFood.Name = newFood.Name;
                    oldFood.FoodCategoryId = newFood.FoodCategoryId;
                    oldFood.Unit = newFood.Unit;
                    oldFood.Notes = newFood.Notes;
                    oldFood.Price = newFood.Price;
                }
                _dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
