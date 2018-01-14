using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace 教务管理系统
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }
        Control[] controls = new Control[20];
        public void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is Label || ctrl is Button || ctrl is TextBox)
            //    {
            //        this.Controls.Remove(ctrl);
            //    }
            //}
            for (int i = 0; i < 6; i++)
            {
                controls[i] = new Label();
                controls[i].Name = "label" + i.ToString();
                controls[i].Location = new Point(16, 93 + i * 40);
                this.Controls.Add(controls[i]);

            }
            for (int i=6;i<10;i++)
            {
                controls[i] = new TextBox();
                controls[i].Name = "text" + i.ToString();
                controls[i].Location = new Point(116,90 + (i-6) * 40);
                this.Controls.Add(controls[i]);
            }
            for (int i=12;i<16;i++)//添加Button类
            {
                controls[i] = new Button();
                controls[i].SetBounds(600,70+(i-12)*80, 60, 30);
                this.Controls.Add(controls[i]);
            }
            controls[0].Text = "教师号";
            controls[1].Text = "教师名";
            controls[2].Text = "性别";
            controls[3].Text = "职称";
            //controls[4].Text = "最低成绩";
            //controls[5].Text = "及格率";
            controls[6].Text = "";
            controls[7].Text = "";
            controls[8].Text = "";
            controls[9].Text = "";
            //controls[10].Text = "";
            //controls[11].Text = "";
            controls[12].Text = "查询";
            controls[12].Click += delegate { Button1_Click(); };
            controls[13].Text = "删除";
            controls[13].Click += delegate { Button2_Click(); };
            controls[14].Text = "插入";
            controls[14].Click += delegate { Button3_Click(); };
            controls[15].Text = "修改";
            controls[15].Click += delegate { Button4_Click(); };
            //controls[16] = new DataGridView();



        }
        public void Button1_Click()//查找
        {
            controls[6].Text=DB.select("学号", "stu", "学号", string.Format("{0}", controls[6].Text));
            controls[7].Text = DB.select("姓名", "stu", "学号", string.Format("{0}", controls[6].Text));
            controls[8].Text = DB.select("性别", "stu", "学号", string.Format("{0}", controls[6].Text));
            controls[9].Text = DB.select("出生日期", "stu", "学号", string.Format("{0}", controls[6].Text));
            controls[10].Text = DB.select("班级号", "stu", "学号", string.Format("{0}", controls[6].Text));
            controls[11].Text = DB.select("总学分", "stu", "学号", string.Format("{0}",controls[6].Text));


        }
        public void Button2_Click()//删除  
        {
            DB.delete("stu", "学号", string.Format("{0}",controls[6].Text));
        }
        public void Button3_Click()//插入主键相同的无效
        {
            DB.insert(string.Format("{0}",controls[6].Text),"赵二小","男","1997-8-9","18","70");
        }
        public void Button4_Click()//更新
        {
            DB.update(string.Format("{0}", controls[6].Text),string.Format("{0}", controls[7].Text), string.Format("{0}", controls[8].Text),
                string.Format("{0}", controls[9].Text), string.Format("{0}", controls[10].Text), string.Format("{0}", controls[11].Text));
        }

        private void 成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            for (int i=0;i<controls.Length;i++ )
            {
                this.Controls.Remove(controls[i]);
            }
            

        }

        private void Select_Load(object sender, EventArgs e)
        {

        }

        private void Select_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=magrsys.db;"))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from teacher where 教师名 = '王建国'";
                int rows = cmd.ExecuteNonQuery();
                SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                //conn.Close();
                DataTable dtb = ds.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.DataSource = dtb;
                this.dataGridView1.Columns["Column1"].DataPropertyName = dtb.Columns["教师号"].ToString();
                this.dataGridView1.Columns["Column2"].DataPropertyName = dtb.Columns["教师名"].ToString();
                this.dataGridView1.Columns["Column3"].DataPropertyName = dtb.Columns["性别"].ToString();
                this.dataGridView1.Columns["Column4"].DataPropertyName = dtb.Columns["职称"].ToString();
                //this.dataGridView1.Columns["Column5"].DataPropertyName = dtb.Columns["最低分数"].ToString();
                //this.dataGridView1.Columns["Column6"].DataPropertyName = dtb.Columns["及格率"].ToString();
            }
        }
    }

}
