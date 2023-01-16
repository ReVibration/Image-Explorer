using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataElements
{
    /// <summary>
    /// ImagePaths - This class is responsible for holding and controlling the paths for the images 
    /// 
    /// Author - Bartek Siwak
    /// Date/Version - 28/11/22 0.1
    /// </summary>
    public interface IImagePaths
    {
        /// <summary>
        /// GetCurrentPath - This method is responsible for getting the current path that is in the list taking an index
        /// </summary>
        /// <param name="pIndex"> This is the index that will be needed  </param>
        /// <returns></returns>
        string GetCurrentPath(int pIndex);

        /// <summary>
        /// GetLengthOfPaths - This method is responsible for getting the current length of the list
        /// </summary>
        /// <returns> The length of the array </returns>
        int GetLengthOfPaths();

        /// <summary>
        /// AddPath - This method is responsible for adding a new path to the list 
        /// </summary>
        /// <param name="pPath"> This is the path to be added </param>
        void AddPath(string pPath);
    }
}
