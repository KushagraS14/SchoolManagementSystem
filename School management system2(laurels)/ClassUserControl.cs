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
    public partial class ClassUserControl : UserControl
    {
        private static ClassUserControl _instance;

        public static ClassUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClassUserControl();                          //instance is a variable and it is being created by calling the constructor if it is null 
                                                                                 // and then returning the constructor 
                }
                return _instance;

            }


        }
          public ClassUserControl()
        {
            InitializeComponent();
        }                                            //this is the data path and known as connection string
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");



        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllClassData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;                                                //Dateset is used for filling in the data inside data grid view
                                                                                                              //DA is the object of data adapter and ds is the object of dataset
                                                                                                              //Filling data adapter with dataset
                SqlDataAdapter DA = new SqlDataAdapter(cmd);                                            //cmd is the command object
                DataSet DS = new DataSet();
                DA.Fill(DS);                                                                                //command type is stored procedure

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();


                }                                                                     //we have used nested try and catch ,first try catch for specifically for sql query and the other for general errors that can happen
                catch (Exception ex)
                {

                    MessageBox.Show(" <<<Invalid SQL Operation>>>:\n" + ex);

                }
                con.Close();
                dataGridView3.DataSource = DS.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClassUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }
}
