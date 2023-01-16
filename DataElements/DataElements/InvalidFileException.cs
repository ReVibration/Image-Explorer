using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataElements
{
    /// <summary>
    /// InvalidFileException - This is the exception that is ran if a file doesn't exist
    /// </summary>
    internal class InvalidFileException : Exception
    {
        /// <summary>
        /// Constructor of the exception to be ran
        /// </summary>
        /// <param name="message"> This is the message to be displayed from the exception </param>
        public InvalidFileException(string message) : base(message) { }
    }
}
