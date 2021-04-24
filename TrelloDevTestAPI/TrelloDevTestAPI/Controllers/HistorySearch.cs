using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrelloDevTestAPI.Models;

namespace TrelloDevTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HistorySearch : ControllerBase
    {
        private string TrelloAPIKey = "6696eb45632ac6cfb96843e01b542937";
        private string TrelloToken = "194f7dd1f72323af81112647d522ff7f024ebc5df658dfe5bef34c076f785985";
        private string URL = "https://api.trello.com";

        [HttpGet]
        public async Task<string> Get(string id)
        {
            var client = new HttpClient();
            var idBoard = "608358c97610ee5f4d38b407";
            var response = await client.GetAsync($"{URL}/1/boars?token=${TrelloToken}&key={TrelloAPIKey}&idBoard={id}");
            return await response.Content.ReadAsStringAsync();
           //string st = response.StatusCode;

        }
    }
}
