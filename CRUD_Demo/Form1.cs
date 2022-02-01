using System;
using System.Data;
using System.Data.SqlClient;
namespace CRUD_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " "))
            {
                try
                {
                    con = new SqlConnection("data source =devops.aapnainfotech.com;database=CRUD_Demo; uid=apnsa; pwd=W98rd41lMravjL5");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Student_Demo(sid,sname,course)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Values Inserted Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter All fields!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if ((!(textBox2.Text == ""))&&textBox3.Text=="")
            {
                try
                {
                    con = new SqlConnection("data source =devops.aapnainfotech.com;database=CRUD_Demo; uid=apnsa; pwd=W98rd41lMravjL5");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Student_Demo set sname='" + textBox2.Text + "' where sid='" + textBox1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Name Value Updated Successfully!");
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con?.Close();
                }
                
            }
            else if((!(textBox3.Text == ""))&&textBox2.Text=="")
            {
                try
                {
                    con = new SqlConnection("data source =devops.aapnainfotech.com;database=CRUD_Demo; uid=apnsa; pwd=W98rd41lMravjL5");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Student_Demo set course='" + textBox3.Text + "' where sid='" + textBox1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Courss and Name Values Updated Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con?.Close();
                }
                
            }
            else if(!(textBox2.Text==""&&textBox3.Text==""))
            {
                try
                {
                    con = new SqlConnection("data source =devops.aapnainfotech.com;database=CRUD_Demo; uid=apnsa; pwd=W98rd41lMravjL5");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Student_Demo set sname='"+textBox2.Text+"', course='" + textBox3.Text + "' where sid='" + textBox1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course Values Updated Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con?.Close();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("data source =devops.aapnainfotech.com;database=CRUD_Demo; uid=apnsa; pwd=W98rd41lMravjL5");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete Student_Demo where sid='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row deleted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("data source =devops.aapnainfotech.com;database=CRUD_Demo; uid=apnsa; pwd=W98rd41lMravjL5");
                SqlCommand cmd = new SqlCommand("select * from Student_Demo", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
/*          
*/