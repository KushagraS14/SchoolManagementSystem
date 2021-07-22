using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_management_system2_laurels_
{
    public partial class ExamsUserControl : UserControl
    {
        private static ExamsUserControl _instance;

        public static ExamsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ExamsUserControl();                                //instance is a variable and it is being created by calling the constructor if it is null 
                                                                                       // and then returning the constructor 
                }
                return _instance;

            }
        
    }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public ExamsUserControl()
        {
            InitializeComponent();
        }


        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllExamsData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;                                            //cmd is the command object
                                                                                                          //command type is stored procedure
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();                                                                 //Dateset is used for filling in the data inside data grid view

                                                                                                         //DA is the object of data adapter and ds is the object of dataset
                }
                catch (Exception ex)                                                                            //Filling data adapter with dataset
                {

                    MessageBox.Show(" <<<Invalid SQL Operation>>>:\n" + ex);

                }
                con.Close();                                                                      //we have used nested try and catch ,first try catch for specifically for sql query and the other for general errors that can happen
                dataGridView3.DataSource = DS.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }


        }
        private void ExamsUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }
}
