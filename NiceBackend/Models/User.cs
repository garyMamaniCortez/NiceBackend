using System.ComponentModel.DataAnnotations;

namespace NiceBackend.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string UserName { get; set; } = string.Empty;

        [StringLength(100)]
        public byte[] PasswordHash { get; set; }
        
        [StringLength(200)]
        public byte[] PasswordSalt { get; set; }
    }
}
