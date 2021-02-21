
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DepNameT = new System.Windows.Forms.TextBox();
            this.DepDesc = new System.Windows.Forms.TextBox();
            this.DepDuration = new System.Windows.Forms.TextBox();
            this.DepDataGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 28;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 26);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(116, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 26);
            this.button4.TabIndex = 30;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.DepDataGV.Location = new System.Drawing.Point(320, 99);
            this.DepDataGV.Name = "DepDataGV";
            this.DepDataGV.RowHeadersWidth = 51;
            this.DepDataGV.RowTemplate.Height = 24;
            this.DepDataGV.Size = new System.Drawing.Size(771, 483);
            this.DepDataGV.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(605, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Department List";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DepDataGV);
            this.Controls.Add(this.DepDuration);
            this.Controls.Add(this.DepDesc);
            this.Controls.Add(this.DepNameT);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox DepNameT;
        private System.Windows.Forms.TextBox DepDesc;
        private System.Windows.Forms.TextBox DepDuration;
        private System.Windows.Forms.DataGridView DepDataGV;
        private System.Windows.Forms.Label label4;
    }
}