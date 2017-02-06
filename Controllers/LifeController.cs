using Microsoft.AspNetCore.Mvc;

[Route("api/Life/quotes")]

public class LifeController : Controller
{
    // POST api/Life/quotes
    
    [HttpPost]

    public IActionResult Post([FromBody]string value)
    {
        return Created("", value);
    }

    //GET api/Life/quotes/5

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok("The id is: "+ id);
    }

    //PUT api/Life/quotes/id

    [HttpPut("{id}")]

    public IActionResult Put(int id, [FromBody]string value)
    {
        return NoContent();
    }

    //DELETE api/Life/quotes/id

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        return Delete(id);
    }
}