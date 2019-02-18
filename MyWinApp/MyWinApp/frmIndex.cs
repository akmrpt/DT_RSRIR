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
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.MASTERMENU' table. You can move, or remove it, as needed.
            this.mASTERMENUTableAdapter.Fill(this.dataSet1.MASTERMENU);
            DataTable dt = new DataTable();

            toolStripStatus_lbl_LoginName.Text =  MyWinApp.MyGlobals.sUserName ;
            toolStripStatus_lbl_FYear.Text = MyWinApp.MyGlobals.sFYear;
            OracleConnection con = new OracleConnection(); //OracleConnection("Data Source=.;Initial Catalog=Login;User ID=sa;Password=gs123");
            con.ConnectionString = MyWinApp.MyGlobals.sOrastr;
         

            OracleCommand cmd = new OracleCommand("pr_UserLoginMenu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("VsFYear", OracleDbType.Varchar2).Value = MyWinApp.MyGlobals.sFYear;
            cmd.Parameters.Add("VsUserName", OracleDbType.Varchar2).Value = MyWinApp.MyGlobals.sUserName;

            cmd.Parameters.Add("retval", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
               // dataGridView2.DataSource = dt; 


            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception: {0}", ex.ToString());
            }


            
             
        }

        private void frmIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
