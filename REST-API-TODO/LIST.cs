//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace REST_API_TODO
{
    using System;
    using System.Collections.Generic;
    
    public partial class LIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIST()
        {
            this.TODOTASK = new HashSet<TODOTASK>();
        }
    
        public int LISTID { get; set; }
        public string LISTNAME { get; set; }
        public string LISTDESCRIPTION { get; set; }
        public int FK_USER_LIST { get; set; }
    
        public virtual USER USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TODOTASK> TODOTASK { get; set; }
    }
}
