using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StockManagementSystem.Manager;
using StockManagementSystem.Model;

namespace StockManagementSystem.UI
{
    public partial class AddPurchaseUi : Form
    {
        PurchaseManager _purchaseManager = new PurchaseManager();
        CategoryManager _categoryManager = new CategoryManager();
        ProductManager _productManager = new ProductManager();
        SupplierManager _supplierManager = new SupplierManager();
        SalesManager _salesManager=new SalesManager();
       PurchaseDetailsManager _purchaseDetailsManager=new PurchaseDetailsManager();
        public List<Purchase> _purchases = new List<Purchase>();


        public AddPurchaseUi()
        {
            InitializeComponent();
            

            ClearAllErrorLabel();
            

            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.DataSource = _supplierManager.GetAllSupplierForComboBox();

            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DataSource = _categoryManager.GetAllCategoryForComboBox();

        }
        private void AddPurchaseUi_Load(object sender, EventArgs e)
        {
            ClearAllErrorLabel();
            GeneratePurchaseCode();
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
        private void addButton_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();



           

            if (Convert.ToInt32(categoryComboBox.SelectedValue) == 0)
            {
                categoryComboboxerrorLabel.Text = @"Select a category !";
                categoryComboBox.Focus();
                return;
            }

            if (Convert.ToInt32(productComboBox.SelectedValue)==0)
            {
                productComboBoxErrorLabel.Text = @"Select a product";
                productComboBox.Focus();
                return;
            }

            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                quantityErrorLabel.Text = @"Quantity is required !";
                quantityTextBox.Focus();
                return;
            }

            if (String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                UnitPriceErrorLabel.Text = @"Unit price is required !";
                unitPriceTextBox.Focus();
                return;
            }

            if (String.IsNullOrEmpty(mrpTextBox.Text))
            {
                mrpErrorLabel.Text = @"MRP is required !";
                mrpTextBox.Focus();
            }

            if (String.IsNullOrEmpty(remarksTextBox.Text))
            {
                remarkErrorLabel.Text = @"Remark is required !";
                remarksTextBox.Focus();
                return;
            }
            

            if (addButton.Text == "Add")
            {

                //purchase.Date = purchaseDateTimePicker.Text;
                //purchase.InvoiceNo = billNoTextBox.Text;
                //purchase.SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue);
                //purchase.Code = codeTextBox.Text;

                //purchase.PurchaseDetailsId = 1;
                purchase.ProductId = Convert.ToInt32(productComboBox.SelectedValue);
                purchase.Product = productComboBox.Text;
                purchase.ManufacturedDate = manufacturedDateTimePicker.Text;
                purchase.ExpireDate = expireDateTimePicker.Text;
                purchase.Quantity = Convert.ToInt32(quantityTextBox.Text);
                purchase.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);

                purchase.TotalPrice = Convert.ToDouble(totalPriceTextBox.Text);
                purchase.MRP = Convert.ToDouble(mrpTextBox.Text);
                purchase.Remarks = remarksTextBox.Text;


                _purchases.Add(purchase);


            }
            else
            {
                int index = 0;
                foreach (var itemPurchase in _purchases)
                {

                    if (itemPurchase.ProductId == Convert.ToInt32(productComboBox.SelectedValue))
                    {
                        purchase = _purchases.ElementAt(index);
                        break;
                    }
                    index++;

                }

                //purchase.Date = purchaseDateTimePicker.Text;
                //purchase.InvoiceNo = billNoTextBox.Text;
                //purchase.SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue);
                //purchase.Code = codeTextBox.Text;
                purchase.ProductId = Convert.ToInt32(productComboBox.SelectedValue);
                purchase.Product = productComboBox.Text;
                purchase.ManufacturedDate = manufacturedDateTimePicker.Text;
                purchase.ExpireDate = expireDateTimePicker.Text;
                purchase.Quantity = Convert.ToInt32(quantityTextBox.Text);
                purchase.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);

                purchase.TotalPrice = Convert.ToDouble(totalPriceTextBox.Text);
                purchase.MRP = Convert.ToDouble(mrpTextBox.Text);
                purchase.Remarks = remarksTextBox.Text;

                MessageBox.Show(@"Updated successfully");
                addButton.Text = @"Add";

                
            }

            ClearAllTextBox();

            ShowAllPurchase();


            //get next purchase code
            GeneratePurchaseCode();
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(billNoTextBox.Text))
            {
                invoiceNoErrorLabel.Text = @"Invoice no. required !";
                billNoTextBox.Focus();
                return;
            }

            if (Convert.ToInt32(supplierComboBox.SelectedValue) == 0)
            {
                supplierComboBoxErrorLabel.Text = @"Select a supplier !";
                supplierComboBox.Focus();
                return;
            }

            DialogResult dialogResult;
            dialogResult = MessageBox.Show(@"Are you sure, you want to submit and save all this record?", @"Message Box", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                PurchaseDetails purchaseDetails = new PurchaseDetails();

                purchaseDetails.InvoiceNo = billNoTextBox.Text;
                purchaseDetails.Date = purchaseDateTimePicker.Text;
                purchaseDetails.InvoiceNo = billNoTextBox.Text;
                purchaseDetails.SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue);
                purchaseDetails.Code = codeTextBox.Text;

                try
                {
                    if (_purchaseDetailsManager.AddPurchaseDetails(purchaseDetails) && _purchaseManager.AddPurchase(_purchases))
                    {
                        addPurchaseDataGridView.DataSource = null;
                        MessageBox.Show(@"Saved SuccessFully", @"Message Box", MessageBoxButtons.OK);
                        _purchases.Clear();
                        //get next purchase code
                        GeneratePurchaseCode();

                        //after submit make the supplier details editable
                        billNoTextBox.Enabled = true;
                        supplierComboBox.Enabled = true;
                        purchaseDateTimePicker.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(@"Not saved", @"Message Box", MessageBoxButtons.OK);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        public void ClearAllErrorLabel()
        {
           
            invoiceNoErrorLabel.Text = "";
            supplierComboBoxErrorLabel.Text = "";
            categoryComboboxerrorLabel.Text = "";
            productComboBoxErrorLabel.Text = "";
            quantityErrorLabel.Text = "";
            UnitPriceErrorLabel.Text = "";
            mrpErrorLabel.Text = "";
            remarkErrorLabel.Text = "";
        }
        public void ClearAllTextBox()
        {
            //purchaseDateTimePicker.CustomFormat = "yyyy-MM-dd";
            //billNoTextBox.Clear();
            //supplierComboBox.SelectedValue = 0;
            categoryComboBox.SelectedValue = 0;
            productComboBox.SelectedValue = 0;
            productCodeTextBox.Clear();
            availableQuantityTextBox.Clear();
            manufacturedDateTimePicker.CustomFormat = "yyyy-MM-dd";
            expireDateTimePicker.CustomFormat = "yyyy-MM-dd";
            quantityTextBox.Clear();
            unitPriceTextBox.Clear();
            totalPriceTextBox.Clear();
            previousUnitPriceTextbox.Clear();
            previousMRPTextBox.Clear();
            mrpTextBox.Clear();
            remarksTextBox.Clear();
        }


        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryComboboxerrorLabel.Text = "";
            int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.DataSource = _productManager.GetAllProductForComboBox(categoryId);

            // if category combobox select then make the supplier field not editable
            if (Convert.ToInt32(categoryComboBox.SelectedValue)>0)
            {
                billNoTextBox.Enabled = false;
                supplierComboBox.Enabled = false;
                purchaseDateTimePicker.Enabled = false;
            }
        }

        private void productComboBox_TextChanged(object sender, EventArgs e)
        {

            int productId = Convert.ToInt32(productComboBox.SelectedValue);
            addButton.Enabled = true;

            //bool notExist = true;
            foreach (var itemSale in _purchases)
            {
                if (itemSale.ProductId == productId && addButton.Text !=@"Update")
                {
                    MessageBox.Show(@"Selected product already added", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //notExist = false;
                    addButton.Enabled = false;
                    break;
                }

            }
            if (productId > 0)
            {
                Purchase purchase = new Purchase();
                purchase = _purchaseManager.GetLastPurchasesProductInfoById(productId);

                availableQuantityTextBox.Enabled = false;
                previousUnitPriceTextbox.Enabled = false;
                previousMRPTextBox.Enabled = false;



                productCodeTextBox.Text = _productManager.GetCodedById(productId).ToString();
                previousUnitPriceTextbox.Text = purchase.UnitPrice.ToString();
                previousMRPTextBox.Text = purchase.MRP.ToString();



                int totalPurchaseQuantity = _purchaseManager.GetTotalProductById(productId, purchaseDateTimePicker.Text);
                int totalSaleQuantity = _salesManager.GetTotalProductById(productId, purchaseDateTimePicker.Text);

                int availableQuantity = totalPurchaseQuantity - totalSaleQuantity;
                availableQuantityTextBox.Text = availableQuantity.ToString();
            }

        }

        private void unitPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show(@"Only numeric value !");
                return;
            }

            if (chr == 8)
            {
                totalPriceTextBox.Text = "";
            }

        }

        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            UnitPriceErrorLabel.Text = "";
            if (unitPriceTextBox.TextLength > 0 && quantityTextBox.Text.Length > 0)
            {
                totalPriceTextBox.Text =
                    (Convert.ToInt32(quantityTextBox.Text) * Convert.ToDouble(unitPriceTextBox.Text)).ToString();
            }
            else
            {
                totalPriceTextBox.Text = "0";
            }

            if (unitPriceTextBox.TextLength > 0)
            {
                double price = Convert.ToDouble(unitPriceTextBox.Text);
                mrpTextBox.Text = (price + price * 25 / 100).ToString();
            }



        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            quantityErrorLabel.Text = "";
            if (unitPriceTextBox.TextLength > 0 && quantityTextBox.Text.Length > 0)
            {
                totalPriceTextBox.Text =
                    (Convert.ToInt32(quantityTextBox.Text) * Convert.ToDouble(unitPriceTextBox.Text)).ToString();
            }
            else
            {
                totalPriceTextBox.Text = "0";
            }

            if (unitPriceTextBox.TextLength > 0)
            {
                double price = Convert.ToDouble(unitPriceTextBox.Text);
                mrpTextBox.Text = (price + price * 25 / 100).ToString();
            }
        }

        private void billNoTextBox_TextChanged(object sender, EventArgs e)
        {
            invoiceNoErrorLabel.Text = "";
        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplierComboBoxErrorLabel.Text = "";
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productComboBoxErrorLabel.Text = "";

            //codeTextBox.Text = _productManager.GetCodeById(Convert.ToInt32(productComboBox.SelectedValue));
        }

        private void mrpTextBox_TextChanged(object sender, EventArgs e)
        {
            mrpErrorLabel.Text = "";
        }

        private void remarksTextBox_TextChanged(object sender, EventArgs e)
        {
            remarkErrorLabel.Text = "";
        }

        private void availableQuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GeneratePurchaseCode()
        {
            string code = "";
            string lastPurchaseCode= _purchaseManager.GetLastPurchaseCode();
            string year = DateTime.Parse(DateTime.Now.ToString()).Year.ToString();
            if (lastPurchaseCode == "")
            {
                code = year + "-0001";
            }
            else
            {
                string[] afterSplit = lastPurchaseCode.Split('-');

                string serialNo = afterSplit[afterSplit.Length - 1];
                int number = int.Parse(serialNo);
                code = year + "-" + (++number).ToString("D" + serialNo.Length);
            }
            //AddPurchaseUi addPurchaseUi2 = new AddPurchaseUi(this);
            //addPurchaseUi2.codeTextBox.Text = code;
            codeTextBox.Text = code;

        }
        public void ShowAllPurchase()
        {
            addPurchaseDataGridView.DataSource = null;
            addPurchaseDataGridView.DataSource = _purchases;
        }

        private void addPurchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (addPurchaseDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {

                try
                {
                    if (e.RowIndex >= 0)
                    {

                        if (addPurchaseDataGridView.CurrentRow != null) addPurchaseDataGridView.CurrentRow.Selected = true;

                        addButton.Text = @"Update";
                        //id
                        // purchaseDateTimePicker.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        // billNoTextBox.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

                        //supplierComboBox.SelectedValue = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[4].Value);

                        //product id
                        int id = Convert.ToInt32(addPurchaseDataGridView.Rows[e.RowIndex].Cells[3].Value);

                        //get category id by product id
                        int catId = _categoryManager.GetCategoryIdByProductId(id);

                        //set value to category combobox
                        categoryComboBox.SelectedValue = catId;

                        //set value to product combobox
                        productComboBox.SelectedValue = id;


                        // codeTextBox.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                        manufacturedDateTimePicker.Text = addPurchaseDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        expireDateTimePicker.Text = addPurchaseDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                        quantityTextBox.Text = addPurchaseDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                        unitPriceTextBox.Text = addPurchaseDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                        totalPriceTextBox.Text = addPurchaseDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                        mrpTextBox.Text = addPurchaseDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                        remarksTextBox.Text = addPurchaseDataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
                        //MessageBox.Show(Sl + "");


                       

                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            if (addPurchaseDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show(@"Are you sure, you want to delete this record?", @"Message Box", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(addPurchaseDataGridView.Rows[e.RowIndex].Cells[3].Value);
                    int index = 0;
                    Purchase purchase1 = new Purchase();

                    foreach (var itemPurchase in _purchases)
                    {

                        if (itemPurchase.ProductId == id)
                        {
                            purchase1 = _purchases.ElementAt(index);
                            break;
                        }
                        index++;

                    }
                    _purchases.Remove(purchase1);
                    addPurchaseDataGridView.DataSource = null;
                    addPurchaseDataGridView.DataSource = _purchases;

                    ClearAllTextBox();

                    // get next purchase code
                    GeneratePurchaseCode();
                }


            }
        }

        private void addPurchaseDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            this.addPurchaseDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
