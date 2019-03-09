using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InvalidNoteException : Exception
    {
        // public string Message { get; } = "La note doit être entre 0 et 20";

        public InvalidNoteException(string mess = "La note doit être entre 0 et 20") : base(mess) {
            // Message = mess;
        }
    }
}
