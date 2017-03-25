namespace Talltekst
{
    partial class Main
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
            this.OutPutBox = new System.Windows.Forms.RichTextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutPutBox
            // 
            this.OutPutBox.Location = new System.Drawing.Point(216, 178);
            this.OutPutBox.Name = "OutPutBox";
            this.OutPutBox.Size = new System.Drawing.Size(241, 161);
            this.OutPutBox.TabIndex = 0;
            this.OutPutBox.Text = "";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(216, 51);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 20);
            this.InputBox.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(225, 99);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "button1";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 459);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.OutPutBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutPutBox;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button Submit;
    }
}

