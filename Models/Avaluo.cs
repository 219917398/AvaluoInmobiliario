using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AvaluoInmobiliario.Models
{
    public class Avaluo
    {
        public int Id { get; set; }

       

        [DisplayName("Fecha de Avalúo")]
        public DateTime? FechaAvaluo { get; set; }

        [DisplayName("Email de Usuario")]
        public string? UsuarioId { get; set; }

        [DisplayName("Valuador")]
        public string? Valuador { get; set; }

        [DisplayName("Solicitante")]
        public string? Solicitante { get; set; }

        [DisplayName("Propietario del Inmueble")]
        public string? PropietarioInmueble { get; set; }

        [DisplayName("Propósito del Avalúo")]
        public string? PropositoAvaluo { get; set; }

        [DisplayName("ID de Estatus del Avalúo")]
        [Required(ErrorMessage = "El campo Estatus de Avalúo es obligatorio")]
        public int? EstatusAvaluoId { get; set; }

        [DisplayName("Tipo de Propiedad")]
        public string? TipoPropiedad { get; set; }

        [DisplayName("Calle")]
        public string? Calle { get; set; }

        [DisplayName("Número Exterior")]
        public string? NumExterior { get; set; }

        [DisplayName("Número Interior")]
        public string? NumInterior { get; set; }

        [DisplayName("Conjunto")]
        public string? Conjunto { get; set; }

        [DisplayName("Colonia")]
        public string? Colonia { get; set; }

        [DisplayName("Código Postal")]
        public string? CodigoPostal { get; set; }

        [DisplayName("Ciudad")]
        public string? Ciudad { get; set; }

        [DisplayName("Delegación/Municipio")]
        public string? DelegacionMunicipio { get; set; }

        [DisplayName("Estado")]
        public string? Estado { get; set; }

        [DisplayName("Clasificación de Zona")]
        public string? ClasifZona { get; set; }

        [DisplayName("Referencia Próxima Urbana")]
        public string? RefProxUrbana { get; set; }

        [DisplayName("Construcciones Predominantes")]
        public string? ConstruccionesPredom { get; set; }

        [DisplayName("Índice de Saturación")]
        public decimal? IndiceSaturacion { get; set; }

        [DisplayName("Densidad de Población")]
        public decimal? DensidadPoblacion { get; set; }

        [DisplayName("Nivel Socioeconómico")]
        public string? NivelSocioeconomico { get; set; }

        [DisplayName("Vías de Acceso")]
        public string? ViasAcceso { get; set; }

        [DisplayName("Intensidad de Flujo Vehicular")]
        public string? IntensidadFlujoVehicular { get; set; }

        [DisplayName("Infraestructura Disponible")]
        public string? InfraestructuraDisponible { get; set; }

        [DisplayName("Servicios Básicos")]
        public string? ServiciosBasicos { get; set; }

        [DisplayName("Otros Servicios")]
        public string? OtrosServicios { get; set; }

        [DisplayName("Equipamiento Urbano")]
        public string? EquipamientoUrbano { get; set; }

        [DisplayName("Comentarios de Entorno")]
        public string? ComentariosEntorno { get; set; }

        [DisplayName("Calles Límite y Orientación")]
        public string? CallesLimOrientacion { get; set; }

        [DisplayName("Dimensiones")]
        public string? Dimensiones { get; set; }

        [DisplayName("Colindancia")]
        public string? Colindancia { get; set; }

        [DisplayName("Configuración")]
        public string? Configuracion { get; set; }

        public string? Topografia { get; set; }

        [DisplayName("Uso de Suelo")]
        public string? UsoSuelo { get; set; }

        [DisplayName("Densidad Habitacional")]
        public string? DensidadHabitacional { get; set; }

        [DisplayName("Ubicación del Lote/Calle")]
        public string? UbicacionLoteCalle { get; set; }

        [DisplayName("Restricciones")]
        public string? Restricciones { get; set; }

        [DisplayName("Giro")]
        public string? Giro { get; set; }

        [DisplayName("Número de Niveles")]
        public int? NumNiveles { get; set; }

        [DisplayName("Superficies Cubiertas")]
        public string? SuperficiesCubiertas { get; set; }

        [DisplayName("Áreas Accesorias")]
        public string? AreasAccesorias { get; set; }

        [DisplayName("Superficie Vendible")]
        public decimal? SuperficieVendible { get; set; }

        [DisplayName("Clase General del Inmueble")]
        public string? ClaseGeneralInmueble { get; set; }

        [DisplayName("Estado de Conservación")]
        public string? EstadoConservacion { get; set; }

        [DisplayName("Edad de Construcciones")]
        public int? EdadConstrucciones { get; set; }

        [DisplayName("Vida Útil Remanente")]
        public int? VidaUtilRemanente { get; set; }

        [DisplayName("Cimentación")]
        public string? Cimentacion { get; set; }

        [DisplayName("Superestructura")]
        public string? SuperEstructura { get; set; }

        [DisplayName("Muros")]
        public string? Muros { get; set; }

        [DisplayName("Escaleras")]
        public string? Escaleras { get; set; }

        [DisplayName("Losas de Entrepisos")]
        public string? LosasEntrepisos { get; set; }

        [DisplayName("Losas de Azoteas")]
        public string? LosasAzoteas { get; set; }

        [DisplayName("Instalaciones Especiales")]
        public string? InstalacionesEspeciales { get; set; }

        [DisplayName("Elementos Accesorios")]
        public string? ElementosAccesorios { get; set; }

        [DisplayName("Obras Complementarias")]
        public string? ObrasComplementarias { get; set; }

        [DisplayName("Pisos")]
        public string? Pisos { get; set; }

        [DisplayName("Muros2")]
        public string? Muros2 { get; set; }

        [DisplayName("Plafones")]
        public string? Plafones { get; set; }

        [DisplayName("Instalaciones Hidráulicas")]
        public string? InstalacionesHidraulicas { get; set; }

        [DisplayName("Instalaciones Sanitarias")]
        public string? InstalacionesSanitarias { get; set; }

        [DisplayName("Instalaciones Eléctricas")]
        public string? InstalacionesElectricas { get; set; }

        [DisplayName("Puertas")]
        public string? Puertas { get; set; }

        [DisplayName("Closets")]
        public string? Closets { get; set; }

        [DisplayName("Muebles Fijos")]
        public string? MueblesFijos { get; set; }

        [DisplayName("Pisos2")]
        public string? Pisos2 { get; set; }

        [DisplayName("Ventanas")]
        public string? Ventanas { get; set; }

        [DisplayName("Vidriería")]
        public string? Vidrieria { get; set; }

        [DisplayName("Cerrajería")]
        public string? Cerrajeria { get; set; }

        [DisplayName("Determinación de Valor")]
        public string? DeterminacionValor { get; set; }

        [DisplayName("Comentarios")]
        public string? Comentarios { get; set; }

        public virtual ICollection<AvaluoArchivo> AvaluoArchivos { get; } = new List<AvaluoArchivo>();

        
        [DisplayName("Estatus de Avalúo")]
        public virtual AvaluoEstatus? EstatusAvaluo { get; set; }
    }
}
