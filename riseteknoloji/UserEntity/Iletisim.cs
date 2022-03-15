using CoreLayer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserEntity
{
    public class Iletisim:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(36)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Telefon { get; set; }
        [Required]
        public double  Enlem { get; set; }
        [Required ]
        public double Boylam { get; set; }
    }
}
