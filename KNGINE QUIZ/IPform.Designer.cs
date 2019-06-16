namespace KNGINE_QUIZ
{
    partial class IPform
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtip = new System.Windows.Forms.TextBox();
            this.btncon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Server IP";
            // 
            // txtip
            // 
            this.txtip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtip.Location = new System.Drawing.Point(12, 82);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(526, 45);
            this.txtip.TabIndex = 1;
            this.txtip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btncon
            // 
            this.btncon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncon.Location = new System.Drawing.Point(12, 153);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(526, 58);
            this.btncon.TabIndex = 2;
            this.btncon.Text = "CONNECT";
            this.btncon.UseVisualStyleBackColor = true;
            this.btncon.Click += new System.EventHandler(this.btncon_Click);
            // 
            // IPform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 223);
            this.Controls.Add(this.btncon);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IPform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncon;
        public System.Windows.Forms.TextBox txtip;
    }
}