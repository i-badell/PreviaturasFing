namespace PreviaturasFing.Domain.Models
{
    public class SubjectSubGroup : ModelBase 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
    }
}