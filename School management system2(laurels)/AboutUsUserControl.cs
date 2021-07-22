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
    public partial class AboutUsUserControl : UserControl
    {
        private static AboutUsUserControl _instance;

        public static AboutUsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AboutUsUserControl();                               //instance is a variable and it is being created by calling the constructor if it is null 
                                                                                        // and then returning the constructor 
                }
                return _instance;

            }


        }
       public AboutUsUserControl()
        {
            InitializeComponent();
        }
    }
}
