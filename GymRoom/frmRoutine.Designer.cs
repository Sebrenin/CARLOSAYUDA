namespace GymRoom
{
    partial class frmRoutine
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
            panel4 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 61);
            label1.Name = "label1";
            label1.Size = new Size(168, 44);
            label1.TabIndex = 1;
            label1.Text = "Routines";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 40);
            panel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 11, 11);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(24, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 292);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(89, 11, 11);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(297, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 292);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(89, 11, 11);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(569, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 292);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(217, 217, 217);
            panel5.Location = new Point(13, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(173, 244);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(217, 217, 217);
            panel6.Location = new Point(12, 31);
            panel6.Name = "panel6";
            panel6.Size = new Size(173, 244);
            panel6.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(217, 217, 217);
            panel7.Location = new Point(14, 31);
            panel7.Name = "panel7";
            panel7.Size = new Size(173, 244);
            panel7.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(89, 11, 11);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(49, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 15);
            textBox1.TabIndex = 6;
            textBox1.Text = "Routine name";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(89, 11, 11);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(55, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 15);
            textBox2.TabIndex = 7;
            textBox2.Text = "Routine name";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(89, 11, 11);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(57, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 15);
            textBox3.TabIndex = 8;
            textBox3.Text = "Routine name";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // frmRoutine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(label1);
            Name = "frmRoutine";
            Text = "frmRoutine";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel4;
        private Panel panel1;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel6;
        private TextBox textBox3;
        private Panel panel7;
    }
}