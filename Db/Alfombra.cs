//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RugFactory.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alfombra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alfombra()
        {
            this.Is_EnFabrica = true;
            this.Is_Lavado = false;
            this.Prefix_Albaran = "TR";
            this.FalloAlfombras = new HashSet<FalloAlfombra>();
            this.Albarans = new HashSet<Albaran>();
            this.Lavados = new HashSet<Lavado>();
        }
    
        public int Alfombra_Id { get; set; }
        public short Ancho { get; set; }
        public short Largo { get; set; }
        public string Calidad { get; set; }
        public int ClienteCliente_Id { get; set; }
        public bool Is_EnFabrica { get; set; }
        public Nullable<bool> Is_Lavado { get; set; }
        public string Prefix_Albaran { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FalloAlfombra> FalloAlfombras { get; set; }
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Albaran> Albarans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lavado> Lavados { get; set; }
    }
}
