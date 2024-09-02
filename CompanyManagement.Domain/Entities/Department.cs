using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class Department : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; } 
    
    [Required]
    [MaxLength(50)]
    [JsonProperty("name")]
    public string Name { get; set; } = null!;
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [JsonProperty("users")]
    [InverseProperty("Department")]
    public ICollection<User> Users { get; set; } = new List<User>(); 
}