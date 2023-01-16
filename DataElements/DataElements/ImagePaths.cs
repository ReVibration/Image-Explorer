using System;
using System.Collections.Generic;
using System.IO;
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
    public class ImagePaths : IImagePaths
    {
        // DECLARE a list of strings of image path names, call it _pathNames, assign an example image path
        List<string> _pathNames = new List<string> {Path.GetFullPath("..\\..\\..\\OrangeFish.png"),Path.GetFullPath("..\\..\\..\\SeaHorse.png")};

        /// <summary>
        /// GetCurrentPath - This method is responsible for getting the current path that is in the list taking an index
        /// </summary>
        /// <param name="pIndex"> This is the index that will be needed  </param>
        /// <returns> That current string at that index </returns>
        public string GetCurrentPath(int pIndex)
        {
            //RETURN the string that is taken from the index 
            return _pathNames[pIndex];
        }

        /// <summary>
        /// GetLengthOfPaths - This method is responsible for getting the current length of the list
        /// </summary>
        /// <returns> The length of the array </returns>
        public int GetLengthOfPaths() { return _pathNames.Count; }

        /// <summary>
        /// AddPath - This method is responsible for adding a new path to the list 
        /// </summary>
        /// <param name="pPath"> This is the path to be added </param>
        public void AddPath(string pPath) { _pathNames.Add(pPath); }

    }
}
