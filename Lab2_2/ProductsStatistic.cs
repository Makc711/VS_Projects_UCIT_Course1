using System;
using System.Windows.Forms;

namespace Lab2_2
{
    public partial class ProductsStatistic : Form
    {
        private readonly Department _department;

        public ProductsStatistic(Department department)
        {
            InitializeComponent();
            _department = department;
            label2.Text = @"""" + _department.Name + @"""";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_department != null)
            {
                UpdateProducts();
            }
        }

        private void UpdateProducts()
        {
            int numberOfRowsInDataGridView1 = dataGridView1.Rows.Count - 1;
            if (_department.Products.Count < numberOfRowsInDataGridView1)
            {
                string nameOfProduct = dataGridView1.Rows[numberOfRowsInDataGridView1 - 1].
                    Cells["NameOfProduct"].Value.ToString();
                int sizeOfProduct;
                try
                {
                    int.TryParse(dataGridView1.Rows[numberOfRowsInDataGridView1 - 1].
                        Cells["NumberOfProducts"].Value.ToString(), out sizeOfProduct);
                }
                catch (Exception)
                {
                    sizeOfProduct = 0;
                }

                float markup = 1.5f;

                if (nameOfProduct != "" && sizeOfProduct != 0)
                {
                    try
                    {
                        _department.AddProduct(new Product(nameOfProduct, sizeOfProduct, markup,_department));
                        dataGridView1.Rows[numberOfRowsInDataGridView1 - 1].Cells["NumberOfProducts"].Value = 0;
                        dataGridView1.Rows[numberOfRowsInDataGridView1 - 1].Cells["Cost"].Value =
                            _department.Products[numberOfRowsInDataGridView1 - 1].Price;
                    }
                    catch (ArgumentException ex)
                    {
                        systemTextBox.Text = ex.Message;
                    }
                }
            }
            else
            {
                int counter;
                //int balance;
                //int deposit;
                //int withdrawal;

                for (counter = 0; counter < (dataGridView1.Rows.Count - 1); counter++)
                {
                    //string nameOfDepartment = dataGridView1.Rows[counter].Cells["NameOfDepartment"].Value.ToString();
                    //if (nameOfDepartment != "")
                    //{
                    //    try
                    //    {
                    //        _emporium.Departments[counter].Name = nameOfDepartment;
                    //    }
                    //    catch (ArgumentException ex)
                    //    {
                    //        systemTextBox.Text = ex.Message;
                    //        dataGridView1.Rows[counter].Cells["NameOfDepartment"].Value =
                    //            _emporium.Departments[counter].Name;
                    //    }
                    //}

                    //deposit = 0;
                    //withdrawal = 0;
                    //balance = int.Parse(dataGridView1.Rows[counter - 1].Cells["Balance"].Value.ToString());

                    //if (dataGridView1.Rows[counter].Cells["Deposits"].Value != null)
                    //{
                    //    if (dataGridView1.Rows[counter].Cells["Deposits"].Value.ToString().Length != 0)
                    //    {
                    //        deposit = int.Parse(dataGridView1.Rows[counter].Cells["Deposits"].Value.ToString());
                    //    }
                    //}

                    //if (dataGridView1.Rows[counter].Cells["Withdrawals"].Value != null)
                    //{
                    //    if (dataGridView1.Rows[counter].Cells["Withdrawals"].Value.ToString().Length != 0)
                    //    {
                    //        withdrawal = int.Parse(dataGridView1.Rows[counter].Cells["Withdrawals"].Value.ToString());
                    //    }
                    //}
                    //dataGridView1.Rows[counter].Cells["Balance"].Value = (balance + deposit + withdrawal).ToString();
                }
            }
        }
    }
}
