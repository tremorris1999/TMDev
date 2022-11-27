namespace TMDev.API.Data;

public class Project
{
  public Guid Id { get; set; }
  public string Name { get; set; } = "";
  public string Description { get; set; } = "";
  public string ThumbnailPath { get; set; } = "";
  public string VideoPath { get; set; } = "";
}