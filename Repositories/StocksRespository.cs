using Microsoft.AspNetCore.Mvc;
using portFolioBackEnd.Services;
using portFolioBackEnd.Models;
using System.Collections.Generic;
using Dapper;
using System.Linq;
using System.Data;

namespace portFolioBackEnd.Repositories
{
  public class StocksRepository
  {

    private readonly IDbConnection _db;

    public StocksRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Stock> get()
    {
      string sql = @"
      SELECT * FROM Stocks
      ";
      List<Stock> stocks = _db.Query<Stock>(sql).ToList();
      return stocks;
    }
  }
}