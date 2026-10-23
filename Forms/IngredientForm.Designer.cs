namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    partial class IngredientForm
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
            dgvIngredients = new DataGridView();
            IgredientName = new Label();
            InitialStock = new Label();
            StockManagement = new Label();
            txtIngredientName = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            AddIngredient = new Label();
            AdjustStock = new Label();
            btnAddIngredient = new Button();
            btnAdjustStock = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // dgvIngredients
            // 
            dgvIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(315, 118);
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.Size = new Size(458, 198);
            dgvIngredients.TabIndex = 0;
            // 
            // IgredientName
            // 
            IgredientName.AutoSize = true;
            IgredientName.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IgredientName.Location = new Point(12, 128);
            IgredientName.Name = "IgredientName";
            IgredientName.Size = new Size(137, 26);
            IgredientName.TabIndex = 1;
            IgredientName.Text = "Ingredient:";
            // 
            // InitialStock
            // 
            InitialStock.AutoSize = true;
            InitialStock.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InitialStock.Location = new Point(10, 183);
            InitialStock.Name = "InitialStock";
            InitialStock.Size = new Size(158, 26);
            InitialStock.TabIndex = 2;
            InitialStock.Text = "Initial Stock:";
            // 
            // StockManagement
            // 
            StockManagement.AutoSize = true;
            StockManagement.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockManagement.Location = new Point(315, 31);
            StockManagement.Name = "StockManagement";
            StockManagement.Size = new Size(271, 31);
            StockManagement.TabIndex = 3;
            StockManagement.Text = "Stock Management:";
            // 
            // txtIngredientName
            // 
            txtIngredientName.Location = new Point(174, 131);
            txtIngredientName.Name = "txtIngredientName";
            txtIngredientName.Size = new Size(125, 27);
            txtIngredientName.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(174, 187);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown2.Location = new Point(512, 341);
            numericUpDown2.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 6;
            // 
            // AddIngredient
            // 
            AddIngredient.AutoSize = true;
            AddIngredient.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddIngredient.Location = new Point(10, 31);
            AddIngredient.Name = "AddIngredient";
            AddIngredient.Size = new Size(223, 31);
            AddIngredient.TabIndex = 7;
            AddIngredient.Text = "Add Ingredient:";
            // 
            // AdjustStock
            // 
            AdjustStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AdjustStock.AutoSize = true;
            AdjustStock.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdjustStock.Location = new Point(315, 341);
            AdjustStock.Name = "AdjustStock";
            AdjustStock.Size = new Size(161, 26);
            AdjustStock.TabIndex = 8;
            AdjustStock.Text = "Adjust Stock:";
            // 
            // btnAddIngredient
            // 
            btnAddIngredient.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddIngredient.Location = new Point(85, 244);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.Size = new Size(94, 29);
            btnAddIngredient.TabIndex = 9;
            btnAddIngredient.Text = "Add";
            btnAddIngredient.UseVisualStyleBackColor = true;
            btnAddIngredient.Click += btnAddIngredient_Click;
            // 
            // btnAdjustStock
            // 
            btnAdjustStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdjustStock.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdjustStock.Location = new Point(679, 341);
            btnAdjustStock.Name = "btnAdjustStock";
            btnAdjustStock.Size = new Size(94, 29);
            btnAdjustStock.TabIndex = 10;
            btnAdjustStock.Text = "Adjust";
            btnAdjustStock.UseVisualStyleBackColor = true;
            btnAdjustStock.Click += btnAdjustStock_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(85, 373);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(556, 394);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 392);
            label1.Name = "label1";
            label1.Size = new Size(213, 26);
            label1.TabIndex = 13;
            label1.Text = "Delete Ingredient:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(315, 80);
            label2.Name = "label2";
            label2.Size = new Size(209, 26);
            label2.TabIndex = 14;
            label2.Text = "Select Ingredient:";
            // 
            // IngredientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 442);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnAdjustStock);
            Controls.Add(btnAddIngredient);
            Controls.Add(AdjustStock);
            Controls.Add(AddIngredient);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(txtIngredientName);
            Controls.Add(StockManagement);
            Controls.Add(InitialStock);
            Controls.Add(IgredientName);
            Controls.Add(dgvIngredients);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "IngredientForm";
            Text = "IngredientForm";
            Load += IngredientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIngredients;
        private Label IgredientName;
        private Label InitialStock;
        private Label StockManagement;
        private TextBox txtIngredientName;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label AddIngredient;
        private Label AdjustStock;
        private Button btnAddIngredient;
        private Button btnAdjustStock;
        private Button btnBack;
        private Button btnDelete;
        private Label label1;
        private Label label2;
    }
}