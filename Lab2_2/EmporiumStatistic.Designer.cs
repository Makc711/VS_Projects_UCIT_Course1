namespace Lab2_2
{
    partial class EmporiumStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.systemTextBox = new System.Windows.Forms.TextBox();
            this.createEmporiumButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.areaOfEmporiumTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sellAreaButton = new System.Windows.Forms.Button();
            this.buyAreaButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.freeAreaOfEmporiumTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costOfSquareTextBox = new Lab2_2.CueTextBox();
            this.squareTextBox = new Lab2_2.CueTextBox();
            this.nameOfEmporiumTextBox = new Lab2_2.CueTextBox();
            this.budgetTextBox = new Lab2_2.CueTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.NameOfDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaOfDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeAreaOfDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // systemTextBox
            // 
            this.systemTextBox.Location = new System.Drawing.Point(12, 430);
            this.systemTextBox.Name = "systemTextBox";
            this.systemTextBox.ReadOnly = true;
            this.systemTextBox.Size = new System.Drawing.Size(820, 20);
            this.systemTextBox.TabIndex = 0;
            // 
            // createEmporiumButton
            // 
            this.createEmporiumButton.Location = new System.Drawing.Point(532, 11);
            this.createEmporiumButton.Name = "createEmporiumButton";
            this.createEmporiumButton.Size = new System.Drawing.Size(75, 23);
            this.createEmporiumButton.TabIndex = 1;
            this.createEmporiumButton.Text = "Создать";
            this.createEmporiumButton.UseVisualStyleBackColor = true;
            this.createEmporiumButton.Click += new System.EventHandler(this.createEmporiumButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Бюджет:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "руб.";
            // 
            // profitTextBox
            // 
            this.profitTextBox.Location = new System.Drawing.Point(614, 13);
            this.profitTextBox.Name = "profitTextBox";
            this.profitTextBox.ReadOnly = true;
            this.profitTextBox.Size = new System.Drawing.Size(153, 20);
            this.profitTextBox.TabIndex = 8;
            this.profitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.profitTextBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Прибыль:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(773, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "руб.";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Площадь:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "м2";
            this.label7.Visible = false;
            // 
            // areaOfEmporiumTextBox
            // 
            this.areaOfEmporiumTextBox.Location = new System.Drawing.Point(69, 42);
            this.areaOfEmporiumTextBox.Name = "areaOfEmporiumTextBox";
            this.areaOfEmporiumTextBox.ReadOnly = true;
            this.areaOfEmporiumTextBox.Size = new System.Drawing.Size(112, 20);
            this.areaOfEmporiumTextBox.TabIndex = 14;
            this.areaOfEmporiumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.areaOfEmporiumTextBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sellAreaButton);
            this.groupBox1.Controls.Add(this.buyAreaButton);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.costOfSquareTextBox);
            this.groupBox1.Controls.Add(this.squareTextBox);
            this.groupBox1.Controls.Add(this.freeAreaOfEmporiumTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.areaOfEmporiumTextBox);
            this.groupBox1.Controls.Add(this.nameOfEmporiumTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.createEmporiumButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.budgetTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.profitTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 98);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Универмаг";
            // 
            // sellAreaButton
            // 
            this.sellAreaButton.Location = new System.Drawing.Point(570, 67);
            this.sellAreaButton.Name = "sellAreaButton";
            this.sellAreaButton.Size = new System.Drawing.Size(75, 23);
            this.sellAreaButton.TabIndex = 25;
            this.sellAreaButton.Text = "Продать";
            this.sellAreaButton.UseVisualStyleBackColor = true;
            this.sellAreaButton.Visible = false;
            this.sellAreaButton.Click += new System.EventHandler(this.sellAreaButton_Click);
            // 
            // buyAreaButton
            // 
            this.buyAreaButton.Location = new System.Drawing.Point(489, 67);
            this.buyAreaButton.Name = "buyAreaButton";
            this.buyAreaButton.Size = new System.Drawing.Size(75, 23);
            this.buyAreaButton.TabIndex = 24;
            this.buyAreaButton.Text = "Купить";
            this.buyAreaButton.UseVisualStyleBackColor = true;
            this.buyAreaButton.Visible = false;
            this.buyAreaButton.Click += new System.EventHandler(this.buyAreaButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Цена за 1 м2:";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "м2";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Покупаемая/продаваемая площадь:";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "руб.";
            this.label10.Visible = false;
            // 
            // freeAreaOfEmporiumTextBox
            // 
            this.freeAreaOfEmporiumTextBox.Location = new System.Drawing.Point(339, 42);
            this.freeAreaOfEmporiumTextBox.Name = "freeAreaOfEmporiumTextBox";
            this.freeAreaOfEmporiumTextBox.ReadOnly = true;
            this.freeAreaOfEmporiumTextBox.Size = new System.Drawing.Size(112, 20);
            this.freeAreaOfEmporiumTextBox.TabIndex = 17;
            this.freeAreaOfEmporiumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.freeAreaOfEmporiumTextBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "м2";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Свободная площадь:";
            this.label9.Visible = false;
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(21, 6);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(124, 23);
            this.saveDataButton.TabIndex = 26;
            this.saveDataButton.Text = "Сохранить данные";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(158, 6);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(124, 23);
            this.loadDataButton.TabIndex = 27;
            this.loadDataButton.Text = "Загрузить данные";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfDepartment,
            this.AreaOfDepartment,
            this.FreeAreaOfDepartment,
            this.Products});
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 249);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // costOfSquareTextBox
            // 
            this.costOfSquareTextBox.Cue = "Цена";
            this.costOfSquareTextBox.Location = new System.Drawing.Point(386, 69);
            this.costOfSquareTextBox.Name = "costOfSquareTextBox";
            this.costOfSquareTextBox.Size = new System.Drawing.Size(64, 20);
            this.costOfSquareTextBox.TabIndex = 19;
            this.costOfSquareTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.costOfSquareTextBox.Visible = false;
            // 
            // squareTextBox
            // 
            this.squareTextBox.Cue = "Площадь";
            this.squareTextBox.Location = new System.Drawing.Point(206, 69);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(64, 20);
            this.squareTextBox.TabIndex = 18;
            this.squareTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.squareTextBox.Visible = false;
            // 
            // nameOfEmporiumTextBox
            // 
            this.nameOfEmporiumTextBox.AccessibleDescription = "";
            this.nameOfEmporiumTextBox.AccessibleName = "";
            this.nameOfEmporiumTextBox.Cue = "Название универмага";
            this.nameOfEmporiumTextBox.Location = new System.Drawing.Point(68, 13);
            this.nameOfEmporiumTextBox.Name = "nameOfEmporiumTextBox";
            this.nameOfEmporiumTextBox.Size = new System.Drawing.Size(209, 20);
            this.nameOfEmporiumTextBox.TabIndex = 3;
            this.nameOfEmporiumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Cue = "Стартовый капитал";
            this.budgetTextBox.Location = new System.Drawing.Point(339, 13);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(153, 20);
            this.budgetTextBox.TabIndex = 6;
            this.budgetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(43, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 24);
            this.label17.TabIndex = 29;
            this.label17.Text = "Отделы";
            this.label17.Visible = false;
            // 
            // NameOfDepartment
            // 
            this.NameOfDepartment.HeaderText = "Название";
            this.NameOfDepartment.MinimumWidth = 80;
            this.NameOfDepartment.Name = "NameOfDepartment";
            this.NameOfDepartment.Width = 150;
            // 
            // AreaOfDepartment
            // 
            this.AreaOfDepartment.HeaderText = "Площадь, м2";
            this.AreaOfDepartment.MinimumWidth = 50;
            this.AreaOfDepartment.Name = "AreaOfDepartment";
            this.AreaOfDepartment.Width = 150;
            // 
            // FreeAreaOfDepartment
            // 
            this.FreeAreaOfDepartment.HeaderText = "Свободная площадь, м2";
            this.FreeAreaOfDepartment.MinimumWidth = 50;
            this.FreeAreaOfDepartment.Name = "FreeAreaOfDepartment";
            this.FreeAreaOfDepartment.ReadOnly = true;
            this.FreeAreaOfDepartment.Width = 160;
            // 
            // Products
            // 
            this.Products.HeaderText = "Товары";
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            // 
            // EmporiumStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.systemTextBox);
            this.Name = "EmporiumStatistic";
            this.Text = "Учет прибыли универмага";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox systemTextBox;
        private System.Windows.Forms.Button createEmporiumButton;
        private CueTextBox nameOfEmporiumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CueTextBox budgetTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox profitTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox areaOfEmporiumTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox freeAreaOfEmporiumTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CueTextBox costOfSquareTextBox;
        private CueTextBox squareTextBox;
        private System.Windows.Forms.Button sellAreaButton;
        private System.Windows.Forms.Button buyAreaButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaOfDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeAreaOfDepartment;
        private System.Windows.Forms.DataGridViewButtonColumn Products;
    }
}