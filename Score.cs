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
    
    public partial class Score
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int SoalID { get; set; }
        public decimal Score1 { get; set; }
    
        public virtual Soal Soal { get; set; }
        public virtual User User { get; set; }
    }
}