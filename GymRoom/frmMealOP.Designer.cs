namespace GymRoom
{
    partial class frmMealOP
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(127, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 341);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 2;
            label1.Text = "Meal Plan";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(159, 38, 38);
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(444, 133);
            button1.Name = "button1";
            button1.Size = new Size(210, 76);
            button1.TabIndex = 3;
            button1.Text = "Add a table";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(191, 69, 21);
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(444, 273);
            button2.Name = "button2";
            button2.Size = new Size(210, 76);
            button2.TabIndex = 4;
            button2.Text = "Add a list";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmMealOP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "frmMealOP";
            Text = "frmMealOP";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}