using API_Project.Data;
using API_Project.Models;
using API_Project.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API_Project.Controllers 
{
    //Alternative Method of routing  [Route("api/[Controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController :   ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaList);

        }


        [HttpGet("{id:int}")]
        //[ProducesResponseType(200)]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var villa= VillaStore.villaList.FirstOrDefault(u=>u.Id==id);
            if(villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<VillaDTO> CreateVilla([FromBody]VillaDTO villaDTO)
        {
            if(villaDTO == null)
            {
                return BadRequest(villaDTO);    
            }
            if(villaDTO.Id >0) 
            { 
             return StatusCode(StatusCodes.Status500InternalServerError);
            
            }
            villaDTO.Id = VillaStore.villaList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            VillaStore.villaList.Add(villaDTO);

            return Ok(villaDTO);

        }
    }
}
