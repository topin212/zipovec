namespace zipovec {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rollBackButton = new System.Windows.Forms.Button();
            this.commitToArchiveButton = new System.Windows.Forms.Button();
            this.re3moveFileFromPackageButton = new System.Windows.Forms.Button();
            this.getFileFromPackageButton = new System.Windows.Forms.Button();
            this.addFileToPackageButton = new System.Windows.Forms.Button();
            this.packageFileListView = new System.Windows.Forms.ListView();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.addNewFile = new System.Windows.Forms.Button();
            this.fileListView = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rollBackButton);
            this.panel1.Controls.Add(this.commitToArchiveButton);
            this.panel1.Controls.Add(this.re3moveFileFromPackageButton);
            this.panel1.Controls.Add(this.getFileFromPackageButton);
            this.panel1.Controls.Add(this.addFileToPackageButton);
            this.panel1.Controls.Add(this.packageFileListView);
            this.panel1.Controls.Add(this.outputTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.openFileButton);
            this.panel1.Controls.Add(this.addNewFile);
            this.panel1.Controls.Add(this.fileListView);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 464);
            this.panel1.TabIndex = 0;
            // 
            // rollBackButton
            // 
            this.rollBackButton.Location = new System.Drawing.Point(680, 436);
            this.rollBackButton.Name = "rollBackButton";
            this.rollBackButton.Size = new System.Drawing.Size(75, 23);
            this.rollBackButton.TabIndex = 15;
            this.rollBackButton.Text = "Rollback";
            this.rollBackButton.UseVisualStyleBackColor = true;
            // 
            // commitToArchiveButton
            // 
            this.commitToArchiveButton.Location = new System.Drawing.Point(418, 436);
            this.commitToArchiveButton.Name = "commitToArchiveButton";
            this.commitToArchiveButton.Size = new System.Drawing.Size(75, 23);
            this.commitToArchiveButton.TabIndex = 14;
            this.commitToArchiveButton.Text = "Commit";
            this.commitToArchiveButton.UseVisualStyleBackColor = true;
            // 
            // re3moveFileFromPackageButton
            // 
            this.re3moveFileFromPackageButton.Location = new System.Drawing.Point(337, 251);
            this.re3moveFileFromPackageButton.Name = "re3moveFileFromPackageButton";
            this.re3moveFileFromPackageButton.Size = new System.Drawing.Size(75, 23);
            this.re3moveFileFromPackageButton.TabIndex = 13;
            this.re3moveFileFromPackageButton.Text = "x";
            this.re3moveFileFromPackageButton.UseVisualStyleBackColor = true;
            // 
            // getFileFromPackageButton
            // 
            this.getFileFromPackageButton.Location = new System.Drawing.Point(337, 222);
            this.getFileFromPackageButton.Name = "getFileFromPackageButton";
            this.getFileFromPackageButton.Size = new System.Drawing.Size(75, 23);
            this.getFileFromPackageButton.TabIndex = 12;
            this.getFileFromPackageButton.Text = "<-";
            this.getFileFromPackageButton.UseVisualStyleBackColor = true;
            // 
            // addFileToPackageButton
            // 
            this.addFileToPackageButton.Location = new System.Drawing.Point(337, 193);
            this.addFileToPackageButton.Name = "addFileToPackageButton";
            this.addFileToPackageButton.Size = new System.Drawing.Size(75, 23);
            this.addFileToPackageButton.TabIndex = 11;
            this.addFileToPackageButton.Text = "->";
            this.addFileToPackageButton.UseVisualStyleBackColor = true;
            // 
            // packageFileListView
            // 
            this.packageFileListView.Location = new System.Drawing.Point(418, 62);
            this.packageFileListView.Name = "packageFileListView";
            this.packageFileListView.Size = new System.Drawing.Size(337, 368);
            this.packageFileListView.TabIndex = 10;
            this.packageFileListView.UseCompatibleStateImageBehavior = false;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(418, 26);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(337, 20);
            this.outputTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output file name:";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(256, 33);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 7;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // addNewFile
            // 
            this.addNewFile.Location = new System.Drawing.Point(256, 3);
            this.addNewFile.Name = "addNewFile";
            this.addNewFile.Size = new System.Drawing.Size(75, 23);
            this.addNewFile.TabIndex = 6;
            this.addNewFile.Text = "Create new";
            this.addNewFile.UseVisualStyleBackColor = true;
            this.addNewFile.Click += new System.EventHandler(this.addNewFile_Click);
            // 
            // fileListView
            // 
            this.fileListView.Location = new System.Drawing.Point(16, 62);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(315, 397);
            this.fileListView.TabIndex = 5;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disks:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 488);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rollBackButton;
        private System.Windows.Forms.Button commitToArchiveButton;
        private System.Windows.Forms.Button re3moveFileFromPackageButton;
        private System.Windows.Forms.Button getFileFromPackageButton;
        private System.Windows.Forms.Button addFileToPackageButton;
        private System.Windows.Forms.ListView packageFileListView;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button addNewFile;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

