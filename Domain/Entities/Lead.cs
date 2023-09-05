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
        public int Id { get; set; }
        //Rut
        public string Rut { get; set; } = null!;
        // DV
        public string Dv { get; set; } = null!;
        //primer nombre
        public string PrimerNombre { get; set; } = null!;
        //segundo nombre
        public string SegundoNombre { get; set; } = null!;
        //primer apellido
        public string PrimerApellido { get; set; } = null!;
        //segundo apellido
        public string SegundoApellido { get; set; } = null!;
        //email
        public string Email { get; set; } = null!;
        //tel movil
        public string TelMovil { get; set; } = null!;
        //canal registro // canal de registro
        public string CanalRegistro { get; set; } = null!;
        //sucursal // sucursal de preferencia // should be a foreign key to Sucursal
        public string Sucursal { get; set; } = null!;
        //clasificacion // clasificacion de cliente (frio, tibio, caliente)
        public Clasificacion Clasificacion { get; set; } = Clasificacion.Frio;
        //estado // estado del cliente (sin gestion, contactado, no contactado, no interesado, interesado)
        public Estado Estado { get; set; } = Estado.SinGestion;
        //tipo lead // tipo de lead (empresa, pensionado, trabajador, independiente)
        public TipoLead TipoLead { get; set; } = TipoLead.Trabajador;
        //fch registro // fecha de registro
        public DateTime FchRegistro { get; set; }
        //prioridad // prioridad de contacto
        public string Prioridad { get; set; } = null!;
        //ejecutivo asignado // ejecutivo de incorporacion asignado
        public string EjecutivoAsignado { get; set; } = null!;
        
        // adicionalmente
        //direccion
        public string Direccion { get; set; } = null!;
        //ciudad
        public string Ciudad { get; set; } = null!;
        //comuna
        public string Comuna { get; set; } = null!;
        //region
        public string Region { get; set; } = null!;
    }
}
