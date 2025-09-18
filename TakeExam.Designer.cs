namespace AssessmentPortal
{
    partial class TakeExam
    {
       
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.cmbselectsubject = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.rbB = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMarkReview = new System.Windows.Forms.Button();
            this.btnSaveNext = new System.Windows.Forms.Button();
            this.lblquestion = new System.Windows.Forms.Label();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.rbB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Controls.Add(this.btnstart);
            this.groupBox1.Controls.Add(this.cmbselectsubject);
            this.groupBox1.Controls.Add(this.lblSelect);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Red;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(763, 54);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(117, 25);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "20 minutes";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Green;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(455, 35);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(133, 57);
            this.btnstart.TabIndex = 4;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // cmbselectsubject
            // 
            this.cmbselectsubject.FormattingEnabled = true;
            this.cmbselectsubject.Location = new System.Drawing.Point(156, 68);
            this.cmbselectsubject.Name = "cmbselectsubject";
            this.cmbselectsubject.Size = new System.Drawing.Size(233, 24);
            this.cmbselectsubject.TabIndex = 3;
            this.cmbselectsubject.SelectedIndexChanged += new System.EventHandler(this.cmbselectsubject_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(50, 71);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(93, 16);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Select Subject";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(143, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 25);
            this.lblUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WelCome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.rbB);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1112, 509);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn14);
            this.groupBox4.Controls.Add(this.btn20);
            this.groupBox4.Controls.Add(this.btn13);
            this.groupBox4.Controls.Add(this.btn19);
            this.groupBox4.Controls.Add(this.btn12);
            this.groupBox4.Controls.Add(this.btn18);
            this.groupBox4.Controls.Add(this.btn9);
            this.groupBox4.Controls.Add(this.btn17);
            this.groupBox4.Controls.Add(this.btn16);
            this.groupBox4.Controls.Add(this.btn15);
            this.groupBox4.Controls.Add(this.btn11);
            this.groupBox4.Controls.Add(this.btn10);
            this.groupBox4.Controls.Add(this.btn8);
            this.groupBox4.Controls.Add(this.btn7);
            this.groupBox4.Controls.Add(this.btn6);
            this.groupBox4.Controls.Add(this.btn5);
            this.groupBox4.Controls.Add(this.btn4);
            this.groupBox4.Controls.Add(this.btn3);
            this.groupBox4.Controls.Add(this.btn2);
            this.groupBox4.Controls.Add(this.btn1);
            this.groupBox4.Location = new System.Drawing.Point(647, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(441, 451);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btn14
            // 
            this.btn14.Location = new System.Drawing.Point(121, 251);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(75, 23);
            this.btn14.TabIndex = 11;
            this.btn14.Text = "14";
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(339, 321);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 23);
            this.btn20.TabIndex = 15;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(19, 251);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(75, 23);
            this.btn13.TabIndex = 10;
            this.btn13.Text = "13";
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn19
            // 
            this.btn19.Location = new System.Drawing.Point(230, 321);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(75, 23);
            this.btn19.TabIndex = 14;
            this.btn19.Text = "19";
            this.btn19.UseVisualStyleBackColor = true;
            this.btn19.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(339, 186);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 23);
            this.btn12.TabIndex = 9;
            this.btn12.Text = "12";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn18
            // 
            this.btn18.Location = new System.Drawing.Point(121, 321);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(75, 23);
            this.btn18.TabIndex = 13;
            this.btn18.Text = "18";
            this.btn18.UseVisualStyleBackColor = true;
            this.btn18.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(19, 186);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn17
            // 
            this.btn17.Location = new System.Drawing.Point(19, 321);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(75, 23);
            this.btn17.TabIndex = 12;
            this.btn17.Text = "17";
            this.btn17.UseVisualStyleBackColor = true;
            this.btn17.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn16
            // 
            this.btn16.Location = new System.Drawing.Point(339, 251);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(75, 23);
            this.btn16.TabIndex = 11;
            this.btn16.Text = "16";
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(230, 251);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(75, 23);
            this.btn15.TabIndex = 10;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(230, 186);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 23);
            this.btn11.TabIndex = 9;
            this.btn11.Text = "11";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(121, 186);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 23);
            this.btn10.TabIndex = 8;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(339, 128);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(230, 128);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(121, 128);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(19, 128);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(339, 62);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(230, 62);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(121, 62);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(19, 62);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // rbB
            // 
            this.rbB.Controls.Add(this.btnSubmit);
            this.rbB.Controls.Add(this.btnMarkReview);
            this.rbB.Controls.Add(this.btnSaveNext);
            this.rbB.Controls.Add(this.lblquestion);
            this.rbB.Controls.Add(this.rbD);
            this.rbB.Controls.Add(this.rbC);
            this.rbB.Controls.Add(this.radioButton2);
            this.rbB.Controls.Add(this.rbA);
            this.rbB.Location = new System.Drawing.Point(6, 29);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(616, 451);
            this.rbB.TabIndex = 2;
            this.rbB.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Red;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(378, 372);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 43);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit Test";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMarkReview
            // 
            this.btnMarkReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMarkReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkReview.Location = new System.Drawing.Point(196, 372);
            this.btnMarkReview.Name = "btnMarkReview";
            this.btnMarkReview.Size = new System.Drawing.Size(135, 43);
            this.btnMarkReview.TabIndex = 6;
            this.btnMarkReview.Text = "Mark for Review";
            this.btnMarkReview.UseVisualStyleBackColor = false;
            this.btnMarkReview.Click += new System.EventHandler(this.btnMarkReview_Click);
            // 
            // btnSaveNext
            // 
            this.btnSaveNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNext.Location = new System.Drawing.Point(34, 372);
            this.btnSaveNext.Name = "btnSaveNext";
            this.btnSaveNext.Size = new System.Drawing.Size(118, 43);
            this.btnSaveNext.TabIndex = 5;
            this.btnSaveNext.Text = "Save and Next";
            this.btnSaveNext.UseVisualStyleBackColor = false;
            this.btnSaveNext.Click += new System.EventHandler(this.btnSaveNext_Click);
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Location = new System.Drawing.Point(31, 65);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(0, 16);
            this.lblquestion.TabIndex = 4;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(34, 307);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(42, 20);
            this.rbD.TabIndex = 3;
            this.rbD.TabStop = true;
            this.rbD.Text = "D)";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(34, 254);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(41, 20);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "C)";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(34, 189);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(34, 131);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(41, 20);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "A)";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // TakeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1149, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TakeExam";
            this.Text = "TakeExam";
            this.Load += new System.EventHandler(this.TakeExam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.rbB.ResumeLayout(false);
            this.rbB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbselectsubject;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox rbB;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMarkReview;
        private System.Windows.Forms.Button btnSaveNext;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
    }
}