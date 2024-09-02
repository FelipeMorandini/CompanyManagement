using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class UserRole : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [Required]
    [JsonProperty("userId")]
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    [Required]
    [JsonProperty("roleId")]
    [ForeignKey("Role")]
    public int RoleId { get; set; }
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [JsonProperty("user")]
    [InverseProperty("UserRole")]
    public User User { get; set; } = null!;
    
    [JsonProperty("role")]
    [InverseProperty("UserRole")]
    public Role Role { get; set; } = null!;

}