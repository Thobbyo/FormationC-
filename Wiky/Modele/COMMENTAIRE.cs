//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modele
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMMENTAIRE
    {
        public int id { get; set; }
        public string auteur { get; set; }
        public string contenue { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> article { get; set; }
    
        public virtual ARTICLE ARTICLE1 { get; set; }
    }
}
