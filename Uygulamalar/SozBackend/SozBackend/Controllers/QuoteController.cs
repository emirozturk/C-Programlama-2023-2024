using Microsoft.AspNetCore.Mvc;
using SozBackend.Models;
using SozBackend.Service;

namespace SozBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class QuoteController
{
    private IQuoteService quoteService;
    public QuoteController(IQuoteService quoteService)
    {
        this.quoteService = quoteService;
    }
    
    [HttpGet("{username}")]
    public IActionResult GetQuotesOfUser(string username)
    {
        try
        {
            var result = quoteService.GetQuotesOfUser(username);
            return new OkObjectResult(Response<List<Quote>>.Success(result));
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult(Response<List<Quote>>.Fail(e.Message));
        }
    }
    
    [HttpPost("{username}")]
    public IActionResult AddQuoteToUser(string username, Quote quote)
    {
        try
        {
            var result = quoteService.AddQuoteToUser(quote,username);
            return new OkObjectResult(Response<Quote>.Success(result));
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult(Response<Quote>.Fail(e.Message));
        }
    }
    [HttpPut("{username}")]
    public IActionResult DeleteQuoteOfUser(string username, Quote quote)
    {
        try
        {
            var result = quoteService.DeleteQuoteOfUser(quote,username);
            return new OkObjectResult(Response<Quote>.Success(result));
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult(Response<Quote>.Fail(e.Message));
        }
    }
}