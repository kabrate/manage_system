namespace 教务管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sighin_button = new System.Windows.Forms.Button();
            this.sighup_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sighin_button
            // 
            this.sighin_button.Location = new System.Drawing.Point(378, 275);
            this.sighin_button.Name = "sighin_button";
            this.sighin_button.Size = new System.Drawing.Size(65, 35);
            this.sighin_button.TabIndex = 0;
            this.sighin_button.Text = "注册";
            this.sighin_button.UseVisualStyleBackColor = true;
            this.sighin_button.Click += new System.EventHandler(this.sighin_button_Click);
            // 
            // sighup_button
            // 
            this.sighup_button.Location = new System.Drawing.Point(265, 275);
            this.sighup_button.Name = "sighup_button";
            this.sighup_button.Size = new System.Drawing.Size(65, 35);
            this.sighup_button.TabIndex = 0;
            this.sighup_button.Text = "登陆";
            this.sighup_button.UseVisualStyleBackColor = true;
            this.sighup_button.Click += new System.EventHandler(this.sighup_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(198, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎光临教务系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(262, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(262, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(314, 162);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(129, 21);
            this.name_text.TabIndex = 2;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(314, 199);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(129, 21);
            this.password_text.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sighup_button);
            this.Controls.Add(this.sighin_button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教务系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sighin_button;
        private System.Windows.Forms.Button sighup_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox password_text;
    }
}

