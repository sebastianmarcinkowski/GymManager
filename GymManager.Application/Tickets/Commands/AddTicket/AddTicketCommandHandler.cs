using MediatR;

namespace GymManager.Application.Tickets.Commands.AddTicket;

public class AddTicketCommandHandler : IRequestHandler<AddTicketCommand>
{
    public async Task<Unit> Handle(
        AddTicketCommand request,
        CancellationToken cancellationToken)
    {
        //todo: add ticket

        //var ticket = new Ticket
        //{
        //    Name = request.Name
        //};

        return Unit.Value;
    }
}
