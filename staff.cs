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
    
    public partial class staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public staff()
        {
            this.message_processing = new HashSet<message_processing>();
            this.staff_event = new HashSet<staff_event>();
        }
    
        public int Id_satff { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string patronymic { get; set; }
        public string Log { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public Nullable<int> Id_staff_type_staff { get; set; }
        public Nullable<bool> online { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<message_processing> message_processing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<staff_event> staff_event { get; set; }
        public virtual type_staff type_staff { get; set; }
    }
}