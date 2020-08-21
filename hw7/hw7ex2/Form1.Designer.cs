namespace hw7ex2
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnTry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(29, 22);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(177, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Try to guess a number from 0 to 100";
            // 
            // btnTry
            // 
            this.btnTry.Location = new System.Drawing.Point(12, 49);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(75, 23);
            this.btnTry.TabIndex = 1;
            this.btnTry.Text = "Try";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tries:";
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Location = new System.Drawing.Point(143, 54);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(13, 13);
            this.lblTries.TabIndex = 4;
            this.lblTries.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 95);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.lblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTries;
    }
}

