//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lopushok
{
    using System;
    using System.Collections.Generic;
    
    public partial class Материал
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Материал()
        {
            this.Продукт = new HashSet<Продукт>();
            this.Продукция = new HashSet<Продукция>();
        }
    
        public int ID { get; set; }
        public string Наименование { get; set; }
        public string Тип_материала { get; set; }
        public Nullable<int> Количество_в_упаковке { get; set; }
        public string Единица_измерения { get; set; }
        public Nullable<int> Количество_на_складе { get; set; }
        public Nullable<int> Минимальное_количество { get; set; }
        public Nullable<decimal> Цена { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Продукт> Продукт { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Продукция> Продукция { get; set; }
    }
}
