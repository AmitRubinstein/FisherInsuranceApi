using Microsoft.AspNetCore.Mvc;

[Route("api/RealEstate/quotes")]

public class RealEstateController : Controller
{
    // POST api/RealEstate/quotes
    
    [HttpPost]

    public IActionResult Post([FromBody]string value)
    {
        return Created("", value);
    }

    //GET api/RealEstate/quotes/5

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok("The id is: "+ id);
    }

    //PUT api/RealEstate/quotes/id

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]string value)
    {
        return NoContent();
    }

    //DELETE api/RealEstate/quotes/id

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        return Delete(id);
    }
}