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
    
    public partial class warehouse_operations
    {
        public int id { get; set; }
        public int id_warehouse { get; set; }
        public float QuantityDelta { get; set; }
        public System.DateTime ChangeTime { get; set; }
    
        public virtual warehouse warehouse { get; set; }
    }
}
