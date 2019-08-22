using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    

    public partial class Form1 : Form
    {
        public string path = @"..\..\Database\Test.accdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QueryAllCourse();
        }

        private void QueryAllCourse()
        {
            
            string constr  = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + path;
            OleDbConnection conn = new OleDbConnection(constr);

           

            try
            {
                
                conn.Open();
                string sql = "select * from course";
                OleDbDataAdapter sda = new OleDbDataAdapter(sql,conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "编号";
                dataGridView1.Columns[1].HeaderText = "课程名称";
                dataGridView1.Columns[2].HeaderText = "学分";
                dataGridView1.Columns[3].HeaderText = "备注";

                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.BackgroundColor = Color.PaleTurquoise;
                dataGridView1.MultiSelect = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
            catch(Exception ex)
            {
                MessageBox.Show("查询出现错误！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }



        }

        private void Btn1Search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string constr = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source="+path;
                OleDbConnection conn = new OleDbConnection(constr);


                try
                {
                    string sql = "select * from course where Name like'%{0}%'";

                    sql = string.Format(sql, textBox1.Text);
                    OleDbDataAdapter sda = new OleDbDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                    sda.Fill(ds);
                    //设置表格控件的DataSource属性
                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {

                    MessageBox.Show("出现错误！" + ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                QueryAllCourse();
            }


        }

        private void BtnAlter_Click(object sender, EventArgs e)
        {
            try
            {
                //获取DataGridView控件中的值
                //获取课程编号
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                //获取课程名称
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //获取课程名称
                string credit = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                //获取课程名称
                string remark = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                //创建updateForm类的对象，并将课程信息传递给修改界面
                alterForm alterForm = new alterForm(id, name, credit, remark);
                //弹出修改信息窗口
                DialogResult dr = alterForm.ShowDialog();
                //判断是否单击确定按钮
                if (dr == DialogResult.OK)
                {
                    //调用查询全部课程方法
                    QueryAllCourse();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("请先选择数据行");

            }
            
          

            
           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //获取DataGridView控件中选中行的编号列的值
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //数据库连接串
            string constr = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + path;
            //创建SqlConnection的实例
            OleDbConnection conn = new OleDbConnection(constr);
            try
            {
                
                //打开数据库
                conn.Open();
                string sql = "delete from course where ID={0}";
                //填充占位符
                sql = string.Format(sql, id);
                //创建SqlCommand类的对象
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                //执行SQL语句
                cmd.ExecuteNonQuery();
                //弹出消息提示删除成功
                MessageBox.Show("删除成功！");
                //调用查询全部的方法，刷新DataGridView控件中的数据
                QueryAllCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败！" + ex.Message);
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
    }
}
