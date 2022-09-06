public class todo
{
    public string? title { get; set; }
    public string? details { get; set; }
    public bool done { get; set; } = false;
    public DateOnly? target { get; set; }
}