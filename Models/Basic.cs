public class Basic
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = String.Empty;
    public DateOnly? BirthDate { get; set; } = null;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdateAt { get; set; } = DateTime.UtcNow;
}
