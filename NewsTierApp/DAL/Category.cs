//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Newsses = new HashSet<Newss>();
        }
    
        public int Id { get; set; }
        public string Ctgr { get; set; }
    
        public virtual ICollection<Newss> Newsses { get; set; }
    }
}
