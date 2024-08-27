namespace SSW.GitSkills.Models;

public class OrgMember
{
    public string Name { get; set; }
    public List<Skill> Skills { get; set; } = new List<Skill>();
}