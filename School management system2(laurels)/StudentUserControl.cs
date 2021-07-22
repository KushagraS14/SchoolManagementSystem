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
    public partial class StudentUserControl : UserControl
    {
        private static StudentUserControl _instance;

        public static StudentUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StudentUserControl();                 //instance is a variable and it is being created by calling the constructor if it is null 
                                                                          // and then returning the constructor 
                }
                return _instance;

            }


        }                                                              
                                       //this is the data path and known as connection string
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

            public StudentUserControl()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void StudentUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand ("ShowAllStudentsData_SP ", con);                       //cmd is the command object
                cmd.CommandType = CommandType.StoredProcedure;                                         //command type is stored procedure

                SqlDataAdapter DA = new SqlDataAdapter(cmd);                   
                DataSet DS = new DataSet();                                  //Dateset is used for filling in the data inside data grid view
                DA.Fill(DS);                                                  //DA is the object of data adapter and ds is the object of dataset
                                                                               //Filling data adapter with dataset
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();                          //we have used nested try and catch ,first try catch for specifically for sql query and the other for general errors that can happen


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




           

        private void add_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd= new SqlCommand("StudentAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@st_id", Student_id_textbox.Text);                              //whatever value you are wrting in textbox  is given to the parameter and that parameter is attached 
                                                                                                          //in the stored procure for inserting the values and solving the sql query.
            cmd.Parameters.AddWithValue("@Reg_id", regidtextbox.Text);
            cmd.Parameters.AddWithValue("@st_gender", gender_textbox.Text);
            cmd.Parameters.AddWithValue("@st_age", age_textbox.Text);
            cmd.Parameters.AddWithValue("@st_phone_no", long.Parse(Phone_numbertextbox.Text));
            cmd.Parameters.AddWithValue("@st_email", email_textbox.Text);
            cmd.Parameters.AddWithValue("@st_name", nametextbox.Text);


            con.Open();
            try
            {

                cmd.ExecuteNonQuery();                         //for executing the commands

            }
            catch(Exception ex)
            { 
            MessageBox.Show("<<<Invalid SQL Operation>>>:\n" + ex);

            }
            con.Close();

            refresh_DataGridView();                                                               //calls the function which ultimately changes the data set

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("studentdelete_sp", con);                        //cmd is the command object
                cmd.CommandType = CommandType.StoredProcedure;                                     //command type is stored procedure
                cmd.Parameters.AddWithValue("@st_id", Student_id_textbox.Text);



                con.Open();
                try
                {                                                                                  //whatever value you are wrting in textbox  is given to the parameter and that parameter is attached 
                                                                                                   //in the stored procure for inserting the values and solving the sql query.

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("<<<Invalid SQL Operation>>>:\n" + ex);

                }
                con.Close();

                refresh_DataGridView();
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
                SqlCommand cmd = new SqlCommand("student_search_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@st_id", student_id_searchtextbox.Text);                           //Dateset is used for filling in the data inside data grid view
                                                                                                                //DA is the object of data adapter and ds is the object of dataset
                SqlDataAdapter DA = new SqlDataAdapter(cmd);                                                      //Filling data adapter with dataset
                DataSet DS = new DataSet();
                DA.Fill(DS);
                

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ex)                                                               //we have used nested try and catch ,first try catch for specifically for sql query and the other for general errors that can happen
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

        private void clear_button_Click(object sender, EventArgs e)
        {
            student_id_searchtextbox.Text = " ";
            Student_id_textbox.Text = " ";
            regidtextbox.Text = " ";
            gender_textbox.Text = " ";                                             //clears all the text in the textbox
            age_textbox.Text = " ";
            Phone_numbertextbox.Text = " ";
            email_textbox.Text = " ";
            nametextbox.Text = " ";
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdateStudent_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@st_id", Student_id_textbox.Text);                              //whatever value you are wrting in textbox  is given to the parameter and that parameter is attached 
                                                                                                         //in the stored procure for inserting the values and solving the sql query.
            cmd.Parameters.AddWithValue("@reg_id", regidtextbox.Text);
            cmd.Parameters.AddWithValue("@st_gender", gender_textbox.Text);
            cmd.Parameters.AddWithValue("@st_age", age_textbox.Text);
            cmd.Parameters.AddWithValue("@st_phone_no", Phone_numbertextbox.Text);
            cmd.Parameters.AddWithValue("@st_email", email_textbox.Text);
            cmd.Parameters.AddWithValue("@st_name", nametextbox.Text);


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

            refresh_DataGridView();                                                               //calls the function which ultimately changes the data set

        }
    }
 }

