//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace logininfo
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERDETAIL
    {
        public int DETID { get; set; }
        public int USERID { get; set; }
        public string FULLNAME { get; set; }
        public int AGE { get; set; }
        public string CITY { get; set; }
    
        public virtual LOGININFO LOGININFO { get; set; }
    }
}
