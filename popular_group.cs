//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Events
{
    using System;
    using System.Collections.Generic;
    
    public partial class popular_group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public popular_group()
        {
            this.popular_messages = new HashSet<popular_messages>();
        }
    
        public int Id_popular_group { get; set; }
        public string Content { get; set; }
        public int Id_popular_group_event { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<popular_messages> popular_messages { get; set; }
    }
}
