
namespace WindowsFormsApp1
{
    partial class Interface
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
            this.Home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Black;
            this.Home.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(666, 393);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(122, 45);
            this.Home.TabIndex = 0;
            this.Home.Text = "Log out";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(584, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 96);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(603, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 96);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teacher";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(226, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 104);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(363, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 104);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Payment";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(452, 251);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 104);
            this.panel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Dashboard";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 20;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Blue;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(24, 24);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 6;
            this.guna2GradientButton1.Text = "Student";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click_1);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 20;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Blue;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(24, 81);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton2.TabIndex = 7;
            this.guna2GradientButton2.Text = "Teacher";
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 20;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Blue;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Location = new System.Drawing.Point(24, 141);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton3.TabIndex = 8;
            this.guna2GradientButton3.Text = "Department";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BorderRadius = 20;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Blue;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Location = new System.Drawing.Point(24, 198);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton4.TabIndex = 9;
            this.guna2GradientButton4.Text = "Payment";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Home);
            this.Name = "Interface";
            this.Text = "Interface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
    }
}