using Application.Features.CQRS.Results.CarResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(a=> new GetCarQueryResult
            { 
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
