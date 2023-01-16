using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataElements
{
    public interface IImageHandler
    {
        /// <summary>
        /// LoadImage - This method will be responsible for load an image and returing it
        /// </summary>
        /// <param name="pImagePath">This is the file path name for the image</param>
        /// <returns></returns>
        Image LoadImage(string pImagePath);
        
    }
}
