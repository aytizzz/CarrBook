using CarBook.Domain.Entities;
using CarrBook.Application.Features.CQRS.Commands.AboutCommands;
using CarrBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrBook.Application.Features.CQRS.Handlers.AboutHandlers
{
   public class CreateAboutCommandHandler
    {
        public readonly IRepository<About> _repository;

        public CreateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommand command)
        {
            await _repository.CreateAsync(new About
            {

                Title = command.Title,
                Description = command.Description,
                ImageUrl = command.ImageUrl
            });
        }
    }
}
