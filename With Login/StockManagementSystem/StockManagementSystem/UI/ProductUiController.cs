using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Manager;
using StockManagementSystem.Model;
using StockManagementSystem.ViewModel;

namespace StockManagementSystem.UI
{
    public partial class ProductUiController : UserControl
    {
        readonly ProductManager _productManager = new ProductManager();
        CategoryManager _categoryManager = new CategoryManager();
        Product _product = new Product();
        public ProductUiController()
        {
            InitializeComponent();
            searchByCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchByCategoryComboBox.DataSource = _categoryManager.GetAllCategoryForComboBox();

        }
        private void searchButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(searchByNameOrCodeTextBox.Text))
            {
                searchTextBoxErrorLabel.ForeColor = Color.Red;
                searchTextBoxErrorLabel.Text = @"Enter search value";
                return;
            }

            List<ProductViewModel> _productViewModel = new List<ProductViewModel>();
            if (nameRadioButton.Checked == true)
            {


                _productViewModel = _productManager.SearchByNameORCode(searchByNameOrCodeTextBox.Text, "");
                if (_productViewModel.Count != 0)
                {
                    productDataGridView.DataSource = _productViewModel;
                }
                else
                {
                    productDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                _productViewModel = _productManager.SearchByNameORCode("", searchByNameOrCodeTextBox.Text);
                if (_productViewModel.Count != 0)
                {
                    productDataGridView.DataSource = _productViewModel;
                }
                else
                {
                    productDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


        }

        private void searchByCategoryComboBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(searchByCategoryComboBox.SelectedValue) > 0)
            {
                List<ProductViewModel> _productViewModel = new List<ProductViewModel>();


                _productViewModel = _productManager.GetAllProductByCategoryId(searchByCategoryComboBox.Text);
                if (_productViewModel.Count != 0)
                {
                    productDataGridView.DataSource = _productViewModel;
                }
                else
                {
                    productDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                productDataGridView.DataSource = _productManager.GetAllProduct();
            }
        }

        private void productDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            productDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddProductUi addProductUi = new AddProductUi(this);
            try
            {
                if (productDataGridView.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (e.RowIndex < 0) return;

                    if (productDataGridView.CurrentRow != null) productDataGridView.CurrentRow.Selected = true;

                    //_product.Id = Convert.ToInt32(productDataGridView.Rows[e.RowIndex].Cells[1].Value);
                    addProductUi.id = Convert.ToInt32(productDataGridView.Rows[e.RowIndex].Cells[1].Value);
                    addProductUi.codeTextBox.Text = productDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    addProductUi.nameTextBox.Text = productDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    //addProductUi.categoryComboBox.Text = productDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    addProductUi.categoryText = productDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    addProductUi.reorderLevelNumericUpDown.Text = productDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    addProductUi.descriptionTextBox.Text = productDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

                    //MessageBox.Show(addProductUi.categoryComboBox.Text);
                    addProductUi.saveOrUpdateButton.Text = @"Update";
                    addProductUi.categoryErrorLabel.Text = "";

                    addProductUi.ShowDialog();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProductUi addProduct = new AddProductUi(this);
            addProduct.ShowDialog();
        }

        public void ShowAllProduct()
        {
            ClearSearchTextBox();
            productDataGridView.DataSource = _productManager.GetAllProduct();
        }

        public void ClearSearchTextBox()
        {
            searchByCategoryComboBox.SelectedIndex = 0;
            nameRadioButton.Checked = true;
            searchByNameOrCodeTextBox.Clear();
            searchTextBoxErrorLabel.Text = "";
        }
        private void searchByNameOrCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            searchTextBoxErrorLabel.Text = "";
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ShowAllProduct();
        }

        private void ProductUiController_Load(object sender, EventArgs e)
        {
            productDataGridView.DataSource = _productManager.GetAllProduct();
            ClearSearchTextBox();
            ShowAllProduct();
        }

        private void searchByNameOrCodeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(searchByNameOrCodeTextBox.Text))
            {
                ShowAllProduct();
                return;
            }

            List<ProductViewModel> _productViewModel = new List<ProductViewModel>();
            if (nameRadioButton.Checked == true)
            {


                _productViewModel = _productManager.SearchByNameORCode(searchByNameOrCodeTextBox.Text, "");
                if (_productViewModel.Count != 0)
                {
                    productDataGridView.DataSource = _productViewModel;
                }
                else
                {
                    productDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchByNameOrCodeTextBox.Text = "";
                    ShowAllProduct();

                }


            }
            else
            {
                _productViewModel = _productManager.SearchByNameORCode("", searchByNameOrCodeTextBox.Text);
                if (_productViewModel.Count != 0)
                {
                    productDataGridView.DataSource = _productViewModel;
                }
                else
                {
                    productDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchByNameOrCodeTextBox.Text = "";
                    ShowAllProduct();

                }

            }
        }
    }
}
