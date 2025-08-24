﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarbook.Domain.Entities;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;
        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BlogID);
            values.AuthorID = request.AuthorID;
            values.CreatedDate = request.CreatedDate;
            values.CategoryID = request.CategoryID;
            values.CoverImageURL = request.CoverImageURL;
            values.Title = request.Title;
            await _repository.UpdateAsync(values);
        }
    }
}