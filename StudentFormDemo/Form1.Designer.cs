
namespace StudentFormDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbStudentID = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProgramming = new System.Windows.Forms.RadioButton();
            this.rbWebDesign = new System.Windows.Forms.RadioButton();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.cbxCIS101 = new System.Windows.Forms.CheckBox();
            this.cbxCIS102 = new System.Windows.Forms.CheckBox();
            this.cbxCIS103 = new System.Windows.Forms.CheckBox();
            this.cbxCIS104 = new System.Windows.Forms.CheckBox();
            this.txbScore1 = new System.Windows.Forms.TextBox();
            this.txbScore2 = new System.Windows.Forms.TextBox();
            this.txbScore3 = new System.Windows.Forms.TextBox();
            this.txbScore4 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbStudentID
            // 
            this.txbStudentID.Location = new System.Drawing.Point(257, 63);
            this.txbStudentID.Name = "txbStudentID";
            this.txbStudentID.Size = new System.Drawing.Size(100, 20);
            this.txbStudentID.TabIndex = 3;
            this.txbStudentID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(257, 89);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 4;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(170, 66);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(171, 92);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(170, 118);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(257, 115);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(100, 20);
            this.txbLastName.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIT);
            this.groupBox1.Controls.Add(this.rbWebDesign);
            this.groupBox1.Controls.Add(this.rbProgramming);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(173, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Major";
            // 
            // rbProgramming
            // 
            this.rbProgramming.AutoSize = true;
            this.rbProgramming.Location = new System.Drawing.Point(6, 19);
            this.rbProgramming.Name = "rbProgramming";
            this.rbProgramming.Size = new System.Drawing.Size(86, 17);
            this.rbProgramming.TabIndex = 0;
            this.rbProgramming.TabStop = true;
            this.rbProgramming.Text = "Programming";
            this.rbProgramming.UseVisualStyleBackColor = true;
            // 
            // rbWebDesign
            // 
            this.rbWebDesign.AutoSize = true;
            this.rbWebDesign.Location = new System.Drawing.Point(6, 42);
            this.rbWebDesign.Name = "rbWebDesign";
            this.rbWebDesign.Size = new System.Drawing.Size(84, 17);
            this.rbWebDesign.TabIndex = 1;
            this.rbWebDesign.TabStop = true;
            this.rbWebDesign.Text = "Web Design";
            this.rbWebDesign.UseVisualStyleBackColor = true;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(6, 65);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(35, 17);
            this.rbIT.TabIndex = 2;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(173, 286);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(45, 13);
            this.lblCourses.TabIndex = 10;
            this.lblCourses.Text = "Courses";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(174, 315);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(40, 13);
            this.lblScores.TabIndex = 11;
            this.lblScores.Text = "Scores";
            // 
            // cbxCIS101
            // 
            this.cbxCIS101.AutoSize = true;
            this.cbxCIS101.Location = new System.Drawing.Point(257, 282);
            this.cbxCIS101.Name = "cbxCIS101";
            this.cbxCIS101.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS101.TabIndex = 12;
            this.cbxCIS101.Text = "CIS 101";
            this.cbxCIS101.UseVisualStyleBackColor = true;
            // 
            // cbxCIS102
            // 
            this.cbxCIS102.AutoSize = true;
            this.cbxCIS102.Location = new System.Drawing.Point(361, 282);
            this.cbxCIS102.Name = "cbxCIS102";
            this.cbxCIS102.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS102.TabIndex = 13;
            this.cbxCIS102.Text = "CIS 102";
            this.cbxCIS102.UseVisualStyleBackColor = true;
            // 
            // cbxCIS103
            // 
            this.cbxCIS103.AutoSize = true;
            this.cbxCIS103.Location = new System.Drawing.Point(462, 282);
            this.cbxCIS103.Name = "cbxCIS103";
            this.cbxCIS103.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS103.TabIndex = 14;
            this.cbxCIS103.Text = "CIS 103";
            this.cbxCIS103.UseVisualStyleBackColor = true;
            // 
            // cbxCIS104
            // 
            this.cbxCIS104.AutoSize = true;
            this.cbxCIS104.Location = new System.Drawing.Point(568, 282);
            this.cbxCIS104.Name = "cbxCIS104";
            this.cbxCIS104.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS104.TabIndex = 15;
            this.cbxCIS104.Text = "CIS 104";
            this.cbxCIS104.UseVisualStyleBackColor = true;
            // 
            // txbScore1
            // 
            this.txbScore1.Location = new System.Drawing.Point(235, 315);
            this.txbScore1.Name = "txbScore1";
            this.txbScore1.Size = new System.Drawing.Size(100, 20);
            this.txbScore1.TabIndex = 16;
            // 
            // txbScore2
            // 
            this.txbScore2.Location = new System.Drawing.Point(341, 315);
            this.txbScore2.Name = "txbScore2";
            this.txbScore2.Size = new System.Drawing.Size(100, 20);
            this.txbScore2.TabIndex = 17;
            // 
            // txbScore3
            // 
            this.txbScore3.Location = new System.Drawing.Point(447, 315);
            this.txbScore3.Name = "txbScore3";
            this.txbScore3.Size = new System.Drawing.Size(100, 20);
            this.txbScore3.TabIndex = 18;
            // 
            // txbScore4
            // 
            this.txbScore4.Location = new System.Drawing.Point(553, 315);
            this.txbScore4.Name = "txbScore4";
            this.txbScore4.Size = new System.Drawing.Size(100, 20);
            this.txbScore4.TabIndex = 19;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Firebrick;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(341, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 33);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel1.Location = new System.Drawing.Point(565, 206);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cengage Home Page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(553, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbScore4);
            this.Controls.Add(this.txbScore3);
            this.Controls.Add(this.txbScore2);
            this.Controls.Add(this.txbScore1);
            this.Controls.Add(this.cbxCIS104);
            this.Controls.Add(this.cbxCIS103);
            this.Controls.Add(this.cbxCIS102);
            this.Controls.Add(this.cbxCIS101);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.txbStudentID);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbStudentID;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbWebDesign;
        private System.Windows.Forms.RadioButton rbProgramming;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.CheckBox cbxCIS101;
        private System.Windows.Forms.CheckBox cbxCIS102;
        private System.Windows.Forms.CheckBox cbxCIS103;
        private System.Windows.Forms.CheckBox cbxCIS104;
        private System.Windows.Forms.TextBox txbScore1;
        private System.Windows.Forms.TextBox txbScore2;
        private System.Windows.Forms.TextBox txbScore3;
        private System.Windows.Forms.TextBox txbScore4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

