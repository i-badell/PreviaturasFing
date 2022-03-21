using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.MapperProfiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<Subject, SubjectDto>
        }
    }
}
