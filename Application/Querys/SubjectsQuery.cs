using PreviaturasFing.Application.Dtos;
using MediatR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace PreviaturasFing.Application.Querys
{
    public class SubjectsQuery : IRequest<SubjectDto>
    {
        public SubjectsQuery()
        {
        }

        [JsonConstructor]
        public SubjectsQuery(int id)
        {
            Id = id;
        }


        [JsonProperty("id")]
        [Required]
        public int Id { get; set; }
    }
}
