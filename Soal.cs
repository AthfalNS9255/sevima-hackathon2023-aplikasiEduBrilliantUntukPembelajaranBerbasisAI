//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduBrilliant
{
    using System;
    using System.Collections.Generic;
    
    public partial class Soal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Soal()
        {
            this.Scores = new HashSet<Score>();
        }
    
        public int ID { get; set; }
        public string Nama { get; set; }
        public int KelasID { get; set; }
        public int Waktu { get; set; }
        public int Nomor { get; set; }
        public string Jawaban { get; set; }
        public int Score { get; set; }
    
        public virtual Kela Kela { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Score> Scores { get; set; }
    }
}
