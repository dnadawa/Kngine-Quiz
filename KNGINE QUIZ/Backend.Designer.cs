namespace KNGINE_QUIZ
{
    partial class Backend
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblqno = new System.Windows.Forms.Label();
            this.lbltota = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblbans2 = new System.Windows.Forms.Label();
            this.lblaans2 = new System.Windows.Forms.Label();
            this.lblbans = new System.Windows.Forms.Label();
            this.lblaans = new System.Windows.Forms.Label();
            this.lbltotb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblqno2 = new System.Windows.Forms.Label();
            this.lbltota2 = new System.Windows.Forms.Label();
            this.lbltotb2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(57, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answers";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(2, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(688, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblqno
            // 
            this.lblqno.AutoSize = true;
            this.lblqno.BackColor = System.Drawing.Color.Transparent;
            this.lblqno.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqno.ForeColor = System.Drawing.Color.White;
            this.lblqno.Location = new System.Drawing.Point(817, 348);
            this.lblqno.Name = "lblqno";
            this.lblqno.Size = new System.Drawing.Size(173, 35);
            this.lblqno.TabIndex = 1;
            this.lblqno.Text = "Question No :";
            // 
            // lbltota
            // 
            this.lbltota.AutoSize = true;
            this.lbltota.BackColor = System.Drawing.Color.Transparent;
            this.lbltota.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltota.ForeColor = System.Drawing.Color.White;
            this.lbltota.Location = new System.Drawing.Point(817, 404);
            this.lbltota.Name = "lbltota";
            this.lbltota.Size = new System.Drawing.Size(167, 35);
            this.lbltota.TabIndex = 2;
            this.lbltota.Text = "Total TeamA:";
            this.lbltota.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblbans2);
            this.groupBox2.Controls.Add(this.lblaans2);
            this.groupBox2.Controls.Add(this.lblbans);
            this.groupBox2.Controls.Add(this.lblaans);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(787, 513);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answers";
            // 
            // lblbans2
            // 
            this.lblbans2.AutoSize = true;
            this.lblbans2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbans2.Location = new System.Drawing.Point(130, 80);
            this.lblbans2.Name = "lblbans2";
            this.lblbans2.Size = new System.Drawing.Size(100, 35);
            this.lblbans2.TabIndex = 10;
            this.lblbans2.Text = "answer";
            // 
            // lblaans2
            // 
            this.lblaans2.AutoSize = true;
            this.lblaans2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaans2.Location = new System.Drawing.Point(135, 32);
            this.lblaans2.Name = "lblaans2";
            this.lblaans2.Size = new System.Drawing.Size(100, 35);
            this.lblaans2.TabIndex = 9;
            this.lblaans2.Text = "answer";
            // 
            // lblbans
            // 
            this.lblbans.AutoSize = true;
            this.lblbans.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbans.Location = new System.Drawing.Point(8, 80);
            this.lblbans.Name = "lblbans";
            this.lblbans.Size = new System.Drawing.Size(108, 35);
            this.lblbans.TabIndex = 5;
            this.lblbans.Text = "Team B:";
            // 
            // lblaans
            // 
            this.lblaans.AutoSize = true;
            this.lblaans.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaans.Location = new System.Drawing.Point(8, 32);
            this.lblaans.Name = "lblaans";
            this.lblaans.Size = new System.Drawing.Size(109, 35);
            this.lblaans.TabIndex = 4;
            this.lblaans.Text = "Team A:";
            this.lblaans.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbltotb
            // 
            this.lbltotb.AutoSize = true;
            this.lbltotb.BackColor = System.Drawing.Color.Transparent;
            this.lbltotb.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotb.ForeColor = System.Drawing.Color.White;
            this.lbltotb.Location = new System.Drawing.Point(817, 460);
            this.lbltotb.Name = "lbltotb";
            this.lbltotb.Size = new System.Drawing.Size(166, 35);
            this.lbltotb.TabIndex = 4;
            this.lbltotb.Text = "Total TeamB:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(57, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblqno2
            // 
            this.lblqno2.AutoSize = true;
            this.lblqno2.BackColor = System.Drawing.Color.Transparent;
            this.lblqno2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqno2.ForeColor = System.Drawing.Color.White;
            this.lblqno2.Location = new System.Drawing.Point(1043, 348);
            this.lblqno2.Name = "lblqno2";
            this.lblqno2.Size = new System.Drawing.Size(29, 35);
            this.lblqno2.TabIndex = 6;
            this.lblqno2.Text = "0";
            // 
            // lbltota2
            // 
            this.lbltota2.AutoSize = true;
            this.lbltota2.BackColor = System.Drawing.Color.Transparent;
            this.lbltota2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltota2.ForeColor = System.Drawing.Color.White;
            this.lbltota2.Location = new System.Drawing.Point(1043, 404);
            this.lbltota2.Name = "lbltota2";
            this.lbltota2.Size = new System.Drawing.Size(29, 35);
            this.lbltota2.TabIndex = 7;
            this.lbltota2.Text = "0";
            // 
            // lbltotb2
            // 
            this.lbltotb2.AutoSize = true;
            this.lbltotb2.BackColor = System.Drawing.Color.Transparent;
            this.lbltotb2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotb2.ForeColor = System.Drawing.Color.White;
            this.lbltotb2.Location = new System.Drawing.Point(1043, 460);
            this.lbltotb2.Name = "lbltotb2";
            this.lbltotb2.Size = new System.Drawing.Size(29, 35);
            this.lbltotb2.TabIndex = 8;
            this.lbltotb2.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(211, 619);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Send Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnclear.Location = new System.Drawing.Point(425, 619);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(176, 45);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Backend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::KNGINE_QUIZ.Properties.Resources.bg21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 741);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbltotb2);
            this.Controls.Add(this.lbltota2);
            this.Controls.Add(this.lblqno2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltotb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbltota);
            this.Controls.Add(this.lblqno);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Backend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backend";
            this.Load += new System.EventHandler(this.Backend_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblqno;
        private System.Windows.Forms.Label lbltota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblbans;
        private System.Windows.Forms.Label lblaans;
        private System.Windows.Forms.Label lbltotb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblbans2;
        private System.Windows.Forms.Label lblaans2;
        private System.Windows.Forms.Label lblqno2;
        private System.Windows.Forms.Label lbltota2;
        private System.Windows.Forms.Label lbltotb2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnclear;
    }
}