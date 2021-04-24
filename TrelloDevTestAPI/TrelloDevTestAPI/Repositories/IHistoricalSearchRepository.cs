using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloDevTestAPI.Models;

namespace TrelloDevTestAPI.Repositories
{
    public interface IHistoricalSearchRepository
    {
        Task<IEnumerable<HistoricalSearch>> Get();
        Task<HistoricalSearch> Get(string id);
        Task<HistoricalSearch> Create(HistoricalSearch history);
        Task Update(HistoricalSearch history);
        Task Delete(int id);
    }
}
