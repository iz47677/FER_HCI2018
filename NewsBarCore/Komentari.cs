//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsBarCore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Komentari
    {
        public int Id { get; set; }
        public int News { get; set; }
        public Nullable<int> Osoba { get; set; }
        public string Tekst { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Edited { get; set; }
    
        public virtual Vijesti Vijesti { get; set; }
        public virtual Korisnici Korisnici { get; set; }
    }
}
