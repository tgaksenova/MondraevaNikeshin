//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ТРПО4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nas_pynkt2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nas_pynkt2()
        {
            this.Ylitsa2 = new HashSet<Ylitsa2>();
        }
    
        public int ID { get; set; }
        public string Naimenovanie { get; set; }
        public string Vid_nas_pynkta { get; set; }
        public Nullable<int> ID_Oblast_2 { get; set; }
        public string Foto { get; set; }
    
        public virtual Oblast_2 Oblast_2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ylitsa2> Ylitsa2 { get; set; }
    }
}
