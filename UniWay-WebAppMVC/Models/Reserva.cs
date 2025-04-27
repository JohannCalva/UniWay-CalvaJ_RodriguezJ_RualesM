using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniWay_WebAppMVC.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Estado { get; set; }
        [Required]
        [MaxLength(20)]
        public string MetodoPago { get; set; }
        public int ViajeId { get; set; }
        [ForeignKey("ViajeId")]
        public Viaje? Viaje { get; set; }
        public int PasajeroId { get; set; }
        [ForeignKey("PasajeroId")]
        public Usuario? Pasajero { get; set; }
    }
}
