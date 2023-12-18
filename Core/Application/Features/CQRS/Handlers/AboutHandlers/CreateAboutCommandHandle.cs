using Application.Features.CQRS.Commands.AboutCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandle
    {
        private readonly IRepository<About> _repository;

        public CreateAboutCommandHandle(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateAboutCommand command)
        {
            await _repository.CreateAsync(new About
            {
                Description = command.Description,
                ImageUrl = command.ImageUrl,
                Title = command.Title
            });
        }
    }
}
