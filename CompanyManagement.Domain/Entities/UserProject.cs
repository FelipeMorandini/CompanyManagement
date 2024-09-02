using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class UserProject : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [Required]
    [JsonProperty("userId")]
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    [Required]
    [JsonProperty("projectId")]
    [ForeignKey("Project")]
    public int ProjectId { get; set; }
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [JsonProperty("user")]
    [InverseProperty("UserProject")]
    public User User { get; set; } = null!;
    
    [JsonProperty("project")]
    [InverseProperty("UserProject")]
    public Project Project { get; set; } = null!;
}