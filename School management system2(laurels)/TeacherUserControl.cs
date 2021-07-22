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
    public partial class TeacherUserControl : UserControl
    {
        private static TeacherUserControl _instance;

        public static TeacherUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TeacherUserControl();                               //instance is a variable and it is being created by calling the constructor if it is null 
                                                                                        // and then returning the constructor 
                }
                return _instance;

            }


        }                                        //this is the data path and known as connection string
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

        public TeacherUserControl()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void TeacherUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void TeacherUserControl_Load_1(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllTeacherData_SP ", con);
                cmd.CommandType = CommandType.StoredProcedure;                                    //Dateset is used for filling in the data inside data grid view
                                                                                                  //DA is the object of data adapter and ds is the object of dataset
                SqlDataAdapter DA = new SqlDataAdapter(cmd);                                      //Filling data adapter with dataset
                DataSet DS = new DataSet();
                DA.Fill(DS);

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
                dataGridView2.DataSource = DS.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }


        }






        private void add_button_Click(object sender, EventArgs e)
        {
           
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Teacher_search_sp", con);                                    //whatever value you are wrting in textbox  is given to the parameter and that parameter is attached 
                                                                                                              //in the stored procure for inserting the values and solving the sql query
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@teacher_id", teacher_id_searchtextbox.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);                                                                              //we have used nested try and catch ,first try catch for specifically for sql query and the other for general errors that can happen


                con.Open();
                try                                                                                          //Dateset is used for filling in the data inside data grid view
                {
                    cmd.ExecuteNonQuery();
                                                                                                                //DA is the object of data adapter and ds is the object of dataset
                                                                                                                    //Filling data adapter with dataset

                }
                catch (Exception ex)
                {

                    MessageBox.Show(" <<<Invalid SQL Operation>>>:\n" + ex);

                }
                con.Close();
                dataGridView2.DataSource = DS.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);

            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            teacher_id_searchtextbox.Text = " ";
            Teacher_id_textbox.Text = " ";                                                            //clears all the text in the textbox
            gender_textbox.Text = " ";
            joindate_textbox.Text = " ";
            Phone_numbertextbox.Text = " ";
            email_textbox.Text = " ";
            nametextbox.Text = " ";
        }

       

        private void add_button_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("TeacherAdd_SP", con);                                                            //whatever value you are wrting in textbox  is given to the parameter and that parameter is attached 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@teacher_id", Teacher_id_textbox.Text);                                                 //in the stored procure for inserting the values and solving the sql query
            cmd.Parameters.AddWithValue("@gender", gender_textbox.Text);
            cmd.Parameters.AddWithValue("@teacher_join_date", joindate_textbox.Text);
            cmd.Parameters.AddWithValue("@teacher_phone_no", Phone_numbertextbox.Text);
            cmd.Parameters.AddWithValue("@te_email", email_textbox.Text);
            cmd.Parameters.AddWithValue("@teacher_name", nametextbox.Text);


            con.Open();
            try
            {
                                                                                                    //for executing the commands
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("<<<Invalid SQL Operation>>>:\n" + ex);

            }
            con.Close();

            refresh_DataGridView();                                                              //calls the function which ultimately changes the data set
        }

        private void delete_button_Click_1(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("teacherdelete_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;                                                  //cmd is the command object
                                                                                                                //command type is stored procedure
                cmd.Parameters.AddWithValue("@teacher_id", Teacher_id_textbox.Text);



                con.Open();
                try
                {

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

        private void update_button_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("UpdateTeacher_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@teacher_id", Teacher_id_textbox.Text);                 //in the stored procure for inserting the values and solving the sql query
            cmd.Parameters.AddWithValue("@gender", gender_textbox.Text);
            cmd.Parameters.AddWithValue("@teacher_join_date", joindate_textbox.Text);
            cmd.Parameters.AddWithValue("@teacher_phone_no", long.Parse(Phone_numbertextbox.Text));
            cmd.Parameters.AddWithValue("@te_email", email_textbox.Text);
            cmd.Parameters.AddWithValue("@teacher_name", nametextbox.Text);


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



