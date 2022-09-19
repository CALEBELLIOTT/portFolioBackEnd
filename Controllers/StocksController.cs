using Microsoft.AspNetCore.Mvc;


namespace portFolioBackEnd.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StocksController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Stock>> Get()
        {

        }
    }
}