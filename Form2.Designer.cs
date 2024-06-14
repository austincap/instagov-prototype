namespace instagov_prototype
{
    partial class Form2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.dbid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.voteby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dbid,
            this.title,
            this.type,
            this.desc,
            this.voteby});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(166, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 286);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dbid
            // 
            this.dbid.DisplayIndex = 4;
            this.dbid.Text = "dbid";
            // 
            // title
            // 
            this.title.Text = "title";
            // 
            // type
            // 
            this.type.DisplayIndex = 0;
            this.type.Text = "type";
            // 
            // desc
            // 
            this.desc.DisplayIndex = 2;
            this.desc.Text = "desc";
            // 
            // voteby
            // 
            this.voteby.DisplayIndex = 3;
            this.voteby.Text = "voteby";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader dbid;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.ColumnHeader voteby;
    }
}