//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aspfirstapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Course
    {
        public int EnrollID { get; set; }
        public Nullable<decimal> Grade { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
