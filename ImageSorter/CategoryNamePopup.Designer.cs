namespace ImageSorter
{
    partial class CategoryNamePopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryNamePopup));
            this.PupupHeader = new System.Windows.Forms.Label();
            this.CancelCategory = new System.Windows.Forms.Button();
            this.ApplyCategory = new System.Windows.Forms.Button();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PupupHeader
            // 
            this.PupupHeader.AutoSize = true;
            this.PupupHeader.Location = new System.Drawing.Point(17, 16);
            this.PupupHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PupupHeader.Name = "PupupHeader";
            this.PupupHeader.Size = new System.Drawing.Size(315, 16);
            this.PupupHeader.TabIndex = 1;
            this.PupupHeader.Text = "Es wird eine Kategorie mit folgenden Namen erstellt:";
            // 
            // CancelCategory
            // 
            this.CancelCategory.Location = new System.Drawing.Point(17, 90);
            this.CancelCategory.Margin = new System.Windows.Forms.Padding(4);
            this.CancelCategory.Name = "CancelCategory";
            this.CancelCategory.Size = new System.Drawing.Size(100, 28);
            this.CancelCategory.TabIndex = 2;
            this.CancelCategory.Text = "Abbrechen";
            this.CancelCategory.UseVisualStyleBackColor = true;
            // 
            // ApplyCategory
            // 
            this.ApplyCategory.Location = new System.Drawing.Point(257, 90);
            this.ApplyCategory.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyCategory.Name = "ApplyCategory";
            this.ApplyCategory.Size = new System.Drawing.Size(100, 28);
            this.ApplyCategory.TabIndex = 3;
            this.ApplyCategory.Text = "Bestätigen";
            this.ApplyCategory.UseVisualStyleBackColor = true;
            // 
            // CategoryName
            // 
            this.CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryName.Location = new System.Drawing.Point(21, 49);
            this.CategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(335, 23);
            this.CategoryName.TabIndex = 4;
            this.CategoryName.Text = "CategoryName";
            // 
            // CategoryNamePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 133);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.ApplyCategory);
            this.Controls.Add(this.CancelCategory);
            this.Controls.Add(this.PupupHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryNamePopup";
            this.Text = "CategoryNamePopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label PupupHeader;
        private System.Windows.Forms.Button CancelCategory;
        private System.Windows.Forms.Button ApplyCategory;
        private System.Windows.Forms.TextBox CategoryName;
    }
}