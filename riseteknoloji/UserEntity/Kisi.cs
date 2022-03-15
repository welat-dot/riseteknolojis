using CoreLayer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserEntity
{
    public class Kisi:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(36)]
        public string  Guid { get; set; }
        [MaxLength(100)]
        public string Firma { get; set; }
        [MaxLength(100)]
        public string Ad { get; set; }
        [MaxLength(100)]
        public string Soyad { get; set; }

        [ForeignKey("Iletisim")]
        public int ILetisimRefId { get; set; }


    }
}
