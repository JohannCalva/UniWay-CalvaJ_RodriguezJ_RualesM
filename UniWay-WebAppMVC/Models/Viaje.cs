using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniWay_WebAppMVC.Models
{
    public class Viaje
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Origen { get; set; }
        [Required]
        [MaxLength(100)]
        public string Destino { get; set; }
        [Required]
        public DateTime FechaHoraSalida { get; set; }
        [Required]
        public float Precio { get; set; }
        [Required]
        public int AsientosDisponibles { get; set; }
        public int ConductorId { get; set; }
        [ForeignKey("ConductorId")]
        public Usuario Conductor { get; set; }
    }
}
