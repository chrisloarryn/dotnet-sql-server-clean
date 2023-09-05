using dotnet_backend.Domain.Entities;

namespace dotnet_backend.Domain.Interfaces
{
    public interface ILeadRepository
    {
        Task<Lead> GetById(int id);
        Task<IEnumerable<Lead>> GetAll();
        Task Add(Lead lead);
        Task Update(Lead lead);
        Task Delete(int id);
        Task<bool> Exists(int id);
    }
}