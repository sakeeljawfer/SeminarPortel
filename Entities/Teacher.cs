using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarPortel.Entities
{
    public class Teacher
    {
        public int Id { get; set; }

        public string TecherName { get; set; }

        public string Description { get; set; }

        public string Mail { get; set; }

        public string Gender { get; set; }

        public string Qualification { get; set; }

        public string School { get; set; }

        public string SeminarCount { get; set; }
        
        public double FeePerSeminar { get; set; }

        public int Hours { get; set; }
        
        
        
        

    }
}