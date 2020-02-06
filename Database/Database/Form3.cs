using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Database
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectStr = "server = localhost;port=3306;database=gymnastics competition;user=root;password=shenkai1999"; // 用户名和密码在MySQL定义的
            // 创建连接
            MySqlConnection conn = new MySqlConnection(connectStr);

            try
            {
                // 打开连接
                conn.Open();
                if (conn.State.ToString() == "Open")
                {
                    Console.WriteLine("数据库已连接");
                }
                else
                {
                    Console.WriteLine("数据库未连接");
                }

                string name = textBox1.Text.ToString();
                string user = textBox2.Text.ToString();
                string password = textBox3.Text.ToString();
                var number = textBox4.Text;            
                string sql = "insert into team(TeamName,TeamNum,Tuser,Tpassword) values('" + name + "','" + number + "','" + user + "','" + password + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                // 关闭连接
                conn.Close();
                Console.WriteLine("数据库已关闭");
            }
        }
    }
}
