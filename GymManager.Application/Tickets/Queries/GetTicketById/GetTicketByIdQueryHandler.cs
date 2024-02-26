using MediatR;

namespace GymManager.Application.Tickets.Queries.GetTicketById;

public class GetTicketByIdQueryHandler : IRequestHandler<GetTicketByIdQuery, TicketDto>
{
    public async Task<TicketDto> Handle(
        GetTicketByIdQuery request,
        CancellationToken cancellationToken)
    {
        var id = request.Id;

        return new TicketDto
        {
            Id = id,
            Name = "Ticket Name"
        };
    }
}
