using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataElements;

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

        //DECLARE an image handler to handle the images, call it _imgHand
        IImageHandler _imgHand;

        // DECLARE a image paths to hold the image paths, call it _imgPaths
        IImagePaths _imgPaths;

        //DECLARE an intger to hold the index, call it _index, assign it 0
        int _index = 0;

        //DECLARE a image to hold the current image, call it _img
        Image _img;

        // DECLARE a string a hold the path name of the file to be added, call it _fileSelected
        string _fileSelected;


        public ImageForm()
        {
            InitializeComponent();

            // ASSIGN the _imgHand to a new image handler 
            _imgHand = new ImageHandler();

            // ASSIGN the _imgPaths to a new image paths object
            _imgPaths = new ImagePaths();

            // LOAD the current image to show
            _img = _imgHand.LoadImage(_imgPaths.GetCurrentPath(_index));

            // ASSIGN the backgound image to the image loaded
            ImagePanel.BackgroundImage = _img;
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
            _index ++;

            // IF the index is more that the current length of the paths 
            if (_imgPaths.GetLengthOfPaths()-1 <= _index)
            {
                // ASSIGN the index to the last index of the paths 
                _index = _imgPaths.GetLengthOfPaths()-1;
            }


            // RUN the method to show the image
            _img = _imgHand.LoadImage(_imgPaths.GetCurrentPath(_index));
            // ASSIGN the background image to the image loaded
            ImagePanel.BackgroundImage = _img;
        }

        /// <summary>
        /// PreviousImage - This method is responsible for decreasing the index of a collection
        /// and redisplay the image 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousImage(object sender, EventArgs e)
        {
            // DECREASE the index
            _index --;
            
            // IF the index is less than 0
            if(_index < 0)
            {
                // ASSIGN the index to 0
                _index = 0;
            }
            // RUN the method to show the image 
            _img = _imgHand.LoadImage (_imgPaths.GetCurrentPath(_index));
            // ASSIGN the background imabe to the image loaded
            ImagePanel.BackgroundImage = _img;
        }

        /// <summary>
        /// Browse - This method will open the windows explorer for the user to add a new image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Browse(object sender, EventArgs e)
        {
            // RUN the windows browser to get the file path name for an image to be added 
            // CODE SNIPPET: Steve(2012) C# get explorer.exe to return a file path Accessed at https://stackoverflow.com/questions/12822337/c-sharp-get-explorer-exe-to-return-a-file-path [30/11/22]
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _fileSelected = openFileDialog1.FileName;
                }
            }
            // RUN the method to add an image
            _imgPaths.AddPath(_fileSelected);
        }
        /// <summary>
        /// ExitButton - This method will use the controller quit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton(object sender, EventArgs e)
        {
            // CLOSE the form
            Form.ActiveForm.Close();


        }
    }
}
