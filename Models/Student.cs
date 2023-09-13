using System;
using System.Collections.Generic;

namespace WebApplicationMVC.Models
{
    public partial class Student
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public int? ClassId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual Class? Class { get; set; }
    }
}
