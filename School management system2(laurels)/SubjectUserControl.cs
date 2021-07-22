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
    public partial class SubjectUserControl : UserControl
    {

        private static SubjectUserControl _instance;

        public static SubjectUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SubjectUserControl();                             //instance is a variable and it is being created by calling the constructor if it is null 
                                                                                      // and then returning the constructor 
                }
                return _instance;

            }


        }
                                         //this is the data path and known as connection string
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");


        public SubjectUserControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void SubjectUserControl_Load_1(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
        private void SubjectUserControl_Load(object sender, EventArgs e)
        {
           
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllSubjectsData_SP ", con);                //cmd is the command object
                cmd.CommandType = CommandType.StoredProcedure;                                       //command type is stored procedure

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();                                   
                DA.Fill(DS);                                                                       //Dateset is used for filling in the data inside data grid view
                                                                                                   //DA is the object of data adapter and ds is the object of dataset
                                                                                                   //Filling data adapter with dataset
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();


                }                                                                                  //we have used nested try and catch ,first try catch for specifically for sql query and the other for general errors that can happen
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

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("subject_search_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@subject_id", subject_id_searchtextbox.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                                                                                    //we have used nested try and catch ,first try catch for specifically for sql query and the other for general errors that can happen

                con.Open();
                try                                                                           //Dateset is used for filling in the data inside data grid view
                                                                                              //DA is the object of data adapter and ds is the object of dataset
                                                                                              //Filling data adapter with dataset
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

        private void add_subjectbutton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SubjectAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subject_id", subjectidtextbox.Text);                              //whatever value you are wrting in textbox  is given to the parameter and that parameter is attached 
            cmd.Parameters.AddWithValue("@sub_name", subjectname_Textbox.Text);                                                                                             //in the stored procure for inserting the values and solving the sql query.
            cmd.Parameters.AddWithValue("@Streams ", Streams_textbox.Text);
            cmd.Parameters.AddWithValue("@st_id", studentid_textbox.Text);

            con.Open();
            try
            {

                cmd.ExecuteNonQuery();                         //for executing the commands

            }
            catch (Exception ex)
            {
                MessageBox.Show("<<<Invalid SQL Operation>>>:\n" + ex);

            }
            con.Close();

            refresh_DataGridView();                     //calls the function which ultimately changes the data set


            subjectidtextbox.Text = " ";
            subjectname_Textbox.Text = " ";
            Streams_textbox.Text = " ";
            studentid_textbox.Text = " ";                                             //clears all the text in the textbox
           

        }
    }
}
