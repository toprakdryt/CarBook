﻿using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarbook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;
        public CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia
            {
                Name = request.Name,
                URL = request.URL,
                Icon = request.Icon

            });
        }
    }
}
