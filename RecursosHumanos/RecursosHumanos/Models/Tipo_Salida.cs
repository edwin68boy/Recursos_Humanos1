//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecursosHumanos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_Salida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Salida()
        {
            this.Salida_Empleados = new HashSet<Salida_Empleados>();
        }
    
        public int Id { get; set; }
        public string Tipo_Salida1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Empleados> Salida_Empleados { get; set; }
    }
}
