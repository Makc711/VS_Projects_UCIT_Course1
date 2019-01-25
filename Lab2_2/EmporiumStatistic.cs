using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Lab2_2
{
    public partial class EmporiumStatistic : Form
    {
        private Emporium _emporium;
        private readonly BinaryFormatter _formatter = new BinaryFormatter();

        public EmporiumStatistic()
        {
            InitializeComponent();
        }

        private void createEmporiumButton_Click(object sender, EventArgs e)
        {
            _emporium = new Emporium(nameOfEmporiumTextBox.Text, Int32.Parse(budgetTextBox.Text));
            EmporiumCreated();
            RefreshEmporiumData();
        }

        private void EmporiumCreated()
        {
            createEmporiumButton.Visible = false;
            nameOfEmporiumTextBox.ReadOnly = true;
            budgetTextBox.ReadOnly = true;

            label4.Visible = true;
            profitTextBox.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            areaOfEmporiumTextBox.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            freeAreaOfEmporiumTextBox.Visible = true;
            label8.Visible = true;
            label11.Visible = true;
            squareTextBox.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            costOfSquareTextBox.Visible = true;
            label10.Visible = true;
            buyAreaButton.Visible = true;
            sellAreaButton.Visible = true;

            label17.Visible = true;
            dataGridView1.Visible = true;
        }

        private void buyAreaButton_Click(object sender, EventArgs e)
        {
            try
            {
                _emporium.ExpandArea(int.Parse(squareTextBox.Text) * 10_000,
                    int.Parse(costOfSquareTextBox.Text) / 10_000);
            }
            catch (ArgumentException ex)
            {
                systemTextBox.Text = ex.Message;
            }
            RefreshEmporiumData();
        }

        private void sellAreaButton_Click(object sender, EventArgs e)
        {
            try
            {
                _emporium.ReduceArea(int.Parse(squareTextBox.Text) * 10_000,
                    int.Parse(costOfSquareTextBox.Text) / 10_000);
            }
            catch (ArgumentException ex)
            {
                systemTextBox.Text = ex.Message;
            }
            RefreshEmporiumData();
        }

        private void RefreshEmporiumData()
        {
            nameOfEmporiumTextBox.Text = _emporium.Name;
            budgetTextBox.Text = _emporium.Cashbox.Budget.ToString();
            profitTextBox.Text = _emporium.Cashbox.Profit.ToString();
            areaOfEmporiumTextBox.Text = (_emporium.Square.Area / 10_000).ToString();
            freeAreaOfEmporiumTextBox.Text = (_emporium.Square.FreeArea / 10_000).ToString();
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("Emporium.dat", FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, _emporium);
            }
            systemTextBox.Text = @"Данные сохранены на диск";
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("Emporium.dat", FileMode.OpenOrCreate))
            {
                _emporium = (Emporium)_formatter.Deserialize(fs);
            }

            foreach (var department in _emporium.Departments)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells["NameOfDepartment"].Value = department.Name;
                dataGridView1.Rows[rowNumber].Cells["AreaOfDepartment"].Value = department.Square.Area / 10_000;
                dataGridView1.Rows[rowNumber].Cells["FreeAreaOfDepartment"].Value = department.Square.FreeArea / 10_000;
            }

            systemTextBox.Text = @"Данные загружены успешно";
            EmporiumCreated();
            RefreshEmporiumData();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_emporium != null)
            {
                UpdateDepartments();
            }
        }

        private void UpdateDepartments()
        {
            int numberOfRowsInDataGridView1 = dataGridView1.Rows.Count - 1;
            if (_emporium.Departments.Count < numberOfRowsInDataGridView1)
            {
                string nameOfDepartment = dataGridView1.Rows[numberOfRowsInDataGridView1 - 1].
                    Cells["NameOfDepartment"].Value.ToString();
                int areaOfDepartment;
                try
                {
                    int.TryParse(dataGridView1.Rows[numberOfRowsInDataGridView1 - 1].
                        Cells["AreaOfDepartment"].Value.ToString(), out areaOfDepartment);
                }
                catch (Exception)
                {
                    areaOfDepartment = 0;
                }
                areaOfDepartment *= 10_000;

                if (nameOfDepartment != "" && areaOfDepartment != 0)
                {
                    try
                    {
                        _emporium.AddDepartment(new Department(nameOfDepartment, areaOfDepartment, _emporium));
                        dataGridView1.Rows[numberOfRowsInDataGridView1 - 1].Cells["FreeAreaOfDepartment"].Value =
                            _emporium.Departments[numberOfRowsInDataGridView1 - 1].Square.FreeArea / 10_000;
                    }
                    catch (ArgumentException ex)
                    {
                        systemTextBox.Text = ex.Message;
                    }
                    RefreshEmporiumData();
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
                    string nameOfDepartment = dataGridView1.Rows[counter].Cells["NameOfDepartment"].Value.ToString();
                    if (nameOfDepartment != "")
                    {
                        try
                        {
                            _emporium.Departments[counter].Name = nameOfDepartment;
                        }
                        catch (ArgumentException ex)
                        {
                            systemTextBox.Text = ex.Message;
                            dataGridView1.Rows[counter].Cells["NameOfDepartment"].Value = 
                                _emporium.Departments[counter].Name;
                        }
                    }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
            {
                var newForm = new ProductsStatistic(_emporium.Departments[e.RowIndex]);
                newForm.Show();
            }
        }
    }
}
