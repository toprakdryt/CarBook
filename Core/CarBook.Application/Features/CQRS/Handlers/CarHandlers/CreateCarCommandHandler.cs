﻿using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarbook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageURL = command.BigImageURL,
                Luggage = command.Luggage,
                Km= command.Km,
                Model= command.Model,
                Seat= command.Seat,
                Transmission= command.Transmission,
                BrandID= command.BrandID,
                Fuel= command.Fuel,
                CoverImageURL= command.CoverImageURL
            });
        }
    }
}
