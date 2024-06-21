namespace instagov_prototype
{
    partial class Form3
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
            this.lawView = new System.Windows.Forms.ListView();
            this.refreshPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lawView
            // 
            this.lawView.HideSelection = false;
            this.lawView.Location = new System.Drawing.Point(174, 63);
            this.lawView.Name = "lawView";
            this.lawView.Size = new System.Drawing.Size(278, 290);
            this.lawView.TabIndex = 0;
            this.lawView.UseCompatibleStateImageBehavior = false;
            // 
            // refreshPage
            // 
            this.refreshPage.Location = new System.Drawing.Point(259, 372);
            this.refreshPage.Name = "refreshPage";
            this.refreshPage.Size = new System.Drawing.Size(75, 23);
            this.refreshPage.TabIndex = 1;
            this.refreshPage.Text = "refresh page";
            this.refreshPage.UseVisualStyleBackColor = true;
            this.refreshPage.Click += new System.EventHandler(this.refreshPage_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshPage);
            this.Controls.Add(this.lawView);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lawView;
        private System.Windows.Forms.Button refreshPage;
    }
}