using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class Permission : IEntity
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
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [JsonProperty("userPermissions")]
    [InverseProperty("Permission")]
    public ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();
}