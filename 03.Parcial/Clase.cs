//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _03.Parcial
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Clase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clase()
        {
            this.Calendario = new HashSet<Calendario>();
        }
    
        public int Id_Clase { get; set; }
        public string Descripcion_Baile { get; set; }
        public Nullable<int> Codigo_Cliente { get; set; }
        public string Nombre_Baile { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calendario> Calendario { get; set; }
        public virtual Cliente Cliente { get; set; }

        [JsonIgnore]
        public virtual Usuario usuario { get; set; }
    }
}