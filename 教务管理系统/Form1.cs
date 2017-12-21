using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 教务管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void sighin_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin_Form signin_form = new signin_Form();
            signin_form.Show();
        }

        private void sighup_button_Click(object sender, EventArgs e)
        {
            string password;
            password = DB.signup(name_text.Text);
            if (password == password_text.Text) MessageBox.Show("登陆成功");
            else MessageBox.Show("用户名或密码错误");
            

        }
    }
}
