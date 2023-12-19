using Application.Features.CQRS.Results.BrendResults;
using Application.Features.CQRS.Results.ContactResult;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetContactQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(a => new GetContactQueryResult
            {
                Name = a.Name,
                ContactId = a.ContactId,
                Message = a.Message,
                Email = a.Email,
                Subject = a.Subject,
                SendDate = a.SendDate
            }).ToList();
        }
    }
}
