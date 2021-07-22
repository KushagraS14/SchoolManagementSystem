using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management_system2_laurels_
{
    public partial class RegistrationUserControl : UserControl
    {

        private static RegistrationUserControl _instance;

        public static RegistrationUserControl Instance                 //Instance  is capital letter because it is the public instance
        { 
           get 
            {
              if(_instance==null )
                 {
                   _instance= new RegistrationUserControl();            //instance is a variable and it is being created by calling the constructor if it is null 
                                                                        // and then returning the constructor 
                }
            return _instance; 

            }


        }
        public RegistrationUserControl()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string name, email, date, gender;
            long phone_num, age, registration_id;
            name = name_textbox.Text;
            email = email2_textbox.Text;
            date = date_textbox.Text;
            age = long.Parse(age_textbox.Text);
            phone_num = long.Parse(emailtextbox.Text);                                                              //takes in the information for registration and displays in the message box after clicking on submit button
            registration_id = long.Parse(registration_textbox.Text);
            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;

            }
            MessageBox.Show("name:" + name + "\nemail:" + email + "\nphone_num:" + phone_num + "\nage:" + age + "\nGender:" + gender + "\nRegistration_id:" + registration_id+"\nSUBMITTED SUCCESSFULLY");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
