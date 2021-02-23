
namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.slide1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.htmllabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slide1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "women.PNG");
            this.imageList1.Images.SetKeyName(1, "mobile.PNG");
            // 
            // slide1
            // 
            this.slide1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slide1.BackgroundImage")));
            this.slide1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slide1.Location = new System.Drawing.Point(485, 60);
            this.slide1.Name = "slide1";
            this.slide1.Size = new System.Drawing.Size(255, 255);
            this.slide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slide1.TabIndex = 11;
            this.slide1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // textBox1
            // 
            this.textBox1.Animated = true;
            this.textBox1.BorderColor = System.Drawing.Color.Lime;
            this.textBox1.BorderRadius = 8;
            this.textBox1.BorderThickness = 2;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.Parent = this.textBox1;
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.FocusedState.Parent = this.textBox1;
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.HoverState.Parent = this.textBox1;
            this.textBox1.Location = new System.Drawing.Point(183, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PlaceholderText = "Enter Name";
            this.textBox1.SelectedText = "";
            this.textBox1.ShadowDecoration.Parent = this.textBox1;
            this.textBox1.Size = new System.Drawing.Size(214, 44);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Animated = true;
            this.textBox3.BorderColor = System.Drawing.Color.Lime;
            this.textBox3.BorderRadius = 8;
            this.textBox3.BorderThickness = 2;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.DefaultText = "";
            this.textBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox3.DisabledState.Parent = this.textBox3;
            this.textBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox3.FocusedState.Parent = this.textBox3;
            this.textBox3.ForeColor = System.Drawing.Color.Blue;
            this.textBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox3.HoverState.Parent = this.textBox3;
            this.textBox3.Location = new System.Drawing.Point(183, 164);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.PlaceholderText = "Enter password";
            this.textBox3.SelectedText = "";
            this.textBox3.ShadowDecoration.Parent = this.textBox3;
            this.textBox3.Size = new System.Drawing.Size(214, 44);
            this.textBox3.TabIndex = 8;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 15;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Lime;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(266, 328);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.PressedColor = System.Drawing.Color.Gray;
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(110, 35);
            this.guna2GradientButton2.TabIndex = 9;
            this.guna2GradientButton2.Text = "Sign in";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 15;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Lime;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Location = new System.Drawing.Point(141, 328);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.PressedColor = System.Drawing.Color.Gray;
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(110, 35);
            this.guna2GradientButton3.TabIndex = 10;
            this.guna2GradientButton3.Text = "Log in";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.Location = new System.Drawing.Point(41, 79);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(111, 45);
            this.guna2GradientButton1.TabIndex = 12;
            this.guna2GradientButton1.Text = "User";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.UseTransparentBackground = true;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BorderRadius = 5;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton4.Image")));
            this.guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.Location = new System.Drawing.Point(41, 163);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(125, 45);
            this.guna2GradientButton4.TabIndex = 13;
            this.guna2GradientButton4.Text = "Password";
            this.guna2GradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // htmllabel1
            // 
            this.htmllabel1.BackColor = System.Drawing.Color.Transparent;
            this.htmllabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmllabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.htmllabel1.Location = new System.Drawing.Point(52, 12);
            this.htmllabel1.Name = "htmllabel1";
            this.htmllabel1.Size = new System.Drawing.Size(363, 30);
            this.htmllabel1.TabIndex = 14;
            this.htmllabel1.Text = "IN SEARCH OF EXCELLENCE";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(823, 529);
            this.Controls.Add(this.htmllabel1);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.slide1);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.slide1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Userlog;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox slide1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBox3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2HtmlLabel htmllabel1;
        private System.Windows.Forms.Timer timer2;
    }
}

