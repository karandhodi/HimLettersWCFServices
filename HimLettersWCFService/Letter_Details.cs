//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HimLettersWCFService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Letter_Details
    {
        public int Id { get; set; }
        public string Deficient_Day_Range_Start { get; set; }
        public string Deficient_Day_Range_End { get; set; }
        public string Include_Documents { get; set; }
        public string Chart_On_Hold { get; set; }
        public string Physicians_To_Include { get; set; }
        public string Charts_To_Include { get; set; }
        public string Deficiencies_To_Include { get; set; }
        public string Include_Visits { get; set; }
    
        public virtual Letter_Type Letter_Type { get; set; }
    }
}
