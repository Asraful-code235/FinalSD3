
namespace WindowsFormsApp1
{
    partial class Department
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DepNameT = new System.Windows.Forms.TextBox();
            this.DepDesc = new System.Windows.Forms.TextBox();
            this.DepDuration = new System.Windows.Forms.TextBox();
            this.DepDataGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DepDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            // 
            // DepNameT
            // 
            this.DepNameT.Location = new System.Drawing.Point(137, 99);
            this.DepNameT.Name = "DepNameT";
            this.DepNameT.Size = new System.Drawing.Size(120, 22);
            this.DepNameT.TabIndex = 31;
            // 
            // DepDesc
            // 
            this.DepDesc.Location = new System.Drawing.Point(137, 149);
            this.DepDesc.Name = "DepDesc";
            this.DepDesc.Size = new System.Drawing.Size(120, 22);
            this.DepDesc.TabIndex = 32;
            // 
            // DepDuration
            // 
            this.DepDuration.Location = new System.Drawing.Point(137, 193);
            this.DepDuration.Name = "DepDuration";
            this.DepDuration.Size = new System.Drawing.Size(120, 22);
            this.DepDuration.TabIndex = 33;
            // 
            // DepDataGV
            // 
            this.DepDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepDataGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DepDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepDataGV.Location = new System.Drawing.Point(422, 117);
            this.DepDataGV.Name = "DepDataGV";
            this.DepDataGV.RowHeadersWidth = 51;
            this.DepDataGV.RowTemplate.Height = 24;
            this.DepDataGV.Size = new System.Drawing.Size(522, 344);
            this.DepDataGV.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(576, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Department List";
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.BorderRadius = 10;
            this.guna2GradientButton5.CheckedState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.CustomImages.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GradientButton5.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton5.HoverState.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton5.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.guna2GradientButton5.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton5.HoverState.Image")));
            this.guna2GradientButton5.HoverState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Location = new System.Drawing.Point(33, 238);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.ShadowDecoration.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton5.TabIndex = 36;
            this.guna2GradientButton5.Text = "ADD";
            this.guna2GradientButton5.Click += new System.EventHandler(this.guna2GradientButton5_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Honeydew;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.guna2GradientButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.HoverState.Image")));
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(155, 238);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton1.TabIndex = 37;
            this.guna2GradientButton1.Text = "Edit";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(276, 238);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton2.TabIndex = 38;
            this.guna2GradientButton2.Text = "Delete";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Aquamarine;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.guna2GradientButton3.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.HoverState.Image")));
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.Location = new System.Drawing.Point(842, 544);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(102, 40);
            this.guna2GradientButton3.TabIndex = 39;
            this.guna2GradientButton3.Text = "Home";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 598);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2GradientButton5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DepDataGV);
            this.Controls.Add(this.DepDuration);
            this.Controls.Add(this.DepDesc);
            this.Controls.Add(this.DepNameT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepDataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DepNameT;
        private System.Windows.Forms.TextBox DepDesc;
        private System.Windows.Forms.TextBox DepDuration;
        private System.Windows.Forms.DataGridView DepDataGV;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private System.Windows.Forms.Timer timer1;
    }
}