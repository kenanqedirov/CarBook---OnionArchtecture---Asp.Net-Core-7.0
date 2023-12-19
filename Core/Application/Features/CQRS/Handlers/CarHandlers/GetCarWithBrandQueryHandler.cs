using Application.Features.CQRS.Results.CarResults;
using Application.Interfaces;
using Application.Interfaces.CarInterfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;
        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarWithBrandQueryResult>> Handle()
        {
            var values = await _repository.GetCarsListWithBrandsAsync();
            return values.Select(a => new GetCarWithBrandQueryResult
            {
                BrandName = a.Brand.Name,
                BigImageUrl = a.BigImageUrl,
                BrandId = a.BrandId,
                CarId = a.CarId,
                CoverImageUrl = a.CoverImageUrl,
                Fuel = a.Fuel,
                Km = a.Km,
                Luggage = a.Luggage,
                Model = a.Model,
                Seat = a.Seat,
                Transmission = a.Transmission
            }).ToList();
        }
    }
}
