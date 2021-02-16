
namespace WindowsFormsApp1
{
    partial class Student
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.stdid = new System.Windows.Forms.TextBox();
            this.stdName = new System.Windows.Forms.TextBox();
            this.stdFees = new System.Windows.Forms.TextBox();
            this.stdDep = new System.Windows.Forms.TextBox();
            this.stdPhone = new System.Windows.Forms.TextBox();
            this.stdDateTime = new System.Windows.Forms.DateTimePicker();
            this.StdDataGV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.DepCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StdDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dob";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deptmt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fees";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 26);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 26);
            this.button4.TabIndex = 10;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GenderCb
            // 
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(125, 103);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(134, 24);
            this.GenderCb.TabIndex = 11;
            this.GenderCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // stdid
            // 
            this.stdid.Location = new System.Drawing.Point(125, 41);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(134, 22);
            this.stdid.TabIndex = 12;
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(125, 70);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(134, 22);
            this.stdName.TabIndex = 13;
            // 
            // stdFees
            // 
            this.stdFees.Location = new System.Drawing.Point(125, 256);
            this.stdFees.Name = "stdFees";
            this.stdFees.Size = new System.Drawing.Size(134, 22);
            this.stdFees.TabIndex = 14;
            // 
            // stdDep
            // 
            this.stdDep.Location = new System.Drawing.Point(395, 244);
            this.stdDep.Name = "stdDep";
            this.stdDep.Size = new System.Drawing.Size(134, 22);
            this.stdDep.TabIndex = 15;
            // 
            // stdPhone
            // 
            this.stdPhone.Location = new System.Drawing.Point(125, 200);
            this.stdPhone.Name = "stdPhone";
            this.stdPhone.Size = new System.Drawing.Size(134, 22);
            this.stdPhone.TabIndex = 16;
            // 
            // stdDateTime
            // 
            this.stdDateTime.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.stdDateTime.Location = new System.Drawing.Point(35, 163);
            this.stdDateTime.Name = "stdDateTime";
            this.stdDateTime.Size = new System.Drawing.Size(224, 22);
            this.stdDateTime.TabIndex = 18;
            // 
            // StdDataGV
            // 
            this.StdDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StdDataGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StdDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdDataGV.Location = new System.Drawing.Point(265, 88);
            this.StdDataGV.Name = "StdDataGV";
            this.StdDataGV.RowHeadersWidth = 51;
            this.StdDataGV.RowTemplate.Height = 24;
            this.StdDataGV.Size = new System.Drawing.Size(786, 468);
            this.StdDataGV.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(607, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Student List";
            // 
            // DepCb
            // 
            this.DepCb.FormattingEnabled = true;
            this.DepCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DepCb.Location = new System.Drawing.Point(125, 226);
            this.DepCb.Name = "DepCb";
            this.DepCb.Size = new System.Drawing.Size(134, 24);
            this.DepCb.TabIndex = 21;
            this.DepCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 568);
            this.Controls.Add(this.DepCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StdDataGV);
            this.Controls.Add(this.stdDateTime);
            this.Controls.Add(this.stdPhone);
            this.Controls.Add(this.stdDep);
            this.Controls.Add(this.stdFees);
            this.Controls.Add(this.stdName);
            this.Controls.Add(this.stdid);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StdDataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.TextBox stdid;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.TextBox stdFees;
        private System.Windows.Forms.TextBox stdDep;
        private System.Windows.Forms.TextBox stdPhone;
        private System.Windows.Forms.DateTimePicker stdDateTime;
        private System.Windows.Forms.DataGridView StdDataGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DepCb;
    }
}