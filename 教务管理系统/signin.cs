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
    public partial class signin_Form : Form
    {
        public signin_Form()
        {
            InitializeComponent();
        }
        
        private void signin_button_Click(object sender, EventArgs e)
        {
            string name,password;
            name = user_text.Text;
            password = password_text.Text;
            if (name != "" && password != "")
                DB.signin(name, password);
            else MessageBox.Show("请输入账号和密码");
            
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
