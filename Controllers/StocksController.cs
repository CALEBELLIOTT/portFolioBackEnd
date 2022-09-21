using Microsoft.AspNetCore.Mvc;
using portFolioBackEnd.Services;
using portFolioBackEnd.Models;
using System.Collections.Generic;


namespace portFolioBackEnd.Controllers
{

  [ApiController]
  [Route("api/stocks")]
  public class StocksController : ControllerBase
  {
    private readonly StocksService _Ss;
    public StocksController(StocksService Ss)
    {
      _Ss = Ss;
    }
    [HttpGet]
    public ActionResult<List<Stock>> Get()
    {
      try
      {
        List<Stock> stocks = _Ss.Get();
        return Ok(stocks);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}