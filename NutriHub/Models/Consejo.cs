//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NutriHub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consejo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Consejo()
        {
            this.recibirConsejo = new HashSet<recibirConsejo>();
        }
    
        public decimal idConsejo { get; set; }
        public string tituloConsejo { get; set; }
        public string mensajeConsejo { get; set; }
        public string referencia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recibirConsejo> recibirConsejo { get; set; }
    }
}