//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fitness_Club_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserLog()
        {
            this.UserInformations = new HashSet<UserInformation>();
        }
    
        public string Login { get; set; }
        public string Password { get; set; }
        public int loginID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInformation> UserInformations { get; set; }
    }
}