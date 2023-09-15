namespace ImageSorter
{
    partial class Bildsortierer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bildsortierer));
            this.CreateCategory = new System.Windows.Forms.Button();
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.PictureViewer = new System.Windows.Forms.PictureBox();
            this.ImageSourceButton = new System.Windows.Forms.Button();
            this.ImageDestinationButton = new System.Windows.Forms.Button();
            this.Filename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCategory
            // 
            this.CreateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateCategory.AutoSize = true;
            this.CreateCategory.Enabled = false;
            this.CreateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCategory.Location = new System.Drawing.Point(740, 513);
            this.CreateCategory.Margin = new System.Windows.Forms.Padding(4);
            this.CreateCategory.Name = "CreateCategory";
            this.CreateCategory.Size = new System.Drawing.Size(311, 34);
            this.CreateCategory.TabIndex = 0;
            this.CreateCategory.Text = "Neue Kategorie Erstellen";
            this.CreateCategory.UseVisualStyleBackColor = true;
            this.CreateCategory.Click += new System.EventHandler(this.CreateCategory_Click);
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CategoryPanel.Location = new System.Drawing.Point(735, 15);
            this.CategoryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(316, 489);
            this.CategoryPanel.TabIndex = 1;
            // 
            // PictureViewer
            // 
            this.PictureViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureViewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureViewer.Location = new System.Drawing.Point(16, 33);
            this.PictureViewer.Margin = new System.Windows.Forms.Padding(4);
            this.PictureViewer.Name = "PictureViewer";
            this.PictureViewer.Size = new System.Drawing.Size(711, 471);
            this.PictureViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureViewer.TabIndex = 2;
            this.PictureViewer.TabStop = false;
            this.PictureViewer.DoubleClick += new System.EventHandler(this.PictureViewer_DoubleClick);
            // 
            // ImageSourceButton
            // 
            this.ImageSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageSourceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageSourceButton.Location = new System.Drawing.Point(16, 513);
            this.ImageSourceButton.Margin = new System.Windows.Forms.Padding(4);
            this.ImageSourceButton.Name = "ImageSourceButton";
            this.ImageSourceButton.Size = new System.Drawing.Size(351, 34);
            this.ImageSourceButton.TabIndex = 3;
            this.ImageSourceButton.Text = "Wähle Quell-Verzeichnis der Bilder";
            this.ImageSourceButton.UseVisualStyleBackColor = true;
            this.ImageSourceButton.Click += new System.EventHandler(this.ImageSourceButton_Click);
            // 
            // ImageDestinationButton
            // 
            this.ImageDestinationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageDestinationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageDestinationButton.Location = new System.Drawing.Point(376, 512);
            this.ImageDestinationButton.Margin = new System.Windows.Forms.Padding(4);
            this.ImageDestinationButton.Name = "ImageDestinationButton";
            this.ImageDestinationButton.Size = new System.Drawing.Size(351, 35);
            this.ImageDestinationButton.TabIndex = 4;
            this.ImageDestinationButton.Text = "Wähle Ziel-Verzeichnis der Bilder";
            this.ImageDestinationButton.UseVisualStyleBackColor = true;
            this.ImageDestinationButton.Click += new System.EventHandler(this.ImageDestinationButton_Click);
            // 
            // Filename
            // 
            this.Filename.AutoSize = true;
            this.Filename.Location = new System.Drawing.Point(13, 13);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(73, 16);
            this.Filename.TabIndex = 5;
            this.Filename.Text = "Dateiname";
            // 
            // Bildsortierer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.ImageDestinationButton);
            this.Controls.Add(this.ImageSourceButton);
            this.Controls.Add(this.CreateCategory);
            this.Controls.Add(this.PictureViewer);
            this.Controls.Add(this.CategoryPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bildsortierer";
            this.Text = "Bildsortierer";
            ((System.ComponentModel.ISupportInitialize)(this.PictureViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCategory;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.PictureBox PictureViewer;
        private System.Windows.Forms.Button ImageSourceButton;
        private System.Windows.Forms.Button ImageDestinationButton;
        private System.Windows.Forms.Label Filename;
    }
}

