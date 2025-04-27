using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniWay_WebAppMVC.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }
        [Required]
        [MaxLength(50)]
        public string Modelo { get; set; }
        [MaxLength(30)]
        public string Color { get; set; }
        [Required]
        [MaxLength(10)]
        public string Placa { get; set; }
        public int ConductorId { get; set; }
        [ForeignKey("ConductorId")]
        public Usuario? Conductor { get; set; }
    }
}
