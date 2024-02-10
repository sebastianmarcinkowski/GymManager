using MediatR;

namespace GymManager.Application.Tickets.Queries.GetTicketById;

public class GetTicketByIdQueryHandler : IRequestHandler<GetTicketByIdQuery, TicketDto>
{
    public async Task<TicketDto> Handle(
        GetTicketByIdQuery request,
        CancellationToken cancellationToken)
    {
        var id = request.Id;

        //todo: implement logic to get ticket by id

        return new TicketDto
        {
            Id = id,
            Name = "Ticket Name"
        };
    }
}
