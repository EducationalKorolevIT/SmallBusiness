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
    
    public partial class TablePrice
    {
        public int id { get; set; }
        public int id_product { get; set; }
        public double Price { get; set; }
    
        public virtual TableProduct TableProduct { get; set; }
    }
}
