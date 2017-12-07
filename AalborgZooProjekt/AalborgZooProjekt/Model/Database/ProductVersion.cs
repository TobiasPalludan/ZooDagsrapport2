//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AalborgZooProjekt.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductVersion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductVersion()
        {
            this.OrderLines = new HashSet<OrderLine>();
            this.Unit = new HashSet<Unit>();
        }
    
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Supplier { get; set; }
        public string CreatedByID { get; set; }
        public string DateCreated { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
    
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unit> Unit { get; set; }
    }
}
