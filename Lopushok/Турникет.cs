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
    
    public partial class Турникет
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Турникет()
        {
            this.Сотрудник = new HashSet<Сотрудник>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> Время_входа { get; set; }
        public Nullable<System.DateTime> Время_выхода { get; set; }
        public Nullable<int> ID_сотрудника { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудник> Сотрудник { get; set; }
    }
}
