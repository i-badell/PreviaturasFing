using AutoMapper;
using PreviaturasFing.Application.Dtos;
using PreviaturasFing.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviaturasFing.Application.Profiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<Subject, SubjectDto>();
        }
    }
}
