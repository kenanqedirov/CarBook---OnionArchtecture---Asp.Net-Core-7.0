using Application.Features.CQRS.Results.AboutResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        public readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(a => new GetAboutQueryResult
            {
                AboutId = a.AboutId,
                Description = a.Description,
                ImageUrl = a.ImageUrl,
                Title = a.Title
            }).ToList();
        }
    }
}
