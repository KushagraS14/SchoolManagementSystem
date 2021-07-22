using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace School_management_system2_laurels_
{
    public partial class APPBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;                           //Intialising certain variables for mouse movements and mouse captures
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    



        public APPBody()
        {
            InitializeComponent();
            ///Initialisations for slidding pannel
            isSlidingPannelExpanded = true;                                 //following default conditions must hold
            expandSlidingPannelGUI();
        }
        private void APPBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;                                    //opacity determines how tranparent are forms is. 
            Log_In_timer.Start();
        }



        private void Log_In_timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                                                                            //incrementing the appbody opacity by 0.025 till it reaches 1
                this.Opacity += 0.025;
            }
            else
            {

                Log_In_timer.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();                                           //Hides the current Appbody and shows the login form
            obj.Show();
        }

        private void Logoffbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);                                           //exits from the appbody
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;                             //this code make sure tha form is minimised to bottom

        }

        private void APPBody_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Titlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void __Click(object sender, EventArgs e)
        {

        }

        public void expandSlidingPannelGUI()
        {
            //gui  adjustments for expanding
            registration_button.Text = "REGISTRATION";
            subject_button.Text = "SUBJECT";
            student_button.Text = "STUDENT";
            exams_button.Text = "EXAMS";
            results_button.Text = "RESULTS";
            class_button.Text = "CLASS";
            teacher_button.Text = "TEACHER";
            ABOUTUS.Text = "ABOUT US";
               
            Slididngpanel_toggle_button.Image = Properties.Resources.leftarrow2;
            registration_button.Image = null;
            subject_button.Image = null;
            student_button.Image = null;
            exams_button.Image = null;
            results_button.Image = null;
            class_button.Image = null;
            teacher_button.Image = null;
            ABOUTUS.Image = null;
        }
        public void retractSlidingPannelGUI()
        {
            //gui  adjustments for retracting
            registration_button.Text = " ";
            subject_button.Text = " ";
            student_button.Text = " ";
            exams_button.Text = " ";
            results_button.Text = " ";
            class_button.Text = " ";
            teacher_button.Text = " ";
            ABOUTUS.Text = " ";

            Slididngpanel_toggle_button.Image = Properties.Resources.right_arrow3123;
            registration_button.Image = Properties.Resources.registration2;
            subject_button.Image = Properties.Resources.Literature_21png;
            student_button.Image = Properties.Resources.Boy_child_kid_school_boy_student_;
            exams_button.Image = Properties.Resources.OIP3;
            results_button.Image = Properties.Resources.results;
            class_button.Image = Properties.Resources.class3;
            teacher_button.Image = Properties.Resources.R8cb6ae427fda50bcfe74f886bd540393;
            ABOUTUS.Image = Properties.Resources.ABOUT_US2;
        }
      
        //SlidingPanel code starts from here

        bool isSlidingPannelExpanded;                    //variable to keep track whether the sliding panel expanded to retracted returns true or false
        const int MaxSliderWidth=300;                     //we use const in order to initialise the variable and keep it constant which can't be changed once it is initialised 
                                                           //300 is the length of slidingtogglepanel 
        const int MinSliderWidth=100;                      //100 is the set length of slidingtogglepanel
        private void SlidingPanel_Togglebutton_Paint(object sender, PaintEventArgs e)
        { 
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                // retract panel

                retractSlidingPannelGUI();                                 //calling of function which disables the text and enables the image
            }
            SliddingPanel_Timer.Start(); 

        }

        private void SliddingPanel_Timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                //retract pannel

                SlidingPanel.Width -= 30;                                   
                if (SlidingPanel.Width <= MinSliderWidth)
                {
                    //stop retract
                    isSlidingPannelExpanded = false;                  //the  boolean variable must become false 
                    SliddingPanel_Timer.Stop();
                    this.Refresh();
                }
            }

            else
            {

                ///// expand the pannel                  
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width>= MaxSliderWidth)                                                           
                {
                    //stop expanding
                    isSlidingPannelExpanded = true;             //the boolean variable must  become true
                    SliddingPanel_Timer.Stop();                 
                    expandSlidingPannelGUI();                  // Calling of function which enable the text and disables the image  
                    this.Refresh();
                }

            }
        }
        //user control will be loaded up on panel named content panel

        private void registration_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(RegistrationUserControl.Instance))              //check whether the controls of content panel contains the user control or not
            {                                                                                  
                contentpanel.Controls.Add(RegistrationUserControl.Instance);                       //if not present then add the usercontol instance
                RegistrationUserControl.Instance.Dock = DockStyle.Fill;                            //fill in the dock of content pannel
                RegistrationUserControl.Instance.BringToFront();                                  //this is the method to bring my instance to front
            }
            else
            {
                RegistrationUserControl.Instance.BringToFront();                   //IF IT ALREADY CONTAINS THE CONTENT PANNEL THEN JUST BRING IT TO FRONT


            }
        }
          

        //USER CONTROLS ARE ACTUALLY CLASSES WHICH IS BROUGHT TO FRONT IN THE MAIN CLASSE.FIRST IT WILL CHECK WHETHER THEY OVERLAP THE MAIN CLASS OR NOT IF NOT THEN BRING 
        //THE USER CONTOL CLASS TO FRONT USING ADD FUNCTION .


        private void button1_Click_2(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(AboutUsUserControl.Instance))
            {
                contentpanel.Controls.Add(AboutUsUserControl.Instance);
                AboutUsUserControl.Instance.Dock = DockStyle.Fill;
                AboutUsUserControl.Instance.BringToFront();                                         //check whether the controls of content panel contains the user control or not
            }                                                                                        //if not present then add the usercontol instance
            else                                                                                     //fill in the dock of content pannel
            {                                                                                         //this is the method to bring my instance to front
                AboutUsUserControl.Instance.BringToFront();


            }                                                                          //IF IT ALREADY CONTAINS THE CONTENT PANNEL THEN JUST BRING IT TO FRONT

        }

        private void student_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(StudentUserControl.Instance))
            {
                contentpanel.Controls.Add(StudentUserControl.Instance);                                      //check whether the controls of content panel contains the user control or not
                StudentUserControl.Instance.Dock = DockStyle.Fill;                                              //if not present then add the usercontol instance
                StudentUserControl.Instance.BringToFront();                                                       //fill in the dock of content pannel
            }                                                                                                      //this is the method to bring my instance to front
            else
            {
                StudentUserControl.Instance.BringToFront();                                                //IF IT ALREADY CONTAINS THE CONTENT PANNEL THEN JUST BRING IT TO FRONT



            }
        }

        private void subject_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(SubjectUserControl.Instance))                                     //check whether the controls of content panel contains the user control or not
            {
                contentpanel.Controls.Add(SubjectUserControl.Instance);                                           //if not present then add the usercontol instance
                SubjectUserControl.Instance.Dock = DockStyle.Fill;
                SubjectUserControl.Instance.BringToFront();                                                        //fill in the dock of content pannel
            }                                                                                                         //this is the method to bring my instance to front
            else
            {
                SubjectUserControl.Instance.BringToFront();
                                                                                                                 //IF IT ALREADY CONTAINS THE CONTENT PANNEL THEN JUST BRING IT TO FRONT

            }
        }

        private void exams_button_Click(object sender, EventArgs e)
        {                                                                                               //check whether the controls of content panel contains the user control or not
            if (!contentpanel.Controls.Contains(ExamsUserControl.Instance))
            {                                                                                             //if not present then add the usercontol instance
                contentpanel.Controls.Add(ExamsUserControl.Instance);
                ExamsUserControl.Instance.Dock = DockStyle.Fill;
                ExamsUserControl.Instance.BringToFront();                                                  //fill in the dock of content pannel
            }                                                                                                 //this is the method to bring my instance to front
            else                                                                                               //IF IT ALREADY CONTAINS THE CONTENT PANNEL THEN JUST BRING IT TO FRONT
            {

            }
            {
                ExamsUserControl.Instance.BringToFront();


            }

        }

        private void results_button_Click(object sender, EventArgs e)                                               //check whether the controls of content panel contains the user control or not
        {
            if (!contentpanel.Controls.Contains(ResultsUserControl.Instance))                                       //if not present then add the usercontol instance
            {
                contentpanel.Controls.Add(ResultsUserControl.Instance);                                             //fill in the dock of content pannel
                ResultsUserControl.Instance.Dock = DockStyle.Fill;
                ResultsUserControl.Instance.BringToFront();                                                              //this is the method to bring my instance to front
            }
            else                                                                                                          //IF IT ALREADY CONTAINS THE CONTENT PANNEL THEN JUST BRING IT TO FRONT
            {
                ResultsUserControl.Instance.BringToFront();


            }
        }

        private void teacher_button_Click(object sender, EventArgs e)                                                   //check whether the controls of content panel contains the user control or not
        {                                                                                                  
            if (!contentpanel.Controls.Contains(TeacherUserControl.Instance))                                            //if not present then add the usercontol instance
            {
                contentpanel.Controls.Add(TeacherUserControl.Instance);                                                    //fill in the dock of content pannel
                TeacherUserControl.Instance.Dock = DockStyle.Fill;
                TeacherUserControl.Instance.BringToFront();                                                                    //this is the method to bring my instance to front
            }
            else
            {                                                                                                                      //IF IT ALREADY CONTAINS THE CONTENT PANNEL THEN JUST BRING IT TO FRONT
                TeacherUserControl.Instance.BringToFront();


            }
        }

        private void class_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(ClassUserControl.Instance))                                                           //check whether the controls of content panel contains the user control or not
            {
                contentpanel.Controls.Add(ClassUserControl.Instance);
                ClassUserControl.Instance.Dock = DockStyle.Fill;                                                                           //if not present then add the usercontol instance
                ClassUserControl.Instance.BringToFront();                                                                                  //fill in the dock of content pannel
            }                                                                                                                               //this is the method to bring my instance to front
            else
            {                                                                                                                                 //IF IT ALREADY CONTAINS THE CONTENT PANNEL THEN JUST BRING IT TO FRONT
                ClassUserControl.Instance.BringToFront();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
  }
         
        
    

