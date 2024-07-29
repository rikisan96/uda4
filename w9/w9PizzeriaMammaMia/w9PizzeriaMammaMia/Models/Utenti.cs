using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace w9PizzeriaMammaMia.Models
{
    public class Utenti
    {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [Required]
            [StringLength(20)]
            public required string Name { get; set; }
            [Required]
            [EmailAddress]
            public required string Email { get; set; }
            [Required]
            [StringLength(20)]
            public required string Password { get; set; }
            public List<Role> Roles { get; set; } = [];
    }
}