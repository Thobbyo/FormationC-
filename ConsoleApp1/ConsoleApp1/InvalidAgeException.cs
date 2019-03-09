using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InvalidAgeException : Exception
    {
        // public string Message { get; } = "L’âge doit être entre 18 et 26";

        public InvalidAgeException(string mess = "L’âge doit être entre 18 et 26") : base (mess) {
            // Message = mess;
        }
    }
}
