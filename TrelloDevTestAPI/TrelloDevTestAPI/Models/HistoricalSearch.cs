using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrelloDevTestAPI.Models
{
    public class HistoricalSearch
    {
        public int HistoricalSearchID { get; set; }
        public string REST_Method { get; set; }
        public DateTime Requested_Date { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }

    }
}
