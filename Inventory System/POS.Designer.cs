namespace Inventory_System
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.frmAddItem = new System.Windows.Forms.Button();
            this.frmDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frmCancel = new System.Windows.Forms.Button();
            this.frmExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.frmTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtxn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeight = 25;
            this.dgv1.Location = new System.Drawing.Point(10, 81);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(876, 372);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmAddItem
            // 
            this.frmAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmAddItem.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmAddItem.Image = ((System.Drawing.Image)(resources.GetObject("frmAddItem.Image")));
            this.frmAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frmAddItem.Location = new System.Drawing.Point(10, 517);
            this.frmAddItem.Name = "frmAddItem";
            this.frmAddItem.Size = new System.Drawing.Size(155, 78);
            this.frmAddItem.TabIndex = 1;
            this.frmAddItem.Text = "&Add Item";
            this.frmAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frmAddItem.UseVisualStyleBackColor = true;
            this.frmAddItem.Click += new System.EventHandler(this.frmAddItem_Click);
            // 
            // frmDelete
            // 
            this.frmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmDelete.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDelete.Image = ((System.Drawing.Image)(resources.GetObject("frmDelete.Image")));
            this.frmDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frmDelete.Location = new System.Drawing.Point(171, 518);
            this.frmDelete.Name = "frmDelete";
            this.frmDelete.Size = new System.Drawing.Size(155, 77);
            this.frmDelete.TabIndex = 2;
            this.frmDelete.Text = "&Delete";
            this.frmDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frmDelete.UseVisualStyleBackColor = true;
            this.frmDelete.Click += new System.EventHandler(this.frmDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "₱";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL:";
            // 
            // frmCancel
            // 
            this.frmCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmCancel.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmCancel.Image = ((System.Drawing.Image)(resources.GetObject("frmCancel.Image")));
            this.frmCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frmCancel.Location = new System.Drawing.Point(333, 517);
            this.frmCancel.Name = "frmCancel";
            this.frmCancel.Size = new System.Drawing.Size(155, 77);
            this.frmCancel.TabIndex = 7;
            this.frmCancel.Text = "&Cancel";
            this.frmCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frmCancel.UseVisualStyleBackColor = true;
            this.frmCancel.Click += new System.EventHandler(this.frmCancel_Click);
            // 
            // frmExit
            // 
            this.frmExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmExit.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frmExit.Location = new System.Drawing.Point(820, 515);
            this.frmExit.Name = "frmExit";
            this.frmExit.Size = new System.Drawing.Size(66, 78);
            this.frmExit.TabIndex = 8;
            this.frmExit.Text = "&Exit";
            this.frmExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frmExit.UseVisualStyleBackColor = true;
            this.frmExit.Click += new System.EventHandler(this.frmExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 57);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(494, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 78);
            this.button1.TabIndex = 11;
            this.button1.Text = "Check &Out";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmTotal
            // 
            this.frmTotal.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmTotal.Location = new System.Drawing.Point(652, 468);
            this.frmTotal.Name = "frmTotal";
            this.frmTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frmTotal.Size = new System.Drawing.Size(234, 35);
            this.frmTotal.TabIndex = 12;
            this.frmTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hotkeys ALT +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Add = A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Delete = D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cancel = C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Check Out = O";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(648, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Transaction ID:";
            // 
            // txtxn
            // 
            this.txtxn.AutoSize = true;
            this.txtxn.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxn.Location = new System.Drawing.Point(759, 58);
            this.txtxn.Name = "txtxn";
            this.txtxn.Size = new System.Drawing.Size(107, 20);
            this.txtxn.TabIndex = 19;
            this.txtxn.Text = "Transaction ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(391, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Edit QTY = Q";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(898, 604);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtxn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frmTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.frmExit);
            this.Controls.Add(this.frmCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmDelete);
            this.Controls.Add(this.frmAddItem);
            this.Controls.Add(this.dgv1);
            this.Name = "frmPOS";
            this.Text = "Point of Sale - Inventory Management System";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmAddItem;
        private System.Windows.Forms.Button frmDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button frmCancel;
        private System.Windows.Forms.Button frmExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox frmTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label txtxn;
        private System.Windows.Forms.Label label9;
    }
}