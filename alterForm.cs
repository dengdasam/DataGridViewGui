using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class alterForm : Form
    {
        public string path = @"..\..\Database\Test.accdb";
        public alterForm(string id, string name, string credit, string remark)
        {
            InitializeComponent();
            textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = credit;
            textBox4.Text = remark;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //数据库连接串
            string constr = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + path;
            //创建SqlConnection的实例
            OleDbConnection conn = new OleDbConnection(constr);
            
            
            try
            {
                
                //打开数据库
                conn.Open();
                string sql = "update course set Name='{0}',Credit={1},Remark='{2}' where ID={3}";
                //填充占位符
                //long IdValue = Convert.ToInt64(textBox1.Text);
                //string NameValue = textBox2.Text;
                //double CreditValue = Convert.ToDouble(textBox3.Text);
                //string RemarkValue = textBox4.Text;



                sql = string.Format(sql, textBox2.Text,textBox3.Text,textBox4.Text,textBox1.Text);
                //创建SqlCommand类的对象
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                //执行修改操作的SQL
                cmd.ExecuteNonQuery();
                //弹出成功提示
                MessageBox.Show("修改成功！");
                //设置当前窗体DislogResult结果为OK
                //this.DialogResult = DialogResult.OK;
                //关闭窗体
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
