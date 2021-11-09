using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           //List<string> names = new List<string>();
          // names.Add(textBox1.Text);
           // names.Add(textBox2.Text);

            //List<string> positions = new List<string>();
            //positions.Add(PP1comboBox.Text);
            //positions.Add(PP2comboBox.Text);

            //List<List> students = new List<List>();
            //students.Add(new Student() { Id = 1001, Name = "Shakib" });
            //List student1 = new List() { Name = textBox1.Text , Position = PP1comboBox.Text, Goal = 0, Assist = 0};
            //List student2 = new List() { Name = textBox2.Text , Position = PP2comboBox.Text, Goal = 0, Assist = 0};
            //students.Add(student1);
            //students.Add(student2);

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();

            string sql = "Insert into TopList(name,position) values('"+textBox1.Text+"', '"+PP1comboBox.Text+"')";
            SqlCommand command = new SqlCommand(sql,connection);
            int flag = command.ExecuteNonQuery();

            string sql1 = "Insert into TopList(name,position) values('" + textBox1.Text + "', '" + PP1comboBox.Text + "')";
            SqlCommand command1 = new SqlCommand(sql1, connection);
            int flag1 = command1.ExecuteNonQuery();


            if (flag == 1 && flag1 == 1) { MessageBox.Show("Added"); }
        }

    }
}
