namespace PreviaturasFing.Domain.Models
{
    public class SubjectGroup : ModelBase
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public Subject Subject { get; set; }
    }
}