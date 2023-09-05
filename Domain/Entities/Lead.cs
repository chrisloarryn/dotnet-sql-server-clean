namespace dotnet_backend.Domain.Entities
{
    public class Lead
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        // public string Phone { get; set; }
        // Otras propiedades
    }
}
