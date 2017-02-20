using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;

[Route("api/customer/claims")]

public class ClaimsController : Controller
{
    // POST api/customer/claims
    
    [HttpPost]

    public IActionResult Post([FromBody]Claim claim)
    {
        return Ok(db.CreateClaim(claim));
    }

    //GET api/customer/5

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(db.RetrieveQuote(id));
    }

    //PUT api/customer/claims/id

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]Claim claim)
    {
        return Ok(db.CreateClaim(claim));
    }

    //DELETE api/customer/claims/id

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        db.DeleteClaim(id);
        return Ok();
    }

    private IMemoryStore db;
    public ClaimsController(IMemoryStore repo)
    {
        db = repo;
    }

    [HttpGet]

    public IActionResult GetClaim()
    {
        return Ok(db.RetrieveAllClaims);
    }
}