namespace NodeB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxTestingB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxDecrypted = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelReceived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxTestingB
            // 
            this.textboxTestingB.Location = new System.Drawing.Point(27, 376);
            this.textboxTestingB.Name = "textboxTestingB";
            this.textboxTestingB.Size = new System.Drawing.Size(443, 124);
            this.textboxTestingB.TabIndex = 2;
            this.textboxTestingB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Testing Console";
            // 
            // textboxDecrypted
            // 
            this.textboxDecrypted.Location = new System.Drawing.Point(27, 111);
            this.textboxDecrypted.Name = "textboxDecrypted";
            this.textboxDecrypted.Size = new System.Drawing.Size(443, 212);
            this.textboxDecrypted.TabIndex = 1;
            this.textboxDecrypted.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Decrypted contents of the file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bytes received:";
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReceived.Location = new System.Drawing.Point(219, 21);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(166, 30);
            this.labelReceived.TabIndex = 0;
            this.labelReceived.Text = "No file received";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 521);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxDecrypted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxTestingB);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Node B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textboxTestingB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textboxDecrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelReceived;
    }
}