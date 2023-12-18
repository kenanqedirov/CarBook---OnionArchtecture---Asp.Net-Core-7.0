using Application.Features.CQRS.Results.BannerResult;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(a => new GetBannerQueryResult
            {
                BannerId = a.BannerId,
                Description = a.Description,
                Title = a.Title,
                VideoDescription = a.VideoDescription,
                VideoUrl = a.VideoUrl
            }).ToList();
        }
    }
}
