namespace GymRoom
{
    partial class frmChats
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
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            userControlChats1 = new UserControlChats();
            userControlChats2 = new UserControlChats();
            userControlChats3 = new UserControlChats();
            userControlChats4 = new UserControlChats();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Size = new Size(700, 338);
            splitContainer1.SplitterDistance = 280;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 312);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 26);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(userControlChats1);
            flowLayoutPanel1.Controls.Add(userControlChats2);
            flowLayoutPanel1.Controls.Add(userControlChats3);
            flowLayoutPanel1.Controls.Add(userControlChats4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(280, 338);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // userControlChats1
            // 
            userControlChats1.BackColor = SystemColors.ButtonFace;
            userControlChats1.Location = new Point(3, 2);
            userControlChats1.Margin = new Padding(3, 2, 3, 2);
            userControlChats1.Name = "userControlChats1";
            userControlChats1.Size = new Size(277, 60);
            userControlChats1.TabIndex = 0;
            // 
            // userControlChats2
            // 
            userControlChats2.BackColor = SystemColors.ButtonFace;
            userControlChats2.Location = new Point(3, 66);
            userControlChats2.Margin = new Padding(3, 2, 3, 2);
            userControlChats2.Name = "userControlChats2";
            userControlChats2.Size = new Size(277, 60);
            userControlChats2.TabIndex = 1;
            // 
            // userControlChats3
            // 
            userControlChats3.BackColor = SystemColors.ButtonFace;
            userControlChats3.Location = new Point(3, 130);
            userControlChats3.Margin = new Padding(3, 2, 3, 2);
            userControlChats3.Name = "userControlChats3";
            userControlChats3.Size = new Size(277, 60);
            userControlChats3.TabIndex = 2;
            // 
            // userControlChats4
            // 
            userControlChats4.BackColor = SystemColors.ButtonFace;
            userControlChats4.Location = new Point(3, 194);
            userControlChats4.Margin = new Padding(3, 2, 3, 2);
            userControlChats4.Name = "userControlChats4";
            userControlChats4.Size = new Size(388, 60);
            userControlChats4.TabIndex = 3;
            // 
            // frmChats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmChats";
            Text = "frmChats";
            Load += frmChats_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private UserControlChats userControlChats1;
        private UserControlChats userControlChats2;
        private UserControlChats userControlChats3;
        private UserControlChats userControlChats4;
    }
}