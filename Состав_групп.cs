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
    
    public partial class Состав_групп
    {
        public int Код_состава_группы { get; set; }
        public int Код_группы { get; set; }
        public int Код_туриста { get; set; }
        public int Код_тура { get; set; }
        public Nullable<System.DateTime> Дата_продажи { get; set; }
        public Nullable<decimal> Цена_билета { get; set; }
    
        public virtual Туристическая_группа Туристическая_группа { get; set; }
        public virtual Туристы Туристы { get; set; }
        public virtual Туры Туры { get; set; }
    }
}
