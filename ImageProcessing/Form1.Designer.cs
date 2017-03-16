namespace ImageProcessing
{
    partial class Form1
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
            this.tablePages = new System.Windows.Forms.TabControl();
            this.preprocessingTabPage = new System.Windows.Forms.TabPage();
            this.tabFeaturesSelectionPages = new System.Windows.Forms.TabPage();
            this.classifiersTabPage = new System.Windows.Forms.TabPage();
            this.tablePages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePages
            // 
            this.tablePages.Controls.Add(this.preprocessingTabPage);
            this.tablePages.Controls.Add(this.tabFeaturesSelectionPages);
            this.tablePages.Controls.Add(this.classifiersTabPage);
            this.tablePages.Location = new System.Drawing.Point(12, 12);
            this.tablePages.Name = "tablePages";
            this.tablePages.SelectedIndex = 0;
            this.tablePages.Size = new System.Drawing.Size(523, 445);
            this.tablePages.TabIndex = 0;
            // 
            // preprocessingTabPage
            // 
            this.preprocessingTabPage.Location = new System.Drawing.Point(4, 22);
            this.preprocessingTabPage.Name = "preprocessingTabPage";
            this.preprocessingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.preprocessingTabPage.Size = new System.Drawing.Size(515, 419);
            this.preprocessingTabPage.TabIndex = 0;
            this.preprocessingTabPage.Text = "Preprocessing";
            this.preprocessingTabPage.UseVisualStyleBackColor = true;
            // 
            // tabFeaturesSelectionPages
            // 
            this.tabFeaturesSelectionPages.Location = new System.Drawing.Point(4, 22);
            this.tabFeaturesSelectionPages.Name = "tabFeaturesSelectionPages";
            this.tabFeaturesSelectionPages.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeaturesSelectionPages.Size = new System.Drawing.Size(515, 419);
            this.tabFeaturesSelectionPages.TabIndex = 1;
            this.tabFeaturesSelectionPages.Text = "Features Selection";
            this.tabFeaturesSelectionPages.UseVisualStyleBackColor = true;
            // 
            // classifiersTabPage
            // 
            this.classifiersTabPage.Location = new System.Drawing.Point(4, 22);
            this.classifiersTabPage.Name = "classifiersTabPage";
            this.classifiersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classifiersTabPage.Size = new System.Drawing.Size(515, 419);
            this.classifiersTabPage.TabIndex = 2;
            this.classifiersTabPage.Text = "Classifiers";
            this.classifiersTabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 469);
            this.Controls.Add(this.tablePages);
            this.Name = "Form1";
            this.Text = "SMPD";
            this.tablePages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tablePages;
        private System.Windows.Forms.TabPage preprocessingTabPage;
        private System.Windows.Forms.TabPage tabFeaturesSelectionPages;
        private System.Windows.Forms.TabPage classifiersTabPage;
    }
}

