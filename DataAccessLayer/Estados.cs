//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estados
    {
        public Estados()
        {
            this.Historial = new HashSet<Historial>();
            this.libros = new HashSet<libros>();
        }
    
        public int Id_Estado { get; set; }
        public string Nom_Estado { get; set; }
    
        public virtual ICollection<Historial> Historial { get; set; }
        public virtual ICollection<libros> libros { get; set; }
    }
}