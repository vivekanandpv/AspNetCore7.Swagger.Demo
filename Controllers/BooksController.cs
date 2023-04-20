using AspNetCore7.Swagger.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore7.Swagger.Demo.Controllers;

[Route("api/v1/books")]
[ApiController]
public class BooksController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Book>> Get()
    {
        return Ok();
    }
    
    [HttpGet("{id:int}")]
    public ActionResult<Book> Get(int id)
    {
        return Ok();
    }

    [HttpPost]
    public ActionResult<Book> Create(Book book)
    {
        return Ok();
    }

    [HttpPut("{id:int}")]
    public ActionResult<Book> UpdatePut(int id, Book book)
    {
        return Ok();
    }
    
    [HttpPatch("{id:int}")]
    public ActionResult<Book> UpdatePatch(int id, Book book)
    {
        return Ok();
    }
    
    [HttpDelete("{id:int}")]
    public ActionResult<Book> Delete(int id)
    {
        return Ok();
    }
}