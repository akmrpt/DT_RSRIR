using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
 

 


namespace MyWinApp
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string sUserId,sFYear = "";

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userid, password;
            userid = textBox1.Text;
            password = maskedTextBox1.Text;
            var orastr = "User Id=nubitsoft;Password=101171;Data Source=202.143.125.108/fyldb;";
            OracleConnection con = new OracleConnection(); //OracleConnection("Data Source=.;Initial Catalog=Login;User ID=sa;Password=gs123");

            con.ConnectionString = orastr;
            con.Open();
           // MessageBox.Show(con.ServerVersion);

            OracleCommand cmd = new OracleCommand("Select USERID,USERNAME,USERPASSWORD from  USERS where USERNAME='" + textBox1.Text + "' and USERPASSWORD='" + maskedTextBox1.Text + "'", con);

            DataTable dt = new      DataTable ();

             OracleDataAdapter adap = new OracleDataAdapter (cmd);
             adap .Fill (dt);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();


            if (dt.Rows.Count > 0)
            {

                sUserId = textBox1.Text;
                sFYear = comboBox1.Text;

                MyWinApp.MyGlobals.sFYear = sFYear;
                MyWinApp.MyGlobals.sUserName = sUserId; 
               

               // this.Hide();
                frmIndex frm = new frmIndex();
                frm.Icon = this.Icon;

                frm.ShowDialog();
               // MessageBox.Show(dt.Rows.Count.ToString());
           
            }
            else
            {
                textBox1.Text = "";
                maskedTextBox1.Text = ""; 

                MessageBox.Show("invalid userid or password");
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.NUBIT_LOGO_ico; 
        }

        
    }
}
