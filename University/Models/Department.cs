using System.Collections.Generic;

namespace University.Models
{
  public class Department
  {
    public Department()
    {
      this.JoinEntities = new HashSet<DepartmentCourse>();
    }

    public int DepartmentId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<DepartmentCourse> JoinEntities { get;}
  }
}