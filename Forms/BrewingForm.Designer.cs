namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    partial class BrewingForm
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            btnConsumePotion = new Button();
            btnDelete = new Button();
            dgvBrewedPotions = new DataGridView();
            btnBack = new Button();
            cmbRecipes = new ComboBox();
            timerBrewing = new System.Windows.Forms.Timer(components);
            btnStartBrewing = new Button();
            progressBar = new ProgressBar();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBrewedPotions).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(309, 19);
            label2.Name = "label2";
            label2.Size = new Size(179, 31);
            label2.TabIndex = 1;
            label2.Text = "Potions Hub";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(504, 74);
            label3.Name = "label3";
            label3.Size = new Size(213, 29);
            label3.TabIndex = 2;
            label3.Text = "Brewed Potions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 74);
            label1.Name = "label1";
            label1.Size = new Size(171, 29);
            label1.TabIndex = 3;
            label1.Text = "Brew Potion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(159, 26);
            label4.TabIndex = 4;
            label4.Text = "Select Recipe:";
            // 
            // btnConsumePotion
            // 
            btnConsumePotion.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsumePotion.Location = new Point(470, 387);
            btnConsumePotion.Name = "btnConsumePotion";
            btnConsumePotion.Size = new Size(169, 29);
            btnConsumePotion.TabIndex = 6;
            btnConsumePotion.Text = "Consume Potion";
            btnConsumePotion.UseVisualStyleBackColor = true;
            btnConsumePotion.Click += btnConsumePotion_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(658, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvBrewedPotions
            // 
            dgvBrewedPotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBrewedPotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrewedPotions.Location = new Point(443, 163);
            dgvBrewedPotions.Name = "dgvBrewedPotions";
            dgvBrewedPotions.RowHeadersWidth = 51;
            dgvBrewedPotions.Size = new Size(326, 188);
            dgvBrewedPotions.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(26, 399);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(201, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back to dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbRecipes
            // 
            cmbRecipes.FormattingEnabled = true;
            cmbRecipes.Location = new Point(177, 147);
            cmbRecipes.Name = "cmbRecipes";
            cmbRecipes.Size = new Size(229, 28);
            cmbRecipes.TabIndex = 10;
            // 
            // timerBrewing
            // 
            timerBrewing.Interval = 50;
            timerBrewing.Tick += timerBrewing_Tick;
            // 
            // btnStartBrewing
            // 
            btnStartBrewing.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartBrewing.Location = new Point(103, 215);
            btnStartBrewing.Name = "btnStartBrewing";
            btnStartBrewing.Size = new Size(187, 29);
            btnStartBrewing.TabIndex = 11;
            btnStartBrewing.Text = "Start Brewing!";
            btnStartBrewing.UseVisualStyleBackColor = true;
            btnStartBrewing.Click += btnStartBrewing_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(26, 290);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(329, 29);
            progressBar.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(437, 121);
            label5.Name = "label5";
            label5.Size = new Size(332, 21);
            label5.TabIndex = 13;
            label5.Text = "Select potion to consume or delete:";
            // 
            // BrewingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(progressBar);
            Controls.Add(btnStartBrewing);
            Controls.Add(cmbRecipes);
            Controls.Add(btnBack);
            Controls.Add(dgvBrewedPotions);
            Controls.Add(btnDelete);
            Controls.Add(btnConsumePotion);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "BrewingForm";
            Text = "BrewingForm";
            Load += BrewingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBrewedPotions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Button btnConsumePotion;
        private Button btnDelete;
        private DataGridView dgvBrewedPotions;
        private Button btnBack;
        private ComboBox cmbRecipes;
        private System.Windows.Forms.Timer timerBrewing;
        private Button btnStartBrewing;
        private ProgressBar progressBar;
        private Label label5;
    }
}