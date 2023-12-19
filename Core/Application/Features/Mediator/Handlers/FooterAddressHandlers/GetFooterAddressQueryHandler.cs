using Application.Features.Mediator.Queries.FooterAddressQueries;
using Application.Features.Mediator.Results.FooterAddressResults;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressByIdQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressByIdQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(a=> new GetFooterAddressByIdQueryResult
            {
                Address = a.Address,
                Description = a.Description,
                Email = a.Email,
                FooterAddressId = a.FooterAddressId,
                Phone = a.Phone
            }).ToList();
        }
    }
}
