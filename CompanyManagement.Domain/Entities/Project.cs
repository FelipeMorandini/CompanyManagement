using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CompanyManagement.Domain.Enums;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class Project : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(50)]
    [JsonProperty("name")]
    public string Name { get; set; } = null!;
    
    [MaxLength(200)]
    [JsonProperty("description")]
    public string? Description { get; set; }
    
    [JsonProperty("startDate")]
    public DateTime? StartDate { get; set; }
    
    [JsonProperty("endDate")]
    public DateTime? EndDate { get; set; }
    
    [Required]
    [JsonProperty("projectStatus")]
    public ProjectStatus ProjectStatus { get; set; }
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
    
    [InverseProperty("Project")]
    [JsonProperty("userProjects")]
    public ICollection<UserProject> UserProjects { get; set; } = new List<UserProject>();
    
    [InverseProperty("Project")]
    [JsonProperty("tasks")]
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}