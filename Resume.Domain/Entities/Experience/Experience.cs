namespace Resume.Domain.Models.Entities.Experience;

public class Experience
{
    public int Id { get; set; }
    public string EperienceTitle { get; set; }
    public string EperienceDuration { get; set; }
    public string Description { get; set; }
    public string CompanyName { get; set; }
    public string? CompanySite { get; set; }

}
