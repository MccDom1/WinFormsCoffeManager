namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCoffees = new DataGridView();
            txtName = new TextBox();
            cmbSize = new ComboBox();
            txtPrice = new TextBox();
            chkIced = new CheckBox();
            cmbRoast = new ComboBox();
            numShots = new NumericUpDown();
            chkMilk = new CheckBox();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCoffees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numShots).BeginInit();
            SuspendLayout();
            // 
            // dgvCoffees
            // 
            dgvCoffees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoffees.Location = new Point(0, 214);
            dgvCoffees.Name = "dgvCoffees";
            dgvCoffees.RowHeadersWidth = 82;
            dgvCoffees.Size = new Size(799, 235);
            dgvCoffees.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(0, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 39);
            txtName.TabIndex = 1;
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(0, 57);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(200, 40);
            cmbSize.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(0, 103);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 39);
            txtPrice.TabIndex = 3;
            // 
            // chkIced
            // 
            chkIced.AutoSize = true;
            chkIced.Location = new Point(0, 148);
            chkIced.Name = "chkIced";
            chkIced.Size = new Size(159, 36);
            chkIced.TabIndex = 4;
            chkIced.Text = "checkBox1";
            chkIced.UseVisualStyleBackColor = true;
            // 
            // cmbRoast
            // 
            cmbRoast.FormattingEnabled = true;
            cmbRoast.Location = new Point(546, 12);
            cmbRoast.Name = "cmbRoast";
            cmbRoast.Size = new Size(242, 40);
            cmbRoast.TabIndex = 5;
            // 
            // numShots
            // 
            numShots.Location = new Point(546, 69);
            numShots.Name = "numShots";
            numShots.Size = new Size(240, 39);
            numShots.TabIndex = 6;
            // 
            // chkMilk
            // 
            chkMilk.AutoSize = true;
            chkMilk.Location = new Point(546, 131);
            chkMilk.Name = "chkMilk";
            chkMilk.Size = new Size(159, 36);
            chkMilk.TabIndex = 7;
            chkMilk.Text = "checkBox1";
            chkMilk.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(293, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(293, 84);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(chkMilk);
            Controls.Add(numShots);
            Controls.Add(cmbRoast);
            Controls.Add(chkIced);
            Controls.Add(txtPrice);
            Controls.Add(cmbSize);
            Controls.Add(txtName);
            Controls.Add(dgvCoffees);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCoffees).EndInit();
            ((System.ComponentModel.ISupportInitialize)numShots).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCoffees;
        private TextBox txtName;
        private ComboBox cmbSize;
        private TextBox txtPrice;
        private CheckBox chkIced;
        private ComboBox cmbRoast;
        private NumericUpDown numShots;
        private CheckBox chkMilk;
        private Button btnAdd;
        private Button btnDelete;
    }
}
