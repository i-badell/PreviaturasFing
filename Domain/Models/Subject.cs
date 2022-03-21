using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviaturasFing.Domain.Models
{
    public class Subject : ModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool EvenSemester { get; set; }
        public bool OddSemester { get; set; }
        public SubjectGroup Group { get; set; }
        public int GroupId { get; set; }
        public SubjectSubGroup SubGroup { get; set; }
        public int SubGroupId { get; set; }
    }
}
