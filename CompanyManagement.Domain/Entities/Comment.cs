using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class Comment : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(2000)]
    [JsonProperty("content")]
    public string Content { get; set; } = null!;
    
    [Required]
    [JsonProperty("userId")]
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    [JsonProperty("taskId")]
    [ForeignKey("Task")]
    public int? TaskId { get; set; }
    
    [JsonProperty("projectId")]
    [ForeignKey("Project")]
    public int? ProjectId { get; set; }
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
    
    [JsonProperty("task")]
    [InverseProperty("Comment")]
    public Task? Task { get; set; }
    
    [JsonProperty("project")]
    [InverseProperty("Comment")]
    public Project? Project { get; set; }
    
    [JsonProperty("user")]
    [InverseProperty("Comment")]
    public User User { get; set; } = null!;
}