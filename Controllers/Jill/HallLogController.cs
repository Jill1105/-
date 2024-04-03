﻿using HotelFuen31.APIs.Dtos.Jill;
using HotelFuen31.APIs.Services.Jill;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelFuen31.APIs.Controllers.Jill
{
    [Route("api/[controller]")]
    [ApiController]
    public class HallLogController : ControllerBase
    {
        private readonly HallLogService _service;

        public HallLogController(HallLogService service)
        {
            _service = service;
        }

        // GET: api/HallLog
        [HttpGet]
        public async Task<IEnumerable<HallLogDto>> GetAll()
        {
            return await _service.GetAll().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<HallLogDto>> SearchLog(int id)
        {
            return await _service.SearchLog(id).ToListAsync();
        }

    }
}