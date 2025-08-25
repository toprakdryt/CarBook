using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithPricingQueryHandler
    {
      private readonly ICarRepository _repository;

        public GetCarWithPricingQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithPricingQueryResult> Handle()
        {
            var values = _repository.GetCarsWithPricings();
            return values.Select(x => new GetCarWithPricingQueryResult
            {
               
            }).ToList();
        }
    }
}
