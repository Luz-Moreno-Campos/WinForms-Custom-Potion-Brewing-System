namespace WinForms_Custom_Potion_Brewing_System.Forms
{
    partial class PotionEffectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PotionEffectForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 35);
            label1.Name = "label1";
            label1.Size = new Size(745, 46);
            label1.TabIndex = 1;
            label1.Text = "You have consumed  a witch's potion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 95);
            label2.Name = "label2";
            label2.Size = new Size(622, 46);
            label2.TabIndex = 2;
            label2.Text = "Be prepared to feel its effect!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(307, 214);
            label3.Name = "label3";
            label3.Size = new Size(106, 29);
            label3.TabIndex = 3;
            label3.Text = "Potion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(312, 282);
            label4.Name = "label4";
            label4.Size = new Size(101, 29);
            label4.TabIndex = 4;
            label4.Text = "Effect:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(407, 214);
            label5.Name = "label5";
            label5.Size = new Size(0, 29);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(407, 282);
            label6.Name = "label6";
            label6.Size = new Size(0, 29);
            label6.TabIndex = 6;
            label6.Click += label6_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(677, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // PotionEffectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PotionEffectForm";
            Text = "PotionEffectForm";
            Load += PotionEffectForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnClose;
    }
}