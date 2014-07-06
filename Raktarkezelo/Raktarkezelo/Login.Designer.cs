namespace Raktarkezelo
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
            this.tb_userName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_pwd = new System.Windows.Forms.Label();
            this.tb_pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gp_login = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.bt_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.bt_login = new DevComponents.DotNetBar.ButtonX();
            this.lb_login = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Kötelező megadni a felhasználónevet");
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Kötelető kitölteni");
            this.customValidator3 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.gp_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_userName
            // 
            this.tb_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.tb_userName.Border.Class = "TextBoxBorder";
            this.tb_userName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_userName.ForeColor = System.Drawing.Color.Black;
            this.tb_userName.Location = new System.Drawing.Point(6, 33);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(170, 20);
            this.tb_userName.TabIndex = 0;
            this.superValidator1.SetValidator1(this.tb_userName, this.requiredFieldValidator1);
            this.superValidator1.SetValidator2(this.tb_userName, this.customValidator1);
            this.tb_userName.WatermarkText = "Felhasználónév";
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.BackColor = System.Drawing.Color.Transparent;
            this.lb_userName.Location = new System.Drawing.Point(3, 17);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(81, 13);
            this.lb_userName.TabIndex = 1;
            this.lb_userName.Text = "Felhasználónév";
            // 
            // lb_pwd
            // 
            this.lb_pwd.AutoSize = true;
            this.lb_pwd.Location = new System.Drawing.Point(3, 67);
            this.lb_pwd.Name = "lb_pwd";
            this.lb_pwd.Size = new System.Drawing.Size(36, 13);
            this.lb_pwd.TabIndex = 3;
            this.lb_pwd.Text = "Jelszó";
            // 
            // tb_pwd
            // 
            this.tb_pwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.tb_pwd.Border.Class = "TextBoxBorder";
            this.tb_pwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_pwd.ForeColor = System.Drawing.Color.Black;
            this.tb_pwd.Location = new System.Drawing.Point(6, 83);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(170, 20);
            this.tb_pwd.TabIndex = 2;
            this.tb_pwd.UseSystemPasswordChar = true;
            this.superValidator1.SetValidator1(this.tb_pwd, this.requiredFieldValidator2);
            this.superValidator1.SetValidator2(this.tb_pwd, this.customValidator3);
            this.tb_pwd.WatermarkText = "Jelszó";
            // 
            // gp_login
            // 
            this.gp_login.BackColor = System.Drawing.Color.Transparent;
            this.gp_login.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_login.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gp_login.Controls.Add(this.bt_Cancel);
            this.gp_login.Controls.Add(this.bt_login);
            this.gp_login.Controls.Add(this.lb_userName);
            this.gp_login.Controls.Add(this.lb_pwd);
            this.gp_login.Controls.Add(this.tb_userName);
            this.gp_login.Controls.Add(this.tb_pwd);
            this.gp_login.Location = new System.Drawing.Point(206, 12);
            this.gp_login.Name = "gp_login";
            this.gp_login.Size = new System.Drawing.Size(200, 198);
            // 
            // 
            // 
            this.gp_login.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_login.Style.BackColorGradientAngle = 90;
            this.gp_login.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_login.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_login.Style.BorderBottomWidth = 1;
            this.gp_login.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_login.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_login.Style.BorderLeftWidth = 1;
            this.gp_login.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_login.Style.BorderRightWidth = 1;
            this.gp_login.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_login.Style.BorderTopWidth = 1;
            this.gp_login.Style.CornerDiameter = 4;
            this.gp_login.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_login.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp_login.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_login.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_login.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_login.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_login.TabIndex = 4;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_Cancel.Location = new System.Drawing.Point(101, 127);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_Cancel.TabIndex = 5;
            this.bt_Cancel.Text = "Mégse";
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_login
            // 
            this.bt_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_login.Location = new System.Drawing.Point(6, 127);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Belépés";
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_login
            // 
            this.lb_login.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_login.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_login.Location = new System.Drawing.Point(12, 12);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(75, 23);
            this.lb_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lb_login.TabIndex = 5;
            this.lb_login.Text = "Belépés";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Kötelező megadni a felhasználónevet";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "Felhasználónév vagy jelszó nem megfelelő";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator1.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator1_ValidateValue);
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Kötelető kitölteni";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator3
            // 
            this.customValidator3.ErrorMessage = "Felhasználó vagy jelszó nem megfelelő";
            this.customValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.customValidator3.ValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator1_ValidateValue);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Raktarkezelo.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(75)))), ((int)(((byte)(41))))));
            // 
            // Login
            // 
            this.AcceptButton = this.bt_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.gp_login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gp_login.ResumeLayout(false);
            this.gp_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     
        private DevComponents.DotNetBar.Controls.TextBoxX tb_userName;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label lb_pwd;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_pwd;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_login;
        private DevComponents.DotNetBar.ButtonX bt_Cancel;
        private DevComponents.DotNetBar.ButtonX bt_login;
        private DevComponents.DotNetBar.LabelX lb_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}

