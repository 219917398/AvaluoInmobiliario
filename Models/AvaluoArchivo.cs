namespace AvaluoInmobiliario.Models
{
    public class AvaluoArchivo
    {
        public int Id { get; set; }

        public int? AvaluoId { get; set; }

        public string? NombreArchivo { get; set; }

        public string? TipoArchivo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public byte[]? Archivo { get; set; }

        public virtual Avaluo? Avaluo { get; set; }
    }
}
