//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab6_WCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Note
    {
        public int id { get; set; }
        public string subject { get; set; }
        public Nullable<int> note1 { get; set; }
        public Nullable<int> studentId { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
