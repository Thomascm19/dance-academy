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
    using System;
    using System.Collections.Generic;
    
    public partial class Calendario
    {
        public int Id_Baile { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Id_Clase { get; set; }
    
        public virtual Clase Clase { get; set; }
    }
}