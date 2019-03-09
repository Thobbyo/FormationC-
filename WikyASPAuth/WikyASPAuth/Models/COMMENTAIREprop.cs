using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WikyASPAuth.Models
{

    [MetadataType(typeof(CommentaireMetaData))]
    public partial class COMMENTAIRE
    {
    }

    public class CommentaireMetaData
    {
        public int id { get; set; }
        [Required]
        public string auteur { get; set; }
        [Required]
        public string contenue { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> article { get; set; }
    }
}