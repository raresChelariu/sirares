using System;

namespace NodeA
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxA = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseFile.Location = new System.Drawing.Point(29, 161);
            this.buttonBrowseFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(392, 129);
            this.buttonBrowseFile.TabIndex = 4;
            this.buttonBrowseFile.Text = "Select File";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFileSize.Location = new System.Drawing.Point(193, 37);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(243, 37);
            this.labelFileSize.TabIndex = 2;
            this.labelFileSize.Text = "No file selected yet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Path";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPath.Location = new System.Drawing.Point(193, 83);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(243, 37);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "No file selected yet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(29, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "File size";
            // 
            // textboxA
            // 
            this.textboxA.Location = new System.Drawing.Point(29, 377);
            this.textboxA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxA.Name = "textboxA";
            this.textboxA.Size = new System.Drawing.Size(391, 164);
            this.textboxA.TabIndex = 2;
            this.textboxA.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(29, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "Testing Console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 692);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textboxA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelFileSize);
            this.Controls.Add(this.buttonBrowseFile);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Node A";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox textboxA;
        private System.Windows.Forms.Label label9;
    }
}