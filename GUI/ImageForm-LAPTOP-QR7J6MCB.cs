using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// ImageForm - This class is responsible for getting user input and displaying output
    /// 
    /// Author - Bartek Siwak
    /// Date/Version - 03/11/22 0.1
    /// </summary>
    public partial class ImageForm : Form
    {
        // DECLARE a variable to hold the an index value 

        public ImageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// NextImage - This method is responsible for increasing the index of a collection
        /// and redisplay the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextImage(object sender, EventArgs e)
        {
            // INCREASE the index 

            // 
        }

        /// <summary>
        /// PreviousImage - This method is responsible for decreasing the index of a collection
        /// and redisplay the image 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousImage(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Browse - This method will open the windows explorer for the user to add a new image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Browse(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ExitButton - This method will use the controller quit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton(object sender, EventArgs e)
        {

        }
    }
}
