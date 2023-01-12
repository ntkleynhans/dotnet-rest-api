public class GetBasicDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = String.Empty;
    public DateOnly? BirthDate { get; set; } = null;
}
