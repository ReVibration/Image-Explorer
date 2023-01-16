using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace Controller
{
    /// <summary>
    /// Controller - This top level class will execute the program and control the flow
    /// 
    /// Author - Bartek Siwak
    /// Date/Version 03/11/22 0.1
    /// </summary>
    public class Controller
    {

        /// <summary>
        /// CONSTRUCTOR for the controller class
        /// </summary>

        public Controller()
        {

            // RUN to create a new image form and start the program
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ImageForm());
        }

    }
}
