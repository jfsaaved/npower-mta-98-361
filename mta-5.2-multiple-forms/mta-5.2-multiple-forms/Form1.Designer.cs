namespace mta_5._2_multiple_forms {
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
            this.btnFormTwo = new System.Windows.Forms.Button();
            this.txtChangeCase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFormTwo
            // 
            this.btnFormTwo.Location = new System.Drawing.Point(174, 148);
            this.btnFormTwo.Name = "btnFormTwo";
            this.btnFormTwo.Size = new System.Drawing.Size(75, 23);
            this.btnFormTwo.TabIndex = 0;
            this.btnFormTwo.Text = "button1";
            this.btnFormTwo.UseVisualStyleBackColor = true;
            this.btnFormTwo.Click += new System.EventHandler(this.BtnFormTwo_Click);
            // 
            // txtChangeCase
            // 
            this.txtChangeCase.Location = new System.Drawing.Point(174, 104);
            this.txtChangeCase.Name = "txtChangeCase";
            this.txtChangeCase.Size = new System.Drawing.Size(100, 20);
            this.txtChangeCase.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtChangeCase);
            this.Controls.Add(this.btnFormTwo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormTwo;
        private System.Windows.Forms.TextBox txtChangeCase;
    }
}

