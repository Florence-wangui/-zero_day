//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCHOOL1_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROFESSOR
    {
        public PROFESSOR()
        {
            this.CLASSes = new HashSet<CLASS>();
        }
    
        public int PROF_ID { get; set; }
        public string PROF_LNAME { get; set; }
        public string PROF_FNAME { get; set; }
    
        public virtual ICollection<CLASS> CLASSes { get; set; }
    }
}
