using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviaturasFing.Application.Dtos
{
    public class SubjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool EvenSemester { get; set; }
        public bool OddSemester { get; set; }
        public SubjectGroupDto Group { get; set; }
        public SubjectSubGroupDto SubGroup { get; set; }
        
    }
}
