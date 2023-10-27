namespace Library;
public class OIDCConfiguration {
    public string? Authority { get; set; }
    public string? Resource { get; set; }
    public string? Audience { get; set; }
    public string? ResponseType { get; set; }
    public string[]? Scope { get; set; }
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
}