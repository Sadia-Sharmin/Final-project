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
    public partial class AddProductUi : Form
    {
        readonly ProductManager _productManager = new ProductManager();
        CategoryManager _categoryManager = new CategoryManager();
        Product _product = new Product();
        public int id;
        public string categoryText;


        private ProductUiController productUiController;

        public AddProductUi(ProductUiController productUiController2)
        {
            InitializeComponent();

            productUiController = productUiController2;

            GenerateProductCode();
           
        }
      
        private void GenerateProductCode()
        {
            string lastProductCode = _productManager.GetLastProductCode();

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
        public void ClearAllErrorLabel()
        {
            categoryErrorLabel.Text = "";
            codeErrorLabel.Text = "";
            nameErrorLabel.Text = "";
            reorderLevelErrorLabel.Text = "";
            descriptionErrorLabel.Text = "";

        }
        public void ClearAllTextBox()
        {
            categoryComboBox.SelectedIndex = 0;
            codeTextBox.Clear();
            nameTextBox.Clear();
            reorderLevelNumericUpDown.Text = @"0";
            descriptionTextBox.Clear();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(@"Are you sure, you want to exit?", @"Message Box", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Application.Exit();
                Close();
            }
        }

        private void saveOrUpdateButton_Click(object sender, EventArgs e)
        {
            _product.Id = id;
            _product.Code = codeTextBox.Text;
            _product.Name = nameTextBox.Text;
            _product.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            _product.RecorderLevel = Convert.ToInt32(reorderLevelNumericUpDown.Text);
            _product.Description = descriptionTextBox.Text;


            if (_product.CategoryId == 0)
            {
                categoryErrorLabel.ForeColor = Color.Red;
                categoryErrorLabel.Text = @"Select a category";
                categoryComboBox.Focus();
                return;

            }

            if (_productManager.UniqueName(_product))
            {
                nameErrorLabel.ForeColor = Color.Red;
                nameErrorLabel.Text = @"Name is already exist";
                nameTextBox.Focus();
                return;
            }
            if (String.IsNullOrEmpty(_product.Name))
            {
                nameErrorLabel.ForeColor = Color.Red;
                nameErrorLabel.Text = @"Name is required";
                nameTextBox.Focus();
                return;
            }



            if (_product.RecorderLevel <= 0)
            {
                reorderLevelErrorLabel.ForeColor = Color.Red;
                reorderLevelErrorLabel.Text = @"Must be greater then 0";
                reorderLevelNumericUpDown.Focus();
                return;
            }
            if (String.IsNullOrEmpty(_product.Description))
            {
                descriptionErrorLabel.ForeColor = Color.Red;
                descriptionErrorLabel.Text = @"Description is required";
                descriptionTextBox.Focus();
                return;
            }

            try
            {
                if (saveOrUpdateButton.Text == @"Save")
                {
                    if (_productManager.AddProduct(_product))
                    {
                        // productDataGridView.DataSource = _productManager.GetAllProduct();
                        productUiController.ShowAllProduct();
                        MessageBox.Show(@"Saved Successfully");
                    }
                    else
                    {
                        MessageBox.Show(@"Save Failed");
                    }
                }
                else
                {
                    if (_productManager.UpdateProduct(_product))
                    {
                        MessageBox.Show(@"Updated Successfully");
                        //productDataGridView.DataSource = _productManager.GetAllProduct();
                        productUiController.ShowAllProduct();
                        saveOrUpdateButton.Text = @"Save";
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(@"Update Failed");
                    }
                }

                ClearAllTextBox();
                GenerateProductCode();
                ClearAllErrorLabel();
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {

            categoryErrorLabel.Text = "";
            _product.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);

            if (_product.CategoryId == 0)
            {
                categoryErrorLabel.ForeColor = Color.Red;
                categoryErrorLabel.Text = @"Select a category";
                categoryComboBox.Focus();

            }
            else
            {
                categoryErrorLabel.Text = "";
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameErrorLabel.Text = "";
        }

        private void reorderLevelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            reorderLevelErrorLabel.Text = "";
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionErrorLabel.Text = "";
        }

        private void AddProductUi_Load(object sender, EventArgs e)
        {
            //reorderLevelNumericUpDown.Text = "0";

            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            categoryComboBox.DataSource = _categoryManager.GetAllCategoryForComboBox();
            if (saveOrUpdateButton.Text==@"Update")
            {
                categoryComboBox.Text = categoryText;
            }

            ClearAllErrorLabel();
        }
    }
}
