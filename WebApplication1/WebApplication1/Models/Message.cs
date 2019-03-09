using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Message
    {
        public string Emetteur { get; set; }
        public string Contenu { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}