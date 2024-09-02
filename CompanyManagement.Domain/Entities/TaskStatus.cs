using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class TaskStatus : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [Required]
    [JsonProperty("name")]
    public string Name { get; set; } = null!;
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}