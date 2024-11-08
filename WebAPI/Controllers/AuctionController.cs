﻿using AutoMapper;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Data.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize]
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

    }
}
