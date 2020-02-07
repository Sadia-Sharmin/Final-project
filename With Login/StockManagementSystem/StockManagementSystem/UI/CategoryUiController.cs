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

namespace StockManagementSystem.UI
{
    public partial class CategoryUiController : UserControl
    {
        readonly CategoryManager _categoryManager = new CategoryManager();
        Category _category = new Category();
        public CategoryUiController()
        {
            InitializeComponent();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            AddCategoryUi addCategoryUi = new AddCategoryUi(this);
            addCategoryUi.ShowDialog();
        }

        private void allCategoryButton_Click(object sender, EventArgs e)
        {
            ShowAllCategory();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(searchTextBox.Text))
            {
                MessageBox.Show(@"search box Can not be Empty!!!");
                return;
            }
            List<Category> categories=new List<Category>();

            if (nameRadioButton.Checked == true)
            {

                categories = _categoryManager.Search(searchTextBox.Text, "");
                if (categories.Count != 0)
                {
                    categoryDataGridView.DataSource = categories;
                }
                else
                {
                    categoryDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                categories = _categoryManager.Search("", searchTextBox.Text);
                if (categories.Count != 0)
                {
                    categoryDataGridView.DataSource = categories;
                }
                else
                {
                    categoryDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddCategoryUi addCategoryUi = new AddCategoryUi(this);
            addCategoryUi.ClearAllText();
            if (categoryDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {

                try
                {
                    if (e.RowIndex >= 0)
                    {
                        if (categoryDataGridView.CurrentRow != null) categoryDataGridView.CurrentRow.Selected = true;

                        //_category.Id = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[1].Value);
                        addCategoryUi.categoryId = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[1].Value);
                        addCategoryUi.codeTextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        addCategoryUi.nameTextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        addCategoryUi.saveOrUpdateButton.Text = @"Update";
                        addCategoryUi.ShowDialog();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void categoryDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            categoryDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void CategoryUiController_Load(object sender, EventArgs e)
        {
            nameRadioButton.Checked = true;

            ShowAllCategory();
        }
        public void ShowAllCategory()
        {
            categoryDataGridView.DataSource = _categoryManager.GetAllCategory();
        }


        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(searchTextBox.Text))
            {
               ShowAllCategory();
                return;
            }
            List<Category> categories = new List<Category>();

            if (nameRadioButton.Checked == true)
            {

                categories = _categoryManager.Search(searchTextBox.Text, "");
                if (categories.Count != 0)
                {
                    categoryDataGridView.DataSource = categories;
                }
                else
                {
                    categoryDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchTextBox.Text = "";
                    ShowAllCategory();
                }
            }
            else
            {
                categories = _categoryManager.Search("", searchTextBox.Text);
                if (categories.Count != 0)
                {
                    categoryDataGridView.DataSource = categories;
                }
                else
                {
                    categoryDataGridView.DataSource = null;
                    MessageBox.Show(@"No Result Found", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchTextBox.Text = "";
                    ShowAllCategory();
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
