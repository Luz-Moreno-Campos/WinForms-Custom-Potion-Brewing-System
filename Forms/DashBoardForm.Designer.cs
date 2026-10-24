namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    partial class DashboardForm
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
            lblTitle = new Label();
            btnIngredients = new Button();
            btnRecipes = new Button();
            btnBrewingHub = new Button();
            lblFrequentlyBrewed = new Label();
            dgvFrequentlyBrewed = new DataGridView();
            label1 = new Label();
            dgvMostConsumed = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnGenerate = new Button();
            label5 = new Label();
            lblThroughput = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFrequentlyBrewed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMostConsumed).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(166, 72);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(466, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Witches' Potion Brewer";
            // 
            // btnIngredients
            // 
            btnIngredients.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngredients.Location = new Point(71, 12);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(161, 38);
            btnIngredients.TabIndex = 1;
            btnIngredients.Text = "Ingredients";
            btnIngredients.UseVisualStyleBackColor = true;
            btnIngredients.Click += btnIngredients_Click;
            // 
            // btnRecipes
            // 
            btnRecipes.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecipes.Location = new Point(324, 12);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(136, 38);
            btnRecipes.TabIndex = 2;
            btnRecipes.Text = "Recipes";
            btnRecipes.UseVisualStyleBackColor = true;
            btnRecipes.Click += btnRecipes_Click;
            // 
            // btnBrewingHub
            // 
            btnBrewingHub.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrewingHub.Location = new Point(530, 12);
            btnBrewingHub.Name = "btnBrewingHub";
            btnBrewingHub.Size = new Size(197, 38);
            btnBrewingHub.TabIndex = 3;
            btnBrewingHub.Text = "Potions Hub";
            btnBrewingHub.UseVisualStyleBackColor = true;
            btnBrewingHub.Click += btnBrewingHub_Click;
            // 
            // lblFrequentlyBrewed
            // 
            lblFrequentlyBrewed.AutoSize = true;
            lblFrequentlyBrewed.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrequentlyBrewed.Location = new Point(12, 127);
            lblFrequentlyBrewed.Name = "lblFrequentlyBrewed";
            lblFrequentlyBrewed.Size = new Size(341, 23);
            lblFrequentlyBrewed.TabIndex = 4;
            lblFrequentlyBrewed.Text = "Most Frequently Brewed Potions:";
            // 
            // dgvFrequentlyBrewed
            // 
            dgvFrequentlyBrewed.AllowUserToAddRows = false;
            dgvFrequentlyBrewed.AllowUserToDeleteRows = false;
            dgvFrequentlyBrewed.AllowUserToResizeColumns = false;
            dgvFrequentlyBrewed.AllowUserToResizeRows = false;
            dgvFrequentlyBrewed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFrequentlyBrewed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFrequentlyBrewed.Location = new Point(12, 163);
            dgvFrequentlyBrewed.MultiSelect = false;
            dgvFrequentlyBrewed.Name = "dgvFrequentlyBrewed";
            dgvFrequentlyBrewed.RowHeadersVisible = false;
            dgvFrequentlyBrewed.RowHeadersWidth = 51;
            dgvFrequentlyBrewed.Size = new Size(368, 122);
            dgvFrequentlyBrewed.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(435, 127);
            label1.Name = "label1";
            label1.Size = new Size(317, 26);
            label1.TabIndex = 6;
            label1.Text = "Most Consumed Ingredients:";
            // 
            // dgvMostConsumed
            // 
            dgvMostConsumed.AllowUserToAddRows = false;
            dgvMostConsumed.AllowUserToDeleteRows = false;
            dgvMostConsumed.AllowUserToResizeColumns = false;
            dgvMostConsumed.AllowUserToResizeRows = false;
            dgvMostConsumed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMostConsumed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostConsumed.Location = new Point(435, 163);
            dgvMostConsumed.MultiSelect = false;
            dgvMostConsumed.Name = "dgvMostConsumed";
            dgvMostConsumed.RowHeadersVisible = false;
            dgvMostConsumed.RowHeadersWidth = 51;
            dgvMostConsumed.Size = new Size(330, 122);
            dgvMostConsumed.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 300);
            label2.Name = "label2";
            label2.Size = new Size(258, 26);
            label2.TabIndex = 8;
            label2.Text = "Brewing Throughput:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 341);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 9;
            label3.Text = "From:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 371);
            label4.Name = "label4";
            label4.Size = new Size(38, 21);
            label4.TabIndex = 10;
            label4.Text = "To:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(103, 338);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(167, 27);
            dtpFrom.TabIndex = 11;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(103, 371);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(167, 27);
            dtpTo.TabIndex = 12;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(306, 341);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(123, 36);
            btnGenerate.TabIndex = 13;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(453, 349);
            label5.Name = "label5";
            label5.Size = new Size(216, 21);
            label5.TabIndex = 14;
            label5.Text = "Total Potions Brewed:";
            // 
            // lblThroughput
            // 
            lblThroughput.AutoSize = true;
            lblThroughput.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThroughput.ForeColor = SystemColors.ActiveCaptionText;
            lblThroughput.Location = new Point(692, 349);
            lblThroughput.Name = "lblThroughput";
            lblThroughput.Size = new Size(10, 21);
            lblThroughput.TabIndex = 15;
            lblThroughput.Text = "\r\n";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblThroughput);
            Controls.Add(label5);
            Controls.Add(btnGenerate);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvMostConsumed);
            Controls.Add(label1);
            Controls.Add(dgvFrequentlyBrewed);
            Controls.Add(lblFrequentlyBrewed);
            Controls.Add(btnBrewingHub);
            Controls.Add(btnRecipes);
            Controls.Add(btnIngredients);
            Controls.Add(lblTitle);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)dgvFrequentlyBrewed).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMostConsumed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnIngredients;
        private Button btnRecipes;
        private Button btnBrewingHub;
        private Label lblFrequentlyBrewed;
        private DataGridView dgvFrequentlyBrewed;
        private Label label1;
        private DataGridView dgvMostConsumed;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnGenerate;
        private Label label5;
        private Label lblThroughput;
    }
}