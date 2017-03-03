using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/quotes")]

public class QuotesController : Controller
{

    private readonly FisherContext db;

    public QuotesController(FisherContext context)
    {
        db = context;
    } 
    // POST api/quotes
    
    [HttpPost]

    public IActionResult Post([FromBody]Quote quote)
    {
        var newQuote = db.Quotes.Add(quote);
        db.SaveChanges();
        return CreatedAtRoute("GetQuote", new { id = quote.Id }, quote);
    }

    //GET api/quotes/5

    [HttpGet]
    public IActionResult GetQuotes()
    {
        return Ok(db.Quotes);
    }

    //PUT api/quotes/id

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]Quote quote)
    {
        var newQuote = db.Quotes.Find(id);
        if (newQuote == null)
        {
            return NotFound();
        }
        newQuote = quote;
        db.SaveChanges();
        return Ok(newQuote);
    }

    //DELETE api/quotes/id

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        var quoteToDelete = db.Quotes.Find(id);
        if (quoteToDelete == null)
        {
            return NotFound();
        }
    db.Quotes.Remove(quoteToDelete);
    db.SaveChangesAsync();
    return NoContent();
    }

    [HttpGet("{id}", Name = "GetQuote")]
    public IActionResult GetQuote(int id)
    {
       return Ok(db.Quotes.Find(id));
    }
}