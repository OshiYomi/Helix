
namespace OOO_Fishing
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.Button_login = new System.Windows.Forms.Button();
            this.TextBox_login = new System.Windows.Forms.TextBox();
            this.TextBox_password = new System.Windows.Forms.TextBox();
            this.Label_login = new System.Windows.Forms.Label();
            this.Label_password = new System.Windows.Forms.Label();
            this.PanelFishing = new System.Windows.Forms.Panel();
            this.LabelFishing = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.Panel_login = new System.Windows.Forms.Panel();
            this.PictureBox_captcha = new System.Windows.Forms.PictureBox();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.PanelFishing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.Panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_login
            // 
            this.Button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Button_login.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Button_login.Location = new System.Drawing.Point(228, 26);
            this.Button_login.Margin = new System.Windows.Forms.Padding(4);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(150, 44);
            this.Button_login.TabIndex = 0;
            this.Button_login.Text = "Авторизоваться";
            this.Button_login.UseVisualStyleBackColor = false;
            this.Button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // TextBox_login
            // 
            this.TextBox_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.TextBox_login.Location = new System.Drawing.Point(228, 107);
            this.TextBox_login.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_login.Name = "TextBox_login";
            this.TextBox_login.Size = new System.Drawing.Size(148, 28);
            this.TextBox_login.TabIndex = 1;
            this.TextBox_login.Text = "7efwqtub80i5@outlook.com";
            // 
            // TextBox_password
            // 
            this.TextBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.TextBox_password.Location = new System.Drawing.Point(228, 163);
            this.TextBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.Size = new System.Drawing.Size(148, 28);
            this.TextBox_password.TabIndex = 2;
            this.TextBox_password.Text = "2L6KZG";
            // 
            // Label_login
            // 
            this.Label_login.AutoSize = true;
            this.Label_login.Location = new System.Drawing.Point(275, 83);
            this.Label_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_login.Name = "Label_login";
            this.Label_login.Size = new System.Drawing.Size(54, 20);
            this.Label_login.TabIndex = 3;
            this.Label_login.Text = "Логин";
            // 
            // Label_password
            // 
            this.Label_password.AutoSize = true;
            this.Label_password.Location = new System.Drawing.Point(270, 139);
            this.Label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_password.Name = "Label_password";
            this.Label_password.Size = new System.Drawing.Size(65, 20);
            this.Label_password.TabIndex = 4;
            this.Label_password.Text = "Пароль";
            // 
            // PanelFishing
            // 
            this.PanelFishing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.PanelFishing.Controls.Add(this.LabelFishing);
            this.PanelFishing.Controls.Add(this.PictureBoxLogo);
            this.PanelFishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFishing.Location = new System.Drawing.Point(0, 0);
            this.PanelFishing.Name = "PanelFishing";
            this.PanelFishing.Size = new System.Drawing.Size(618, 80);
            this.PanelFishing.TabIndex = 5;
            // 
            // LabelFishing
            // 
            this.LabelFishing.AutoSize = true;
            this.LabelFishing.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFishing.Location = new System.Drawing.Point(232, 27);
            this.LabelFishing.Name = "LabelFishing";
            this.LabelFishing.Size = new System.Drawing.Size(155, 26);
            this.LabelFishing.TabIndex = 2;
            this.LabelFishing.Text = "ООО \"Рыбалка\"";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(27, 0);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(84, 80);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // Panel_login
            // 
            this.Panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Panel_login.Controls.Add(this.Button_login);
            this.Panel_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_login.Location = new System.Drawing.Point(0, 198);
            this.Panel_login.Name = "Panel_login";
            this.Panel_login.Size = new System.Drawing.Size(618, 90);
            this.Panel_login.TabIndex = 6;
            // 
            // PictureBox_captcha
            // 
            this.PictureBox_captcha.Image = global::OOO_Fishing.Properties.Resources.captcha;
            this.PictureBox_captcha.Location = new System.Drawing.Point(433, 88);
            this.PictureBox_captcha.Name = "PictureBox_captcha";
            this.PictureBox_captcha.Size = new System.Drawing.Size(136, 71);
            this.PictureBox_captcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_captcha.TabIndex = 7;
            this.PictureBox_captcha.TabStop = false;
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(433, 165);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(136, 28);
            this.textBoxCaptcha.TabIndex = 8;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 288);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.PictureBox_captcha);
            this.Controls.Add(this.Panel_login);
            this.Controls.Add(this.PanelFishing);
            this.Controls.Add(this.Label_password);
            this.Controls.Add(this.Label_login);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_login);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.PanelFishing.ResumeLayout(false);
            this.PanelFishing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.Panel_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_captcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_login;
        private System.Windows.Forms.TextBox TextBox_login;
        private System.Windows.Forms.TextBox TextBox_password;
        private System.Windows.Forms.Label Label_login;
        private System.Windows.Forms.Label Label_password;
        private System.Windows.Forms.Panel PanelFishing;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Panel Panel_login;
        private System.Windows.Forms.PictureBox PictureBox_captcha;
        private System.Windows.Forms.TextBox textBoxCaptcha;
        private System.Windows.Forms.Label LabelFishing;
    }
}

