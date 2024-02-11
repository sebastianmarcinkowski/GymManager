namespace GymManager.Domain.Entities;

public class Language
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Key { get; set; }

    public ICollection<TicketTypeTranslation> TicketTypeTranslations { get; set; }
        = new HashSet<TicketTypeTranslation>();
}
