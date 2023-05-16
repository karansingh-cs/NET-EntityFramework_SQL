﻿using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext _context;
        public CharacterController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult <List<Character>> > Get(int userId) 
        {
            var characters = await _context.Characters
                .Where(c => c.UserId == userId)
                .ToListAsync();

            return characters;
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> Create(Character character)
        {
           
           var result =  _context.Characters.Add(character);
           await  _context.SaveChangesAsync();
            return await Get(character.UserId);
        }
    }
}
