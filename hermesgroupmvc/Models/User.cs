//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hermesgroupmvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int usergroup_id { get; set; }
        public string mail { get; set; }
        public bool customer_service_notification { get; set; }
        public bool logistic_notification { get; set; }
        public bool management_notification { get; set; }
        public bool admin_notofication { get; set; }
    
        public virtual UserGroup UserGroup { get; set; }
    }
}
