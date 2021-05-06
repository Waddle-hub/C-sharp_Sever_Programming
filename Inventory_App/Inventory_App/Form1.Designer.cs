namespace Inventory_App
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.back_Circle = new Guna.UI.WinForms.GunaCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.roleCMB = new System.Windows.Forms.ComboBox();
            this.submit_Login = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_Circle
            // 
            this.back_Circle.AnimationHoverSpeed = 0.07F;
            this.back_Circle.AnimationSpeed = 0.03F;
            this.back_Circle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back_Circle.BorderColor = System.Drawing.Color.Black;
            this.back_Circle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.back_Circle.FocusedColor = System.Drawing.Color.Empty;
            this.back_Circle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_Circle.ForeColor = System.Drawing.Color.White;
            this.back_Circle.Image = null;
            this.back_Circle.ImageSize = new System.Drawing.Size(52, 52);
            this.back_Circle.Location = new System.Drawing.Point(-591, -5);
            this.back_Circle.Name = "back_Circle";
            this.back_Circle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.back_Circle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.back_Circle.OnHoverForeColor = System.Drawing.Color.White;
            this.back_Circle.OnHoverImage = null;
            this.back_Circle.OnPressedColor = System.Drawing.Color.Black;
            this.back_Circle.Size = new System.Drawing.Size(1014, 544);
            this.back_Circle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage ease";
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userName.Location = new System.Drawing.Point(531, 382);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(221, 40);
            this.userName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(534, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(534, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 53);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // userPass
            // 
            this.userPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userPass.Location = new System.Drawing.Point(531, 272);
            this.userPass.Multiline = true;
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(221, 40);
            this.userPass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Reem Kufi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(453, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 57);
            this.label4.TabIndex = 6;
            this.label4.Text = "Login";
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.SystemColors.Window;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(-216, 219);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(454, 258);
            this.gunaCircleButton1.TabIndex = 7;
            // 
            // roleCMB
            // 
            this.roleCMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.roleCMB.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Italic);
            this.roleCMB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roleCMB.FormattingEnabled = true;
            this.roleCMB.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.roleCMB.Location = new System.Drawing.Point(531, 174);
            this.roleCMB.Name = "roleCMB";
            this.roleCMB.Size = new System.Drawing.Size(220, 36);
            this.roleCMB.TabIndex = 8;
            this.roleCMB.Text = "Select Role";
            // 
            // submit_Login
            // 
            this.submit_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.submit_Login.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Italic);
            this.submit_Login.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.submit_Login.Location = new System.Drawing.Point(534, 447);
            this.submit_Login.Name = "submit_Login";
            this.submit_Login.Size = new System.Drawing.Size(216, 62);
            this.submit_Login.TabIndex = 9;
            this.submit_Login.Text = "Submit";
            this.submit_Login.UseVisualStyleBackColor = false;
            this.submit_Login.Click += new System.EventHandler(this.submit_Login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Reem Kufi", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(758, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Clear";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Reem Kufi", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(796, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(836, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submit_Login);
            this.Controls.Add(this.roleCMB);
            this.Controls.Add(this.gunaCircleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_Circle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaCircleButton back_Circle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private System.Windows.Forms.ComboBox roleCMB;
        private System.Windows.Forms.Button submit_Login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

