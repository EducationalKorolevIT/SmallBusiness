//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmallBusiness
{
    using System;
    using System.Collections.Generic;
    
    public partial class producttable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producttable()
        {
            this.warehouse = new HashSet<warehouse>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Article { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float UnitPerPrice { get; set; }
        public string UnitType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<warehouse> warehouse { get; set; }
    }
}
