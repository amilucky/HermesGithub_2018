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
    
    public partial class ProductsPrice
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public System.DateTime date_from { get; set; }
        public System.DateTime date_to { get; set; }
        public int currency_id { get; set; }
        public double gsv { get; set; }
        public double pc { get; set; }
        public double cc { get; set; }
    
        public virtual Currency Currency { get; set; }
        public virtual Product Product { get; set; }
    }
}
