using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class Role : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(30)]
    [JsonProperty("name")]
    public string Name { get; set; } = null!;
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("UpdatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("Role")]
    [JsonProperty("userRoles")]
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}