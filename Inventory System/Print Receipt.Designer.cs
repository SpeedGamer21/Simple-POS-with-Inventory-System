namespace Inventory_System
{
    partial class frmReceipt
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
            this.myViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Receipt2 = new Inventory_System.Receipt();
            this.Receipt1 = new Inventory_System.Receipt();
            this.SuspendLayout();
            // 
            // myViewer
            // 
            this.myViewer.ActiveViewIndex = 0;
            this.myViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.myViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myViewer.Location = new System.Drawing.Point(0, 0);
            this.myViewer.Name = "myViewer";
            this.myViewer.ReportSource = this.Receipt2;
            this.myViewer.Size = new System.Drawing.Size(722, 465);
            this.myViewer.TabIndex = 0;
            this.myViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 465);
            this.Controls.Add(this.myViewer);
            this.Name = "frmReceipt";
            this.Text = "Print Receipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Receipt Receipt1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer myViewer;
        private Receipt Receipt2;
    }
}