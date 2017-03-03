using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;

[Route("api/claims")]

public class ClaimsController : Controller
{
    
    
    private readonly FisherContext db;

    public ClaimsController(FisherContext context)
    {
        db = context;
    }
    // POST api/customer/claims
    [HttpPost]

    public IActionResult Post([FromBody]Claim claim)
    {
        var newClaim = db.Claims.Add(claim);
        db.SaveChanges();
        return CreatedAtRoute("GetClaim", new { id = claim.Id }, claim);
    }

    //GET api/customer/5

    [HttpGet]
    public IActionResult GetClaims()
    {
        return Ok(db.Claims);
    }

    //PUT api/customer/claims/id

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]Claim claim)
    {
        var newClaim = db.Claims.Find(id);
        if (newClaim == null)
        {
            return NotFound();
        }
        newClaim = claim;
        db.SaveChanges();
        return Ok(newClaim);
    }

    //DELETE api/customer/claims/id

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        var claimToDelete = db.Claims.Find(id);
        if (claimToDelete == null)
        {
            return NotFound();
        }
    db.Claims.Remove(claimToDelete);
    db.SaveChangesAsync();
    return NoContent();
    }

    [HttpGet("{id}", Name = "GetClaim")]
    public IActionResult GetClaim(int id)
    {
        return Ok(db.Claims.Find(id));
    }
}