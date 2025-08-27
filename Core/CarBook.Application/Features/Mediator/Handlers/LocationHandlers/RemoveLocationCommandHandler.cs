using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UdemyCarbook.Domain.Entities;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class RemoveTagCloudCommandHandler : IRequestHandler<RemoveLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public RemoveTagCloudCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}