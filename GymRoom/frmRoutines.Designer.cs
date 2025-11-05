namespace GymRoom
{
    partial class frmRoutines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoutines));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvRoutine = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            label2 = new Label();
            txtName = new TextBox();
            panel1 = new Panel();
            txtDesc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoutine).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 32);
            label1.Name = "label1";
            label1.Size = new Size(551, 72);
            label1.TabIndex = 0;
            label1.Text = "Routine manager";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Dumbell;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(43, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 72);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvRoutine
            // 
            dgvRoutine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoutine.Location = new Point(13, 152);
            dgvRoutine.Name = "dgvRoutine";
            dgvRoutine.RowHeadersWidth = 51;
            dgvRoutine.Size = new Size(538, 188);
            dgvRoutine.TabIndex = 2;
            dgvRoutine.CellClick += dgvRoutine_CellClick;
            dgvRoutine.CellContentClick += dgvRoutine_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(568, 187);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 224, 192);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(568, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 224, 192);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(568, 257);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear field";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(451, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 16);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 8;
            label2.Text = "Routine name";
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(328, 27);
            txtName.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(dgvRoutine);
            panel1.Location = new Point(151, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 405);
            panel1.TabIndex = 10;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(117, 48);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(328, 27);
            txtDesc.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 57);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 11;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 131);
            label3.Name = "label3";
            label3.Size = new Size(171, 18);
            label3.TabIndex = 10;
            label3.Text = "Current available routines";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(568, 152);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmRoutines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 613);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRoutines";
            Text = "Routine";
            Load += frmRoutines_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoutine).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvRoutine;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private Label label2;
        private TextBox txtName;
        private Panel panel1;
        private Label label3;
        private TextBox txtDesc;
        private Label label4;
        private Button btnAdd;
    }
}