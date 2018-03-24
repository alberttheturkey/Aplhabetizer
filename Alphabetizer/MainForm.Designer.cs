namespace Alphabetizer
{
    partial class Alphabetizer
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
            this.btnOrganize = new System.Windows.Forms.Button();
            this.btnFolderSelect = new System.Windows.Forms.Button();
            this.tbStartFolder = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrganize
            // 
            this.btnOrganize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrganize.Location = new System.Drawing.Point(644, 107);
            this.btnOrganize.Name = "btnOrganize";
            this.btnOrganize.Size = new System.Drawing.Size(141, 41);
            this.btnOrganize.TabIndex = 0;
            this.btnOrganize.Text = "Organize!!!";
            this.btnOrganize.UseVisualStyleBackColor = true;
            this.btnOrganize.Click += new System.EventHandler(this.btnOrganize_Click);
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderSelect.Location = new System.Drawing.Point(596, 106);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(42, 41);
            this.btnFolderSelect.TabIndex = 1;
            this.btnFolderSelect.Text = "...";
            this.btnFolderSelect.UseVisualStyleBackColor = true;
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // tbStartFolder
            // 
            this.tbStartFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStartFolder.Location = new System.Drawing.Point(12, 113);
            this.tbStartFolder.Name = "tbStartFolder";
            this.tbStartFolder.Size = new System.Drawing.Size(578, 26);
            this.tbStartFolder.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Alphabetizer!";
            // 
            // lblExplanation
            // 
            this.lblExplanation.Location = new System.Drawing.Point(15, 64);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(716, 39);
            this.lblExplanation.TabIndex = 4;
            this.lblExplanation.Text = "Select a folder and I\'ll sort all it\'s files into alphabetical folders including " +
    "number and symbol folders!";
            // 
            // Alphabetizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 160);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbStartFolder);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.btnOrganize);
            this.Name = "Alphabetizer";
            this.Text = "Alphabetizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrganize;
        private System.Windows.Forms.Button btnFolderSelect;
        private System.Windows.Forms.TextBox tbStartFolder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblExplanation;
    }
}

