namespace MyDreamBook
{
    partial class FormHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(30, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(309, 50);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "내역 다시 불러오기";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 12;
            this.lbHistory.Items.AddRange(new object[] {
            resources.GetString("lbHistory.Items"),
            resources.GetString("lbHistory.Items1"),
            resources.GetString("lbHistory.Items2"),
            resources.GetString("lbHistory.Items3"),
            resources.GetString("lbHistory.Items4")});
            this.lbHistory.Location = new System.Drawing.Point(30, 104);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(735, 304);
            this.lbHistory.TabIndex = 2;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.btnRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lbHistory;
    }
}