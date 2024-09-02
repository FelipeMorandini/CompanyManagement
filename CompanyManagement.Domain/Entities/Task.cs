using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CompanyManagement.Domain.Enums;
using Newtonsoft.Json;
using TaskStatus = CompanyManagement.Domain.Enums.TaskStatus;

namespace CompanyManagement.Domain.Entities;

public class Task : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [Required]
    [ForeignKey("Project")]
    [JsonProperty("projectId")]
    public int ProjectId { get; set; }
    
    [Required]
    [MaxLength(50)]
    [JsonProperty("name")]
    public string Name { get; set; } = null!;
    
    [MaxLength(300)]
    [JsonProperty("Description")]
    public string? Description { get; set; }
    
    [Required]
    [JsonProperty("taskPriority")]
    public TaskPriority TaskPriority { get; set; }

    [Required]
    [JsonProperty("taskStatus")]
    public TaskStatus TaskStatus { get; set; }
    
    [JsonProperty("userId")]
    [ForeignKey("User")]
    public int? UserId { get; set; }
    
    [JsonProperty("user")]
    public User? User { get; set; }
    
    [JsonProperty("dueDate")]
    public DateTime? DueDate { get; set; }
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("upgradedAt")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("task")]
    [JsonProperty("project")]
    public Project Project { get; set; } = null!;
}