//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_Rusanova
{
    using System;
    using System.Collections.Generic;
    
    public partial class Гостиницы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Гостиницы()
        {
            this.Ведомость_продажей = new HashSet<Ведомость_продажей>();
        }
    
        public int Код_гостиницы { get; set; }
        public string Название { get; set; }
        public string Страна { get; set; }
        public string Город { get; set; }
        public string Адрес { get; set; }
        public Nullable<int> Количество_мест { get; set; }
        public string Тип_гостиницы { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ведомость_продажей> Ведомость_продажей { get; set; }
    }
}
