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
    public partial class ResultsUserControl : UserControl
    {
        private static ResultsUserControl _instance;

        public static ResultsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ResultsUserControl();               //instance is a variable and it is being created by calling the constructor if it is null
                }                                                        // and then returning the constructor 
                return _instance;

            }


        }






        public ResultsUserControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }                                             //this is the data path and known as connection string
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllResults1Data_SP", con);                                   //cmd is the command object
                cmd.CommandType = CommandType.StoredProcedure;                                                        //command type is stored procedure

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try                                                                                 //Dateset is used for filling in the data inside data grid view
                {                                                                                  //DA is the object of data adapter and ds is the object of dataset
                    cmd.ExecuteNonQuery();                                                           //Filling data adapter with dataset

                                                                                                       //we have used nested try and catch ,first try catch for specifically for sql query and the other for general errors that can happen
                }
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

        private void ResultsUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("student_searchresult_sp", con);                                  //Dateset is used for filling in the data inside data grid view
                cmd.CommandType = CommandType.StoredProcedure;                                                     //DA is the object of data adapter and ds is the object of dataset
                cmd.Parameters.AddWithValue("@st_id", student_id_searchresulttextbox.Text);                        //Filling data adapter with dataset

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);                                                                             //we have used nested try and catch ,first try catch for specifically for sql query and the other for general errors that ca


                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();


                }
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
    }
}
