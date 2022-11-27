using TMDev.API.Data;

namespace TMDev.API.DTO;

public class ProjectDTO
{
  public Guid Id { get; set; }
  public string Name { get; set; } = "";
  public string Description { get; set; } = "";

  public ProjectDTO(Project project)
  {
    Id = project.Id;
    Name = project.Name;
    Description = project.Description;
  }

  public static IEnumerable<ProjectDTO> CreateList(IEnumerable<Project> projects)
  {
    List<ProjectDTO> dtos = new();
    foreach (Project project in projects)
    {
      dtos.Add(new(project));
    }

    return dtos;
  }
}