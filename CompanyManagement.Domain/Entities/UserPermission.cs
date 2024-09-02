using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class UserPermission : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [Required]
    [JsonProperty("userId")]
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    [Required]
    [JsonProperty("permissionId")]
    [ForeignKey("Permission")]
    public int PermissionId { get; set; }
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [JsonProperty("user")]
    [InverseProperty("UserPermission")]
    public User User { get; set; } = null!;
    
    [JsonProperty("permission")]
    [InverseProperty("UserPermission")]
    public Permission Permission { get; set; } = null!;
}