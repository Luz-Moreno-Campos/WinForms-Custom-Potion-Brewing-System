namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    partial class RecipeForm
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
            label1 = new Label();
            dgvRecipes = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            dgvIngredients = new DataGridView();
            btnCreate = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAddIngredient = new Button();
            btnRemoveIngredient = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            cmbIngredient = new ComboBox();
            nudRequiredQuantity = new NumericUpDown();
            txtRecipeName = new TextBox();
            txtSpecialEffect = new TextBox();
            nudBrewingDuration = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRequiredQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBrewingDuration).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 31);
            label1.TabIndex = 0;
            label1.Text = "Recipes";
            // 
            // dgvRecipes
            // 
            dgvRecipes.AllowUserToAddRows = false;
            dgvRecipes.AllowUserToDeleteRows = false;
            dgvRecipes.AllowUserToResizeRows = false;
            dgvRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipes.Location = new Point(12, 78);
            dgvRecipes.MultiSelect = false;
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvRecipes.Size = new Size(473, 102);
            dgvRecipes.TabIndex = 1;
            dgvRecipes.SelectionChanged += dgvRecipes_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(531, 48);
            label2.Name = "label2";
            label2.Size = new Size(171, 21);
            label2.TabIndex = 2;
            label2.Text = " Select Ingredient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 48);
            label3.Name = "label3";
            label3.Size = new Size(289, 21);
            label3.TabIndex = 3;
            label3.Text = "Select a recipe to view and edit";
            // 
            // dgvIngredients
            // 
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(516, 78);
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.Size = new Size(255, 102);
            dgvIngredients.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(262, 186);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(196, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create new recipe";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(32, 186);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(149, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 252);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 8;
            label4.Text = "Recipe Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 287);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 9;
            label5.Text = "Special Effect:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 326);
            label6.Name = "label6";
            label6.Size = new Size(184, 21);
            label6.TabIndex = 10;
            label6.Text = "Brewing Duration:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(451, 288);
            label7.Name = "label7";
            label7.Size = new Size(115, 21);
            label7.TabIndex = 11;
            label7.Text = "Ingredient:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(451, 326);
            label8.Name = "label8";
            label8.Size = new Size(187, 21);
            label8.TabIndex = 12;
            label8.Text = "Required Quantity:";
            // 
            // btnAddIngredient
            // 
            btnAddIngredient.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddIngredient.Location = new Point(611, 366);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.Size = new Size(160, 29);
            btnAddIngredient.TabIndex = 13;
            btnAddIngredient.Text = "Add Ingredient";
            btnAddIngredient.UseVisualStyleBackColor = true;
            btnAddIngredient.Click += btnAddIngredient_Click;
            // 
            // btnRemoveIngredient
            // 
            btnRemoveIngredient.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveIngredient.Location = new Point(545, 186);
            btnRemoveIngredient.Name = "btnRemoveIngredient";
            btnRemoveIngredient.Size = new Size(211, 29);
            btnRemoveIngredient.TabIndex = 14;
            btnRemoveIngredient.Text = "Remove  Ingredient";
            btnRemoveIngredient.UseVisualStyleBackColor = true;
            btnRemoveIngredient.Click += btnRemoveIngredient_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(373, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save changes/creation";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(273, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(198, 29);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back to dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbIngredient
            // 
            cmbIngredient.FormattingEnabled = true;
            cmbIngredient.Location = new Point(572, 286);
            cmbIngredient.Name = "cmbIngredient";
            cmbIngredient.Size = new Size(199, 28);
            cmbIngredient.TabIndex = 18;
            // 
            // nudRequiredQuantity
            // 
            nudRequiredQuantity.Location = new Point(653, 320);
            nudRequiredQuantity.Name = "nudRequiredQuantity";
            nudRequiredQuantity.Size = new Size(67, 27);
            nudRequiredQuantity.TabIndex = 19;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(149, 246);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(242, 27);
            txtRecipeName.TabIndex = 20;
            // 
            // txtSpecialEffect
            // 
            txtSpecialEffect.Location = new Point(154, 287);
            txtSpecialEffect.Name = "txtSpecialEffect";
            txtSpecialEffect.Size = new Size(219, 27);
            txtSpecialEffect.TabIndex = 21;
            // 
            // nudBrewingDuration
            // 
            nudBrewingDuration.Location = new Point(202, 326);
            nudBrewingDuration.Name = "nudBrewingDuration";
            nudBrewingDuration.Size = new Size(66, 27);
            nudBrewingDuration.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(279, 335);
            label9.Name = "label9";
            label9.Size = new Size(77, 18);
            label9.TabIndex = 23;
            label9.Text = " SECONDS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(451, 247);
            label10.Name = "label10";
            label10.Size = new Size(222, 21);
            label10.TabIndex = 24;
            label10.Text = "Add or edit Ingredient:";
            // 
            // RecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(nudBrewingDuration);
            Controls.Add(txtSpecialEffect);
            Controls.Add(txtRecipeName);
            Controls.Add(nudRequiredQuantity);
            Controls.Add(cmbIngredient);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnRemoveIngredient);
            Controls.Add(btnAddIngredient);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Controls.Add(dgvIngredients);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvRecipes);
            Controls.Add(label1);
            Name = "RecipeForm";
            Text = "RecipeForm";
            Load += RecipeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRequiredQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBrewingDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvRecipes;
        private Label label2;
        private Label label3;
        private DataGridView dgvIngredients;
        private Button btnCreate;
        private Button btnEdit;
        private Button btnDelete;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAddIngredient;
        private Button btnRemoveIngredient;
        private Button btnSave;
        private Button btnCancel;
        private Button btnBack;
        private ComboBox cmbIngredient;
        private NumericUpDown nudRequiredQuantity;
        private TextBox txtRecipeName;
        private TextBox txtSpecialEffect;
        private NumericUpDown nudBrewingDuration;
        private Label label9;
        private Label label10;
    }
}

