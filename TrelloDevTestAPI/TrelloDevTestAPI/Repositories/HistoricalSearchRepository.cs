using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloDevTestAPI.Models;

namespace TrelloDevTestAPI.Repositories
{
    public class HistoricalSearchRepository : IHistoricalSearchRepository
    {
        private readonly HistoricalSearchContext _context;

        public HistoricalSearchRepository(HistoricalSearchContext context)
        {
            this._context = context;
        }
        public async Task<HistoricalSearch> Create(HistoricalSearch history)
        {
            _context.History.Add(history);
            await _context.SaveChangesAsync();
            return history;
        }

        public async Task Delete(int id)
        {
            var historyToDelete = await _context.History.FindAsync(id);
            _context.History.Remove(historyToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<HistoricalSearch>> Get()
        {
            return await _context.History.ToListAsync();
        }

        public async Task<HistoricalSearch> Get(int id)
        {
            return await _context.History.FindAsync(id);
        }

        public async Task Update(HistoricalSearch history)
        {
            _context.Entry(history).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
