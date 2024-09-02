using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class AuditLog : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [ForeignKey("User")]
    [JsonProperty("userId")]
    public int? UserId { get; set; } 
    
    [JsonProperty("user")]
    public User? User { get; set; }
    
    [Required]
    [MaxLength(2000)]
    [JsonProperty("action")]
    public string Action { get; set; } = null!;
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}