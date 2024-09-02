using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CompanyManagement.Domain.Entities;

public class User : IEntity
{
    [Key]
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(30)]
    [JsonProperty("username")]
    public string Username { get; set; } = null!;
    
    [Required]
    [MaxLength(50)]
    [JsonProperty("email")]
    public string Email { get; set; } = null!;
    
    [Required]
    [MaxLength(50)]
    [JsonProperty("password")]
    public string Password { get; set; } = null!;
    
    [Required]
    [MaxLength(30)]
    [JsonProperty("firstName")]
    public string FirstName { get; set; } = null!;
    
    [Required]
    [MaxLength(30)]
    [JsonProperty("lastName")]
    public string LastName { get; set; } = null!;

    [Required]
    [JsonProperty("departmentId")]
    [ForeignKey("Department")]
    public int DepartmentId { get; set; }
    
    [JsonProperty("department")]
    public Department Department { get; set; } = null!;
    
    [Required]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonProperty("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [JsonProperty("userRoles")]
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    
    [JsonProperty("userProjects")]
    public ICollection<UserProject> UserProjects { get; set; } = new List<UserProject>();
    
    [JsonProperty("userPermissions")]
    public ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();
}