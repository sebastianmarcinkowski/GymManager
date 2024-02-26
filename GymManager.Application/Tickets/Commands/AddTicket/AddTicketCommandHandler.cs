﻿using MediatR;

namespace GymManager.Application.Tickets.Commands.AddTicket;

public class AddTicketCommandHandler : IRequestHandler<AddTicketCommand>
{
    public async Task<Unit> Handle(
        AddTicketCommand request,
        CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
