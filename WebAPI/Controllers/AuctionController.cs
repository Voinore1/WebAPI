using AutoMapper;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Data.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

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
        [Authorize]
        public IActionResult Create([FromForm] AuctionCreateModel model) // create new auction
        {
            auctionService.CreateAuction(model);

            return Ok();
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Edit([FromBody] AuctionFullModel model) // Edit auction
        {
            auctionService.EditAuction(model);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete([FromRoute]int id) // delete auction by id
        {
            auctionService.DeleteAuction(id);
            return Ok();
        }

        [HttpGet("brands")]
        public IActionResult GetAllBrands()
        {
            return Ok(auctionService.GetAllBrands());
        }

        [HttpGet("models/{id}")]
        public IActionResult GetAllModels([FromRoute] int id)
        {
            return Ok(auctionService.GetAllCarsModel(id));
        }

        [HttpGet("transmissions")]
        public IActionResult GetAllTransmissions()
        {
            return Ok(auctionService.GetAllTransmissions());
        }

        [HttpGet("fueltypes")]
        public IActionResult GetAllFuelTypes()
        {
            return Ok(auctionService.GetAllFuelTypes());
        }

        [HttpGet("bodystyles")]
        public IActionResult GetAllBodyStyles()
        {
            return Ok(auctionService.GetAllBodyStyles());
        }

    }
}
