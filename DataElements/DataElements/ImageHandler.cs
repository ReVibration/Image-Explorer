using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DataElements
{
    /// <summary>
    /// ImageHandler - This class will be resposible for creating images from path file names
    /// 
    /// Author - Bartek Siwak
    /// Date/Version - 03/11/22 0.1
    /// </summary>
    public class ImageHandler : IDisposable, IImageHandler
    {
        // DECLARE an image to hold the image being loaded
        Image _image;

        /// <summary>
        /// LoadImage - This method will be responsible for load an image and returing it
        /// </summary>
        /// <param name="pFileNamePath"> This is the file path name for the image </param>
        public Image LoadImage(string pFileNamePath)
        {
            try
            {
                // DECLARE & ASSIGN an image local variable by using the pFileNamePath
                _image = Bitmap.FromFile(Path.GetFullPath(pFileNamePath));
            }
            catch (FileNotFoundException e)
            {
                // THROW a file invalid file exception with a message
                throw new InvalidFileException("File Doesn't Exist");
            }
            // RETURN the image 
            return _image;
        }

        /// <summary>
        /// Dispose - This method will be responsible for disposing the class to dispose of the image
        /// </summary>
        public void Dispose()
        {
            // DISPOSE of the class disposing of the image
            this.Dispose();
        }

    }
}
