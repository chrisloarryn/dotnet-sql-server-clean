using dotnet_backend.Domain.Entities;
using dotnet_backend.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotnet_backend.Infrastructure.Persistence;

public class LeadRepository : ILeadRepository
{ 
    private readonly ApplicationDbContext _dbContext;

    
    public LeadRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<IEnumerable<Lead>> GetAll()
    {
        return await _dbContext.Leads.ToListAsync();
    }
    
    public async Task<Lead> GetById(int id)
    {
        return await _dbContext.Leads.FindAsync(id);
    }
    
    public async Task Add(Lead lead)
    {
        _dbContext.Leads.Add(lead);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task Update(Lead lead)
    {
        _dbContext.Entry(lead).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var lead = await _dbContext.Leads.FindAsync(id);
        await Delete(lead.Id);
    }

    public async Task<bool> Exists(int id)
    {
        return await _dbContext.Leads.AnyAsync(e => e.Id == id);
    }

}