namespace 教务管理系统
{
    partial class signin_Form
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
            this.password_text = new System.Windows.Forms.TextBox();
            this.user_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signin_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(314, 199);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(129, 21);
            this.password_text.TabIndex = 5;
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(314, 162);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(129, 21);
            this.user_text.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(231, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "请输入密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(231, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "请输入账号";
            // 
            // signin_button
            // 
            this.signin_button.Location = new System.Drawing.Point(378, 275);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(65, 35);
            this.signin_button.TabIndex = 7;
            this.signin_button.Text = "注册";
            this.signin_button.UseVisualStyleBackColor = true;
            this.signin_button.Click += new System.EventHandler(this.signin_button_Click);
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(265, 275);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(65, 35);
            this.return_button.TabIndex = 8;
            this.return_button.Text = "返回";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // signin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.signin_button);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "signin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.signin_Form_FormClosed);
            this.Load += new System.EventHandler(this.signin_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signin_button;
        private System.Windows.Forms.Button return_button;
    }
}