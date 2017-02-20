using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/quotes")]

public class QuotesController : Controller
{
    // POST api/quotes
    
    [HttpPost]

    public IActionResult Post([FromBody]Quote quote)
    {
        return Ok(db.CreateQuote(quote));
    }

    //GET api/quotes/5

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(db.RetrieveQuote(id));
    }

    //PUT api/quotes/id

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]Quote quote)
    {
        return Ok(db.CreateQuote(quote));
    }

    //DELETE api/quotes/id

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        db.DeleteQuote(id);
        return Ok();
    }

    private IMemoryStore db;
    public QuotesController(IMemoryStore repo)
    {
        db = repo;
    }

    [HttpGet]
    public IActionResult GetQuotes()
    {
        return Ok(db.RetrieveAllQuotes);
    }
}