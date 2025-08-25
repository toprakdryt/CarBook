using CarBook.Application.Features.Mediator.Queries.LocationQueries;
using CarBook.Application.Features.Mediator.Queries.SocailMediaQueries;
using CarBook.Application.Features.Mediator.Results.LocationResult;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;
using CarBook.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarbook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;
        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                Name = x.Name,
                SocialMediaID = x.SocialMediaID,
                URL=x.URL,
                Icon = x.Icon
            }).ToList();
        }
    }
}
