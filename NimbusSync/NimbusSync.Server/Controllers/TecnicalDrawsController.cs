using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NimbusSync.Models.DTO;
using NimbusSync.Models.Domain;
using NimbusSync.Server.Repositories;

namespace NimbusSync.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TecnicalDrawsController : ControllerBase
    {
        private readonly ITecnicalDrawRepository tecnicalDrawRepository;
        private readonly IMapper mapper;

        public TecnicalDrawsController(ITecnicalDrawRepository tecnicalDrawRepository, IMapper mapper)
        {
            this.tecnicalDrawRepository = tecnicalDrawRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("{code}")]
        [ActionName(nameof(GetTecnicalDrawAsync))]
        public async Task<IActionResult> GetTecnicalDrawAsync([FromRoute] string code)
        {
            var tecnicalDraw = await tecnicalDrawRepository.GetTecnicalDrawAsync(code);

            if (tecnicalDraw == null) return NotFound();

            var tecDrawDTO = mapper.Map<TecnicalDrawDTO>(tecnicalDraw);

            return Ok(tecDrawDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetTecnicalDrawsAsync([FromQuery] TecnicalDrawQuery tecnicalDrawQuery)
        {
            var tecDraws = await tecnicalDrawRepository.GetTecnicalDrawsAsync(tecnicalDrawQuery);

            var tecDrawDTOs = mapper.Map<List<TecnicalDrawDTO>>(tecDraws);

            return Ok(tecDrawDTOs);
        }

        [HttpPost]
        public async Task<IActionResult> PostTecnicalDraw([FromBody] PostTecnicalDrawRequest postTecnicalDrawRequest)
        {
            var tecDraw = mapper.Map<TecnicalDraw>(postTecnicalDrawRequest);

            tecDraw = await tecnicalDrawRepository.PostTecnicalDrawAsync(tecDraw);

            return CreatedAtAction(nameof(GetTecnicalDrawAsync), new { Id = tecDraw.Code }, tecDraw);
        }

        [HttpPut]
        [Route("{code}")]
        public async Task<IActionResult> PutTecnicalDraw(
            [FromRoute] string code,
            [FromBody] UpdateTecnicalDrawRequest updateTecnicalDrawRequest)
        {
            var tecDraw = mapper.Map<TecnicalDraw>(updateTecnicalDrawRequest);

            tecDraw = await tecnicalDrawRepository.PutTecnicalDrawAsync(code, tecDraw);

            if (tecDraw == null) return NotFound();

            var tecDrawDTO = mapper.Map<List<TecnicalDrawDTO>>(tecDraw);

            return Ok(tecDrawDTO);
        }

        [HttpDelete]
        [Route("{code}")]
        public async Task<IActionResult> DeleteTecnicalDraw([FromRoute] string code)
        {
            var tecDraw = await tecnicalDrawRepository.DeleteDrawAsync(code);

            if(tecDraw == null) return NotFound();

            var tecDrawDTO = mapper.Map<List<TecnicalDrawDTO>>(tecDraw);

            return Ok(tecDrawDTO);
        }

        [HttpPatch]
        [Route("{code}")]
        public async Task<IActionResult> PatchTecnicalDraw(
            [FromRoute] string code, 
            [FromBody] PatchTecnicalDrawRequest patchTecnicalDrawDocument)
        {
            var newTecDraw = mapper.Map<TecnicalDraw>(patchTecnicalDrawDocument);

            newTecDraw = await tecnicalDrawRepository.PatchTecnicalDrawAsync(code, newTecDraw);

            if(newTecDraw == null) return NotFound();

            var tecDrawDTO = mapper.Map<TecnicalDrawDTO>(newTecDraw);

            return Ok(tecDrawDTO);
        }
    }
}
