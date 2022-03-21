using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using PreviaturasFing.Application.Dtos;
using PreviaturasFing.Application.Querys;
using PreviaturasFing.Domain.Interfaces;
using PreviaturasFing.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviaturasFing.Application.Services.Handlers
{
    public class SubjectQueryHandler : IRequestHandler<SubjectsQuery, SubjectDto>
    {
        private readonly ILogger<SubjectQueryHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IRepository<Subject> _repository;

        public SubjectQueryHandler(ILogger<SubjectQueryHandler> logger, IMapper mapper, IRepository<Subject> repository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task<SubjectDto> Handle(SubjectsQuery request, CancellationToken cancellationToken)
        {
            var response = new List<Subject>();

            if (request.Id == null)
            {
                response.Add(await _repository.GetAsync(x => x.Id == request.Id));
            }
            else
            {
                response = (await _repository.GetListAsync(x => true)).ToList();
            }

            return _mapper.Map<SubjectDto>(response);
        }
    }
}
