using Microsoft.AspNetCore.Mvc;

[Route("api/customer/claims")]

public class ClaimsController : Controller
{
    // POST api/customer/claims
    
    [HttpPost]

    public IActionResult Post([FromBody]string value)
    {
        return Created("", value);
    }

    //GET api/customer/5

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok("The id is: "+ id);
    }

    //PUT api/customer/claims/id

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]string value)
    {
        return NoContent();
    }

    //DELETE api/customer/claims/id

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        return Delete(id);
    }
}