using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WikyASP.Models
{

    [MetadataType(typeof(ArticleMetaData))]
    public partial class ARTICLE
    {
    }

    public class ArticleMetaData
    {
        public int id { get; set; }
        [Required]
        public string theme { get; set; }
        [Required]
        public string auteur { get; set; }
        [Required]
        public string contenue { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> date { get; set; }
        public string image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENTAIRE> COMMENTAIRE { get; set; }
    }
}