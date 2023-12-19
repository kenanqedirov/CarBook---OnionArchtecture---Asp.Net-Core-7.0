using Application.Features.CQRS.Commands.ContactCOmmands;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var value = await _repository.GetByIdAsync(command.ContactId);
            value.SendDate = command.SendDate;
            value.ContactId = command.ContactId;
            value.Subject = command.Subject;
            value.Email = command.Email;
            value.Message = command.Message;
            value.Name = command.Name;
           
            await _repository.UpdateAsync(value);
        }
    }
}
