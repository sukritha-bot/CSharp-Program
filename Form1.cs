using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Databasegrid
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataAdapter adp1;
        DataSet ds;
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=KRIPARAJ\\SQLEXPRESS; database=Employee; user ID=sa; Password=Sukritha7###");
            con.Open();

            adp = new SqlDataAdapter("SELECT * FROM EMP",con);
            adp1 = new SqlDataAdapter("SELECT * FROM DEPT", con);
            ds = new DataSet();
            adp.Fill(ds, "EMP");
            adp1.Fill(ds, "DEPT");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "EMP";

            cmb_deptno.DataSource = ds.Tables["DEPT"];
            cmb_deptno.ValueMember = "DEPTNO".ToString();

            cmb_mgr.DataSource = ds.Tables["EMP"];
            cmb_mgr.ValueMember = "EMPNO".ToString();

            if(ds.Tables["EMP"].Rows.Count >= 0)
            {
                i = 0;
                txt_Empno.Text = ds.Tables["EMP"].Rows[i]["EMPNO"].ToString();
                txt_name.Text = ds.Tables["EMP"].Rows[i]["ENAME"].ToString();
                txt_sal.Text = ds.Tables["EMP"].Rows[i]["SAL"].ToString();
                cmb_deptno.Text = ds.Tables["EMP"].Rows[i]["DEPTNO"].ToString();
                txt_jdate.Text = ds.Tables["EMP"].Rows[i]["JDATE"].ToString();
                cmb_mgr.Text = ds.Tables["EMP"].Rows[i]["MGR"].ToString();
            }
            else
            {
                MessageBox.Show("No Records");
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            if (ds.Tables["EMP"].Rows.Count >= 0)
            {
                i = 0;
                txt_Empno.Text = ds.Tables["EMP"].Rows[i]["EMPNO"].ToString();
                txt_name.Text = ds.Tables["EMP"].Rows[i]["ENAME"].ToString();
                txt_sal.Text = ds.Tables["EMP"].Rows[i]["SAL"].ToString();
                cmb_deptno.Text = ds.Tables["EMP"].Rows[i]["DEPTNO"].ToString();
                txt_jdate.Text = ds.Tables["EMP"].Rows[i]["JDATE"].ToString();
                cmb_mgr.Text = ds.Tables["EMP"].Rows[i]["MGR"].ToString();
            }
            else
            {
                MessageBox.Show("No Records");
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            if (ds.Tables["EMP"].Rows.Count >= 0)
            {
                i = ds.Tables["EMP"].Rows.Count - 1;
                txt_Empno.Text = ds.Tables["EMP"].Rows[i]["EMPNO"].ToString();
                txt_name.Text = ds.Tables["EMP"].Rows[i]["ENAME"].ToString();
                txt_sal.Text = ds.Tables["EMP"].Rows[i]["SAL"].ToString();
                cmb_deptno.Text = ds.Tables["EMP"].Rows[i]["DEPTNO"].ToString();
                txt_jdate.Text = ds.Tables["EMP"].Rows[i]["JDATE"].ToString();
                cmb_mgr.Text = ds.Tables["EMP"].Rows[i]["MGR"].ToString();
            }
            else
            {
                MessageBox.Show("No Records");
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (i != 0)
            {
                i--;
                txt_Empno.Text = ds.Tables["EMP"].Rows[i]["EMPNO"].ToString();
                txt_name.Text = ds.Tables["EMP"].Rows[i]["ENAME"].ToString();
                txt_sal.Text = ds.Tables["EMP"].Rows[i]["SAL"].ToString();
                cmb_deptno.Text = ds.Tables["EMP"].Rows[i]["DEPTNO"].ToString();
                txt_jdate.Text = ds.Tables["EMP"].Rows[i]["JDATE"].ToString();
                cmb_mgr.Text = ds.Tables["EMP"].Rows[i]["MGR"].ToString();
            }
            else
            {
                MessageBox.Show("First Records");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (i < ds.Tables["EMP"].Rows.Count -1)
            {
                i++;
                txt_Empno.Text = ds.Tables["EMP"].Rows[i]["EMPNO"].ToString();
                txt_name.Text = ds.Tables["EMP"].Rows[i]["ENAME"].ToString();
                txt_sal.Text = ds.Tables["EMP"].Rows[i]["SAL"].ToString();
                cmb_deptno.Text = ds.Tables["EMP"].Rows[i]["DEPTNO"].ToString();
                txt_jdate.Text = ds.Tables["EMP"].Rows[i]["JDATE"].ToString();
                cmb_mgr.Text = ds.Tables["EMP"].Rows[i]["MGR"].ToString();
            }
            else
            {
                MessageBox.Show("No Records");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_Empno.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_sal.Text = string.Empty;
            cmb_deptno.Text = string.Empty;
            txt_jdate.Text = string.Empty;
            cmb_mgr.Text = string.Empty;

            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            btn_first.Enabled = false;
            btn_last.Enabled = false;
            btn_prev.Enabled = false;
            btn_next.Enabled = false;
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_Empno.Text != "" && txt_name.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO EMP(EMPNO,ENAME,SAL,DEPTNO,JDATE,MGR) VALUES(@empno,@name,@sal,@deptno,@jdate,@mgr)", con);
                cmd.Parameters.AddWithValue("@empno", txt_Empno.Text);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@sal", txt_sal.Text);
                cmd.Parameters.AddWithValue("@deptno", cmb_deptno.Text);
                cmd.Parameters.AddWithValue("@jdate", txt_jdate.Text);
                cmd.Parameters.AddWithValue("@mgr", cmb_mgr.Text);
                cmd.ExecuteNonQuery();

                adp = new SqlDataAdapter("SELECT * FROM EMP", con);
                ds = new DataSet();
                adp.Fill(ds, "EMP");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "EMP";

                MessageBox.Show("Data Inserted Successfully");

            }
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_first.Enabled = true;
            btn_last.Enabled = true;
            btn_prev.Enabled = true;
            btn_next.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE EMP SET ENAME=@name,SAL=@sal,DEPTNO=@deptno,JDATE=@jdate,MGR=@mgr WHERE EMPNO=@empno", con);
            cmd.Parameters.AddWithValue("@empno", txt_Empno.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@sal", txt_sal.Text);
            cmd.Parameters.AddWithValue("@deptno", cmb_deptno.Text);
            cmd.Parameters.AddWithValue("@jdate", txt_jdate.Text);
            cmd.Parameters.AddWithValue("@mgr", cmb_mgr.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM EMP", con);
            ds = new DataSet();
            adp.Fill(ds, "EMP");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "EMP";

            MessageBox.Show("Data Updated Successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE EMP WHERE EMPNO=@empno", con);
            cmd.Parameters.AddWithValue("@empno", txt_Empno.Text);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter("SELECT * FROM EMP", con);
            ds = new DataSet();
            adp.Fill(ds, "EMP");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "EMP";

            MessageBox.Show("Data Deleted Successfully");
        }
    }
}
