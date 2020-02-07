using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Manager;
using StockManagementSystem.Model;

namespace StockManagementSystem.UI
{
    public partial class AddCategoryUi : Form
    {
        CategoryManager _categoryManager=new CategoryManager();
        Category _category=new Category();

        public int categoryId;
        private CategoryUiController categoryUiController;

        public AddCategoryUi(CategoryUiController categoryUiController2)
        {
            InitializeComponent();
            categoryUiController = categoryUiController2;
            GenerateProductCode();
        }

        private void closeCategoryUiButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(@"Are you sure, you want to exit?", @"Message Box", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
               
                Close();
            }
        }

        private void GenerateProductCode()
        {
            string lastProductCode = _categoryManager.GetLastCategoryCode();

            if (lastProductCode == "")
            {
                lastProductCode = "0001";
            }
            else
            {
                int number = int.Parse(lastProductCode);
                lastProductCode = (++number).ToString("D" + lastProductCode.Length);

            }

            codeTextBox.Text = lastProductCode;
        }



        public void ClearAllText()
        {

            nameTextBox.Clear();
        }

        private void AddCategoryUi_Load(object sender, EventArgs e)
        {

           // GenerateProductCode();

            codeErrorLabel.Text = "";
            nameErrorLabel.Text = "";
        }

        private void saveOrUpdateButton_Click(object sender, EventArgs e)
        {
            _category.Id = categoryId;
            _category.Name = nameTextBox.Text;
            _category.Code = codeTextBox.Text;

            if (String.IsNullOrEmpty(_category.Name))
            {
                nameErrorLabel.Text = @"Name is required !";
                nameErrorLabel.ForeColor = Color.Red;
                nameTextBox.Focus();
                return;
            }
            if (_categoryManager.UniqueName(_category))
            {
                nameErrorLabel.Text = @"Name is already exits !";
                nameErrorLabel.ForeColor = Color.Red;
                nameTextBox.Focus();
                return;
            }

            if (saveOrUpdateButton.Text == "Save")
            {
                try
                {
                    if (_categoryManager.AddCategory(_category))
                    {
                        //categoryDataGridView.DataSource = _categoryManager.GetAllCategory();
                        categoryUiController.ShowAllCategory();
                        MessageBox.Show(@"Saved Successfully");
                        
                        //Close();
                    }
                    else
                    {
                        MessageBox.Show(@"Save failed");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }


            }
            else
            {
                try
                {
                    if (_categoryManager.UpdateCategory(_category))
                    {
                        //categoryDataGridView.DataSource = _categoryManager.GetAllCategory();
                        categoryUiController.ShowAllCategory();
                        MessageBox.Show(@"Updated Successfully", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        saveOrUpdateButton.Text = @"Save";
                        ClearAllText();
                        Close();
                       
                    }
                    else
                    {
                        MessageBox.Show(@"Update failed");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
            ClearAllText();
            GenerateProductCode();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameErrorLabel.Text = "";
        }
    }
}
