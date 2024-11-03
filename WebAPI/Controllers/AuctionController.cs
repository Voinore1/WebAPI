using AutoMapper;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Data.Entities;
using Core.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController(
        IMapper mapper,
        AuctionDBContext context,
        IFileService fileService,
        IAuctionService auctionService
        ) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() // get all auctions
        {
            return Ok(auctionService.GetAllAuctions());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id) // get auction info by id
        {
            return Ok(auctionService.GetAuctionById(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] AuctionCreateModel model) // create new auction
        {
            if (!ModelState.IsValid) return BadRequest();

            var auction = mapper.Map<Auction>(model);

            context.Auctions.Add(auction);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit([FromBody] AuctionFullModel model) // Edit auction
        {
            if (!ModelState.IsValid) return BadRequest();

            var auction = context.Auctions
                .Include(a => a.Venichle)
                .FirstOrDefault(a => a.Id == model.Id);

            if (auction == null)
            {
                return NotFound(); 
            }

            mapper.Map(model, auction);

            context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id) // delete auction by id
        {
            var auction = context.Auctions.Include(x => x.Venichle).Where(x => x.Id == id).First();
            if (auction == null) return NotFound($"Auction with id {id} not found.");

            context.Venichles.Remove(auction.Venichle);
            context.Auctions.Remove(auction);
            context.SaveChanges();

            return Ok("");
        }

    }
}
