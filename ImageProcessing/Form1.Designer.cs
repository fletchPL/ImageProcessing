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
            this.pictureBoxEdgesDetected = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginPicture = new System.Windows.Forms.PictureBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.tabFeaturesSelectionPages = new System.Windows.Forms.TabPage();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.sfsRadioButton = new System.Windows.Forms.RadioButton();
            this.fisherRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.classifiersTabPage = new System.Windows.Forms.TabPage();
            this.executeButton = new System.Windows.Forms.Button();
            this.trainingTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrainButton = new System.Windows.Forms.Button();
            this.KcomboBox = new System.Windows.Forms.ComboBox();
            this.Klabel = new System.Windows.Forms.Label();
            this.ClassifieresComboBox = new System.Windows.Forms.ComboBox();
            this.ClassifieresLabel = new System.Windows.Forms.Label();
            this.saveFileButtonClassifiers = new System.Windows.Forms.Button();
            this.openFileButtonClassifiers = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tablePages.SuspendLayout();
            this.preprocessingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdgesDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginPicture)).BeginInit();
            this.tabFeaturesSelectionPages.SuspendLayout();
            this.classifiersTabPage.SuspendLayout();
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
            this.tablePages.Size = new System.Drawing.Size(815, 431);
            this.tablePages.TabIndex = 0;
            // 
            // preprocessingTabPage
            // 
            this.preprocessingTabPage.Controls.Add(this.pictureBoxEdgesDetected);
            this.preprocessingTabPage.Controls.Add(this.pictureBoxOriginPicture);
            this.preprocessingTabPage.Controls.Add(this.selectFolderButton);
            this.preprocessingTabPage.Location = new System.Drawing.Point(4, 22);
            this.preprocessingTabPage.Name = "preprocessingTabPage";
            this.preprocessingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.preprocessingTabPage.Size = new System.Drawing.Size(807, 405);
            this.preprocessingTabPage.TabIndex = 0;
            this.preprocessingTabPage.Text = "Preprocessing";
            this.preprocessingTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEdgesDetected
            // 
            this.pictureBoxEdgesDetected.Location = new System.Drawing.Point(570, 199);
            this.pictureBoxEdgesDetected.Name = "pictureBoxEdgesDetected";
            this.pictureBoxEdgesDetected.Size = new System.Drawing.Size(231, 178);
            this.pictureBoxEdgesDetected.TabIndex = 3;
            this.pictureBoxEdgesDetected.TabStop = false;
            // 
            // pictureBoxOriginPicture
            // 
            this.pictureBoxOriginPicture.Location = new System.Drawing.Point(570, 6);
            this.pictureBoxOriginPicture.Name = "pictureBoxOriginPicture";
            this.pictureBoxOriginPicture.Size = new System.Drawing.Size(231, 178);
            this.pictureBoxOriginPicture.TabIndex = 2;
            this.pictureBoxOriginPicture.TabStop = false;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(6, 6);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(104, 45);
            this.selectFolderButton.TabIndex = 1;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // tabFeaturesSelectionPages
            // 
            this.tabFeaturesSelectionPages.Controls.Add(this.comboBox);
            this.tabFeaturesSelectionPages.Controls.Add(this.computeButton);
            this.tabFeaturesSelectionPages.Controls.Add(this.sfsRadioButton);
            this.tabFeaturesSelectionPages.Controls.Add(this.fisherRadioButton);
            this.tabFeaturesSelectionPages.Controls.Add(this.label1);
            this.tabFeaturesSelectionPages.Controls.Add(this.saveFileButton);
            this.tabFeaturesSelectionPages.Controls.Add(this.openFileButton);
            this.tabFeaturesSelectionPages.Location = new System.Drawing.Point(4, 22);
            this.tabFeaturesSelectionPages.Name = "tabFeaturesSelectionPages";
            this.tabFeaturesSelectionPages.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeaturesSelectionPages.Size = new System.Drawing.Size(807, 405);
            this.tabFeaturesSelectionPages.TabIndex = 1;
            this.tabFeaturesSelectionPages.Text = "Features Selection";
            this.tabFeaturesSelectionPages.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(282, 33);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(104, 21);
            this.comboBox.TabIndex = 6;
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(392, 20);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(89, 44);
            this.computeButton.TabIndex = 5;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = true;
            // 
            // sfsRadioButton
            // 
            this.sfsRadioButton.AutoSize = true;
            this.sfsRadioButton.Location = new System.Drawing.Point(277, 98);
            this.sfsRadioButton.Name = "sfsRadioButton";
            this.sfsRadioButton.Size = new System.Drawing.Size(45, 17);
            this.sfsRadioButton.TabIndex = 4;
            this.sfsRadioButton.TabStop = true;
            this.sfsRadioButton.Text = "SFS";
            this.sfsRadioButton.UseVisualStyleBackColor = true;
            // 
            // fisherRadioButton
            // 
            this.fisherRadioButton.AutoSize = true;
            this.fisherRadioButton.Location = new System.Drawing.Point(277, 70);
            this.fisherRadioButton.Name = "fisherRadioButton";
            this.fisherRadioButton.Size = new System.Drawing.Size(53, 17);
            this.fisherRadioButton.TabIndex = 3;
            this.fisherRadioButton.TabStop = true;
            this.fisherRadioButton.Text = "Fisher";
            this.fisherRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feature number: ";
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(20, 70);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(100, 45);
            this.saveFileButton.TabIndex = 1;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(20, 20);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(100, 44);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            // 
            // classifiersTabPage
            // 
            this.classifiersTabPage.Controls.Add(this.executeButton);
            this.classifiersTabPage.Controls.Add(this.trainingTextBox);
            this.classifiersTabPage.Controls.Add(this.label2);
            this.classifiersTabPage.Controls.Add(this.TrainButton);
            this.classifiersTabPage.Controls.Add(this.KcomboBox);
            this.classifiersTabPage.Controls.Add(this.Klabel);
            this.classifiersTabPage.Controls.Add(this.ClassifieresComboBox);
            this.classifiersTabPage.Controls.Add(this.ClassifieresLabel);
            this.classifiersTabPage.Controls.Add(this.saveFileButtonClassifiers);
            this.classifiersTabPage.Controls.Add(this.openFileButtonClassifiers);
            this.classifiersTabPage.Location = new System.Drawing.Point(4, 22);
            this.classifiersTabPage.Name = "classifiersTabPage";
            this.classifiersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classifiersTabPage.Size = new System.Drawing.Size(807, 405);
            this.classifiersTabPage.TabIndex = 2;
            this.classifiersTabPage.Text = "Classifiers";
            this.classifiersTabPage.UseVisualStyleBackColor = true;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(666, 6);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(96, 44);
            this.executeButton.TabIndex = 11;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            // 
            // trainingTextBox
            // 
            this.trainingTextBox.Location = new System.Drawing.Point(492, 69);
            this.trainingTextBox.Name = "trainingTextBox";
            this.trainingTextBox.Size = new System.Drawing.Size(100, 20);
            this.trainingTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Training part:";
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(492, 6);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(96, 44);
            this.TrainButton.TabIndex = 8;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            // 
            // KcomboBox
            // 
            this.KcomboBox.FormattingEnabled = true;
            this.KcomboBox.Location = new System.Drawing.Point(273, 69);
            this.KcomboBox.Name = "KcomboBox";
            this.KcomboBox.Size = new System.Drawing.Size(121, 21);
            this.KcomboBox.TabIndex = 7;
            // 
            // Klabel
            // 
            this.Klabel.AutoSize = true;
            this.Klabel.Location = new System.Drawing.Point(244, 72);
            this.Klabel.Name = "Klabel";
            this.Klabel.Size = new System.Drawing.Size(23, 13);
            this.Klabel.TabIndex = 6;
            this.Klabel.Text = "K : ";
            // 
            // ClassifieresComboBox
            // 
            this.ClassifieresComboBox.FormattingEnabled = true;
            this.ClassifieresComboBox.Location = new System.Drawing.Point(273, 19);
            this.ClassifieresComboBox.Name = "ClassifieresComboBox";
            this.ClassifieresComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassifieresComboBox.TabIndex = 5;
            // 
            // ClassifieresLabel
            // 
            this.ClassifieresLabel.AutoSize = true;
            this.ClassifieresLabel.Location = new System.Drawing.Point(199, 22);
            this.ClassifieresLabel.Name = "ClassifieresLabel";
            this.ClassifieresLabel.Size = new System.Drawing.Size(68, 13);
            this.ClassifieresLabel.TabIndex = 4;
            this.ClassifieresLabel.Text = "Classifieres : ";
            // 
            // saveFileButtonClassifiers
            // 
            this.saveFileButtonClassifiers.Location = new System.Drawing.Point(6, 56);
            this.saveFileButtonClassifiers.Name = "saveFileButtonClassifiers";
            this.saveFileButtonClassifiers.Size = new System.Drawing.Size(100, 45);
            this.saveFileButtonClassifiers.TabIndex = 3;
            this.saveFileButtonClassifiers.Text = "Save File";
            this.saveFileButtonClassifiers.UseVisualStyleBackColor = true;
            // 
            // openFileButtonClassifiers
            // 
            this.openFileButtonClassifiers.Location = new System.Drawing.Point(6, 6);
            this.openFileButtonClassifiers.Name = "openFileButtonClassifiers";
            this.openFileButtonClassifiers.Size = new System.Drawing.Size(100, 44);
            this.openFileButtonClassifiers.TabIndex = 2;
            this.openFileButtonClassifiers.Text = "Open File";
            this.openFileButtonClassifiers.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 455);
            this.Controls.Add(this.tablePages);
            this.Name = "Form1";
            this.Text = "SMPD";
            this.tablePages.ResumeLayout(false);
            this.preprocessingTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdgesDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginPicture)).EndInit();
            this.tabFeaturesSelectionPages.ResumeLayout(false);
            this.tabFeaturesSelectionPages.PerformLayout();
            this.classifiersTabPage.ResumeLayout(false);
            this.classifiersTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tablePages;
        private System.Windows.Forms.TabPage preprocessingTabPage;
        private System.Windows.Forms.TabPage tabFeaturesSelectionPages;
        private System.Windows.Forms.TabPage classifiersTabPage;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.PictureBox pictureBoxEdgesDetected;
        private System.Windows.Forms.PictureBox pictureBoxOriginPicture;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.RadioButton fisherRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sfsRadioButton;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button saveFileButtonClassifiers;
        private System.Windows.Forms.Button openFileButtonClassifiers;
        private System.Windows.Forms.Label ClassifieresLabel;
        private System.Windows.Forms.ComboBox ClassifieresComboBox;
        private System.Windows.Forms.Label Klabel;
        private System.Windows.Forms.ComboBox KcomboBox;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.TextBox trainingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

