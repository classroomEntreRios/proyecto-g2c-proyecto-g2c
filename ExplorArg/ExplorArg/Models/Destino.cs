//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExplorArg.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Destino
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Destino()
        {
            this.Atracciones = new HashSet<Atracciones>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Id_destino { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atracciones> Atracciones { get; set; }
    }
}
