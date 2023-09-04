using dotnet_backend.Domain.Entities;

namespace dotnet_backend.Domain.Interfaces
{
    public interface ILeadRepository
    {
        Task<Lead> GetByIdAsync(int id);
        Task<IEnumerable<Lead>> GetAllAsync();
        Task AddAsync(Lead lead);
        Task UpdateAsync(Lead lead);
        Task DeleteAsync(int id);
    }
}