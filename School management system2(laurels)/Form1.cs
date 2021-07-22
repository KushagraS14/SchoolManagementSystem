using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;                                                    //IMPORTING PACKAGES and LIBRARIES
using System.Text;
using System.Threading.Tasks;                
using System.Windows.Forms;
using System.Data.SqlClient;                                                               

//we are using csharp for front end where user will see only front end .We use csharp because the language is easy and powerful plus way of programming is 
//object-oriented and is easy  and elegant.For backend we use sqlite which is used for databases and it is hidden by the user .Databases must have the 
//connectivity with the frontend.

//Solution Explorer contains the whole software project .For templetes we use Windows Forms App for making basic web application where we can manipulate the data.
//Web application requires authentication too.
//Panel is a componet just like Windows form app component which is used to hold all the other individual component.

namespace School_management_system2_laurels_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      //path where the project is being stored or path of database                                                 
      //then only sequence will be excaped off use double backslash(//).


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");  
                                                                                                      //con is the connection to the database
        SqlCommand cmd;                                              //We have sql commands
        SqlDataReader  dr;                                           //InOrder to read the data we need datareader

        private String getUserName()
        {
            //fetch data from the database
            con.Open();
            String syntax = "Select Value From system1Table where Property ='UserName'";
            cmd = new SqlCommand(syntax,con);                                //new  is used to create objects and invoke a constructor and it is used for memory allocation
            dr = cmd.ExecuteReader();                //date reader takes the virtual copy of the table and  keeps it temporary available                                                                                                     //where the pointer variable is pointing to the object
            dr.Read();                               //after this statement is executed data reader is filled with values.
            String temp= dr[0].ToString() ;          //toString is used to convert integer value to string value and dr[0] represents the column. 
            con.Close();
            return temp;

        }

        private String getPassword()
        {
            //fetch data from the database
            con.Open();                                                               
            String syntax = "Select Value From system1Table where Property ='Password'";
            cmd = new SqlCommand(syntax, con);                           //new  is used to create objects and invoke a constructor and it is used for memory allocation
            dr = cmd.ExecuteReader();                                    //date reader takes the virtual copy of the table and  keeps it temporary available 
            dr.Read();                                                     //after this statement is executed data reader is filled with values.
            String temp1 = dr[0].ToString();                               //toString is used to convert integer value to string value and dr[0] represents the column. 
            con.Close();
            return temp1;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll_2(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String Uname= getUserName(), Upass= getPassword(), name, pass;
            name = textBox3.Text;
            pass = textBox1.Text;                                               //on pressing the login button ,the following function will be called,//first we declare two string variables
                                                                                //uname and upass ,user will first see what text we have witten in the texbox and pass that text into variables
                                                                                //known as name and pass will ultimately store the text 


            if (name.Equals(Uname) && pass.Equals(Upass))                  //compare two variables name and pass with uname and upass.
            {
                //Log in
                label5.Hide();                                      //label5 displaying credentials entered is wrong is being disabled as default and is hidden
                MessageBox.Show("Log in Success");
                APPBody obj = new APPBody();                         //created object for appbody and and then hide the login form and displayed the object
                this.Hide();
                obj.Show();                                                  

            }
            else
            {
                //don't login

                label5.Show();


            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll_3(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
