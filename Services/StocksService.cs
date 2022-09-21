using Microsoft.AspNetCore.Mvc;
using portFolioBackEnd.Repositories;
using portFolioBackEnd.Models;
using System.Collections.Generic;


namespace portFolioBackEnd.Services
{
  public class StocksService
  {
    private readonly StocksRepository _repo;

    public StocksService(StocksRepository repo)
    {
      _repo = repo;
    }

    internal List<Stock> Get()
    {
      try
      {
        List<Stock> stocks = _repo.get();
        return stocks;
      }
      catch (System.Exception e)
      {
        throw new System.Exception(e.Message);
      }
    }
  }
}