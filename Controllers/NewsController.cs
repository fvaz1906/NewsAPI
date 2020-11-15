using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsAPI.Data;
using NewsAPI.Models;

namespace NewsAPI.Controllers
{
    [ApiController]
    [Route("v1/news")]
    public class NewsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<News>>> Get([FromServices] DataContext context) 
        {
            var news = await context.News.ToListAsync();
            return news;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<News>> Post([FromServices] DataContext context, [FromBody] News model)
        {
            if (ModelState.IsValid)
            {
                context.News.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}