using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarPortel.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        public string SubjectName { get; set; }

        public Teacher Teachers { get; set; }
        
        public int TechersId { get; set; }

    }
}