using DataAdapterSharp.DataAdapter;
using TMDev.API.Data;

namespace TMDev.API.Db;

public class Projects
{
  public static IEnumerable<Project> GetProjects() => DataAdapter.GetEnumerable<Project>("ProjectGetList");
}