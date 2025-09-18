namespace AssessmentPortal
{
    partial class QuetionBankManagement
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
            this.lnkclose = new System.Windows.Forms.LinkLabel();
            this.cmbsubject = new System.Windows.Forms.ComboBox();
            this.lblsubject = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.rbc = new System.Windows.Forms.RadioButton();
            this.rbb = new System.Windows.Forms.RadioButton();
            this.rbd = new System.Windows.Forms.RadioButton();
            this.rba = new System.Windows.Forms.RadioButton();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtquetion = new System.Windows.Forms.RichTextBox();
            this.lblanswer = new System.Windows.Forms.Label();
            this.lbloptionD = new System.Windows.Forms.Label();
            this.lbloptionC = new System.Windows.Forms.Label();
            this.lbloptionB = new System.Windows.Forms.Label();
            this.lbloptionA = new System.Windows.Forms.Label();
            this.lblquetion = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lnkclose);
            this.groupBox1.Controls.Add(this.cmbsubject);
            this.groupBox1.Controls.Add(this.lblsubject);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lblwelcome);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1650, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lnkclose
            // 
            this.lnkclose.AutoSize = true;
            this.lnkclose.Location = new System.Drawing.Point(970, 38);
            this.lnkclose.Name = "lnkclose";
            this.lnkclose.Size = new System.Drawing.Size(48, 16);
            this.lnkclose.TabIndex = 4;
            this.lnkclose.TabStop = true;
            this.lnkclose.Text = "Logout";
            this.lnkclose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkclose_LinkClicked);
            // 
            // cmbsubject
            // 
            this.cmbsubject.FormattingEnabled = true;
            this.cmbsubject.Location = new System.Drawing.Point(584, 39);
            this.cmbsubject.Name = "cmbsubject";
            this.cmbsubject.Size = new System.Drawing.Size(240, 24);
            this.cmbsubject.TabIndex = 3;
            this.cmbsubject.SelectedIndexChanged += new System.EventHandler(this.cmbsubject_SelectedIndexChanged);
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Location = new System.Drawing.Point(493, 47);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(52, 16);
            this.lblsubject.TabIndex = 2;
            this.lblsubject.Text = "Subject";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(140, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 25);
            this.lblUser.TabIndex = 1;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(20, 38);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(107, 25);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "WelCome";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.rbc);
            this.groupBox2.Controls.Add(this.rbb);
            this.groupBox2.Controls.Add(this.rbd);
            this.groupBox2.Controls.Add(this.rba);
            this.groupBox2.Controls.Add(this.txtd);
            this.groupBox2.Controls.Add(this.txtc);
            this.groupBox2.Controls.Add(this.txtb);
            this.groupBox2.Controls.Add(this.txta);
            this.groupBox2.Controls.Add(this.txtquetion);
            this.groupBox2.Controls.Add(this.lblanswer);
            this.groupBox2.Controls.Add(this.lbloptionD);
            this.groupBox2.Controls.Add(this.lbloptionC);
            this.groupBox2.Controls.Add(this.lbloptionB);
            this.groupBox2.Controls.Add(this.lbloptionA);
            this.groupBox2.Controls.Add(this.lblquetion);
            this.groupBox2.Location = new System.Drawing.Point(21, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 472);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(289, 402);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(131, 32);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // rbc
            // 
            this.rbc.AutoSize = true;
            this.rbc.Location = new System.Drawing.Point(267, 326);
            this.rbc.Name = "rbc";
            this.rbc.Size = new System.Drawing.Size(37, 20);
            this.rbc.TabIndex = 18;
            this.rbc.TabStop = true;
            this.rbc.Text = "C";
            this.rbc.UseVisualStyleBackColor = true;
            // 
            // rbb
            // 
            this.rbb.AutoSize = true;
            this.rbb.Location = new System.Drawing.Point(202, 326);
            this.rbb.Name = "rbb";
            this.rbb.Size = new System.Drawing.Size(37, 20);
            this.rbb.TabIndex = 17;
            this.rbb.TabStop = true;
            this.rbb.Text = "B";
            this.rbb.UseVisualStyleBackColor = true;
            // 
            // rbd
            // 
            this.rbd.AutoSize = true;
            this.rbd.Location = new System.Drawing.Point(321, 326);
            this.rbd.Name = "rbd";
            this.rbd.Size = new System.Drawing.Size(38, 20);
            this.rbd.TabIndex = 16;
            this.rbd.TabStop = true;
            this.rbd.Text = "D";
            this.rbd.UseVisualStyleBackColor = true;
            // 
            // rba
            // 
            this.rba.AutoSize = true;
            this.rba.Location = new System.Drawing.Point(136, 326);
            this.rba.Name = "rba";
            this.rba.Size = new System.Drawing.Size(37, 20);
            this.rba.TabIndex = 15;
            this.rba.TabStop = true;
            this.rba.Text = "A";
            this.rba.UseVisualStyleBackColor = true;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(136, 261);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(284, 22);
            this.txtd.TabIndex = 14;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(136, 221);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(284, 22);
            this.txtc.TabIndex = 13;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(136, 177);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(284, 22);
            this.txtb.TabIndex = 12;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(136, 135);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(284, 22);
            this.txta.TabIndex = 11;
            // 
            // txtquetion
            // 
            this.txtquetion.Location = new System.Drawing.Point(136, 48);
            this.txtquetion.Name = "txtquetion";
            this.txtquetion.Size = new System.Drawing.Size(284, 65);
            this.txtquetion.TabIndex = 10;
            this.txtquetion.Text = "";
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Location = new System.Drawing.Point(59, 326);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(51, 16);
            this.lblanswer.TabIndex = 9;
            this.lblanswer.Text = "Answer";
            // 
            // lbloptionD
            // 
            this.lbloptionD.AutoSize = true;
            this.lbloptionD.Location = new System.Drawing.Point(59, 264);
            this.lbloptionD.Name = "lbloptionD";
            this.lbloptionD.Size = new System.Drawing.Size(59, 16);
            this.lbloptionD.TabIndex = 8;
            this.lbloptionD.Text = "Option D";
            // 
            // lbloptionC
            // 
            this.lbloptionC.AutoSize = true;
            this.lbloptionC.Location = new System.Drawing.Point(59, 224);
            this.lbloptionC.Name = "lbloptionC";
            this.lbloptionC.Size = new System.Drawing.Size(58, 16);
            this.lbloptionC.TabIndex = 7;
            this.lbloptionC.Text = "Option C";
            // 
            // lbloptionB
            // 
            this.lbloptionB.AutoSize = true;
            this.lbloptionB.Location = new System.Drawing.Point(59, 180);
            this.lbloptionB.Name = "lbloptionB";
            this.lbloptionB.Size = new System.Drawing.Size(58, 16);
            this.lbloptionB.TabIndex = 6;
            this.lbloptionB.Text = "Option B";
            // 
            // lbloptionA
            // 
            this.lbloptionA.AutoSize = true;
            this.lbloptionA.Location = new System.Drawing.Point(59, 135);
            this.lbloptionA.Name = "lbloptionA";
            this.lbloptionA.Size = new System.Drawing.Size(58, 16);
            this.lbloptionA.TabIndex = 5;
            this.lbloptionA.Text = "Option A";
            // 
            // lblquetion
            // 
            this.lblquetion.AutoSize = true;
            this.lblquetion.Location = new System.Drawing.Point(59, 51);
            this.lblquetion.Name = "lblquetion";
            this.lblquetion.Size = new System.Drawing.Size(60, 16);
            this.lblquetion.TabIndex = 3;
            this.lblquetion.Text = "Question";
            this.lblquetion.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.lblmsg2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Controls.Add(this.txtsearch);
            this.groupBox3.Controls.Add(this.lblsearch);
            this.groupBox3.Location = new System.Drawing.Point(508, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1154, 472);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.Location = new System.Drawing.Point(78, 66);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(0, 16);
            this.lblmsg2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 348);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(447, 32);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(110, 32);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(331, 22);
            this.txtsearch.TabIndex = 2;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(39, 35);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(50, 16);
            this.lblsearch.TabIndex = 0;
            this.lblsearch.Text = "Search";
            // 
            // QuetionBankManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1674, 691);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuetionBankManagement";
            this.Text = "QuetionBankManagement";
            this.Load += new System.EventHandler(this.QuetionBankManagement_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblquetion;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.LinkLabel lnkclose;
        private System.Windows.Forms.ComboBox cmbsubject;
        private System.Windows.Forms.RadioButton rbc;
        private System.Windows.Forms.RadioButton rbb;
        private System.Windows.Forms.RadioButton rbd;
        private System.Windows.Forms.RadioButton rba;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.RichTextBox txtquetion;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.Label lbloptionD;
        private System.Windows.Forms.Label lbloptionC;
        private System.Windows.Forms.Label lbloptionB;
        private System.Windows.Forms.Label lbloptionA;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblmsg2;
    }
}