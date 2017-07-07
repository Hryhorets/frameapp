namespace FrameApp
{
    partial class BaseForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbx_preset = new System.Windows.Forms.ComboBox();
            this.tbx_database = new System.Windows.Forms.TextBox();
            this.lbl_database = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_user = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.tbx_server = new System.Windows.Forms.TextBox();
            this.lbl_server = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(296, 242);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btn_enter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(288, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вхід";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Логін";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(65, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(65, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_enter.Location = new System.Drawing.Point(65, 141);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(158, 30);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.Text = "Увійти";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbx_preset);
            this.tabPage2.Controls.Add(this.tbx_database);
            this.tabPage2.Controls.Add(this.lbl_database);
            this.tabPage2.Controls.Add(this.tbx_password);
            this.tabPage2.Controls.Add(this.lbl_password);
            this.tabPage2.Controls.Add(this.tbx_user);
            this.tabPage2.Controls.Add(this.lbl_port);
            this.tabPage2.Controls.Add(this.tbx_port);
            this.tabPage2.Controls.Add(this.lbl_user);
            this.tabPage2.Controls.Add(this.tbx_server);
            this.tabPage2.Controls.Add(this.lbl_server);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(288, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Параметри";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbx_preset
            // 
            this.cbx_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_preset.FormattingEnabled = true;
            this.cbx_preset.Items.AddRange(new object[] {
            "Сервер FH",
            "Сервер NNG",
            "Ручні налаштування"});
            this.cbx_preset.Location = new System.Drawing.Point(10, 12);
            this.cbx_preset.Name = "cbx_preset";
            this.cbx_preset.Size = new System.Drawing.Size(266, 21);
            this.cbx_preset.TabIndex = 10;
            this.cbx_preset.SelectedIndexChanged += new System.EventHandler(this.cbx_preset_SelectedIndexChanged);
            // 
            // tbx_database
            // 
            this.tbx_database.BackColor = System.Drawing.SystemColors.Info;
            this.tbx_database.Location = new System.Drawing.Point(10, 184);
            this.tbx_database.Name = "tbx_database";
            this.tbx_database.Size = new System.Drawing.Size(266, 20);
            this.tbx_database.TabIndex = 9;
            // 
            // lbl_database
            // 
            this.lbl_database.AutoSize = true;
            this.lbl_database.Location = new System.Drawing.Point(7, 168);
            this.lbl_database.Name = "lbl_database";
            this.lbl_database.Size = new System.Drawing.Size(64, 13);
            this.lbl_database.TabIndex = 8;
            this.lbl_database.Text = "База даних";
            // 
            // tbx_password
            // 
            this.tbx_password.BackColor = System.Drawing.SystemColors.Info;
            this.tbx_password.Location = new System.Drawing.Point(10, 142);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(266, 20);
            this.tbx_password.TabIndex = 7;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(7, 126);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(45, 13);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Пароль";
            // 
            // tbx_user
            // 
            this.tbx_user.BackColor = System.Drawing.SystemColors.Info;
            this.tbx_user.Location = new System.Drawing.Point(10, 100);
            this.tbx_user.Name = "tbx_user";
            this.tbx_user.Size = new System.Drawing.Size(266, 20);
            this.tbx_user.TabIndex = 5;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(225, 43);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(32, 13);
            this.lbl_port.TabIndex = 4;
            this.lbl_port.Text = "Порт";
            // 
            // tbx_port
            // 
            this.tbx_port.BackColor = System.Drawing.SystemColors.Info;
            this.tbx_port.Location = new System.Drawing.Point(228, 59);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(48, 20);
            this.tbx_port.TabIndex = 3;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(7, 84);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(65, 13);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "Користувач";
            // 
            // tbx_server
            // 
            this.tbx_server.BackColor = System.Drawing.SystemColors.Info;
            this.tbx_server.Location = new System.Drawing.Point(10, 59);
            this.tbx_server.Name = "tbx_server";
            this.tbx_server.Size = new System.Drawing.Size(212, 20);
            this.tbx_server.TabIndex = 1;
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Location = new System.Drawing.Point(7, 43);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(44, 13);
            this.lbl_server.TabIndex = 0;
            this.lbl_server.Text = "Сервер";
            // 
            // BaseForm
            // 
            this.AcceptButton = this.btn_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 264);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaseControl v.2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbx_database;
        private System.Windows.Forms.Label lbl_database;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_user;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox tbx_port;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox tbx_server;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.ComboBox cbx_preset;
    }
}

