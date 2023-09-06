using System.ComponentModel;

namespace dotnet_backend.Domain.Entities
{
    //clasificacion de cliente (frio, tibio, caliente) as enum.
    public enum Clasificacion
    {
        Frio,
        Tibio,
        Caliente
    }
    
    //estado del cliente (sin gestion, contactado, no contactado, no interesado, interesado) as enum.
    public enum Estado
    {
        SinGestion,
        Contactado,
        NoContactado,
        NoInteresado,
        Interesado
    }
    
    // tipo de lead (empresa, pensionado, trabajador, independiente) as enum.
    public enum TipoLead
    {
        Empresa,
        Pensionado,
        Trabajador,
        Independiente
    }
    
    public class Lead
    {
        // TODO: use Guid as primary key instead of int Id but keep Id for now.
        public Guid Uuid { get; set; } = Guid.NewGuid();
        public int Id { get; set; }
        public string Rut { get; set; } = null!;
        public string Dv { get; set; } = null!;
        public string PrimerNombre { get; set; } = null!;
        public string SegundoNombre { get; set; } = null!;
        public string PrimerApellido { get; set; } = null!;
        public string SegundoApellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string TelMovil { get; set; } = null!;
        public string CanalRegistro { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public Clasificacion Clasificacion { get; set; } = Clasificacion.Frio;
        public Estado Estado { get; set; } = Estado.SinGestion;
        public TipoLead TipoLead { get; set; } = TipoLead.Trabajador;
        public DateTime FchRegistro { get; set; } = DateTime.Now;
        public string Prioridad { get; set; } = null!;
        public string EjecutivoAsignado { get; set; } = null!;
        
        public string Direccion { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Comuna { get; set; } = null!;
        public string Region { get; set; } = null!;
    }
}
