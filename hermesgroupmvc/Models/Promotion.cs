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
    
    public partial class Promotion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Promotion()
        {
            this.PromotionsDetails = new HashSet<PromotionsDetail>();
        }
    
        public int id { get; set; }
        public int promostatus_id { get; set; }
        public System.DateTime shipment_from { get; set; }
        public System.DateTime shipment_to { get; set; }
        public System.DateTime active_from { get; set; }
        public System.DateTime active_to { get; set; }
        public string promo_name { get; set; }
        public int customer_id { get; set; }
        public System.DateTime edit_date { get; set; }
        public string note { get; set; }
        public double week1 { get; set; }
        public double week2 { get; set; }
        public double week3 { get; set; }
        public double week4 { get; set; }
        public double leaflet_fee { get; set; }
        public double secondaryplacement_fee { get; set; }
        public int promotype_id { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual PromotionsStatus PromotionsStatus { get; set; }
        public virtual PromotionsType PromotionsType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionsDetail> PromotionsDetails { get; set; }
    }
}
