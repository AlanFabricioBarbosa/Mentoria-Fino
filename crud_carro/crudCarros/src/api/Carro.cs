using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Api
{
   [ApiController]
   [Route("api/[controller]")]
   public class CarroController : ControllerBase
   {
      private readonly IServicoCarro _service;

      public CarroController(IServicoCarro service)
      {
         _service = service;
      }

      [HttpPost]
      public IActionResult CadastrarCarro([FromBody] Carro carro)
      {
         var id = _service.CadastrarCarro(carro);
         return CreatedAtAction(nameof(ListarCarro), new { id = id }, carro);
      }

      [HttpGet]
      public IActionResult ListarCarros()
      {
         return Ok(_service.ListarCarros());
      }

      [HttpGet("{id}")]
      public IActionResult ListarCarro(int id)
      {
         var carro = _service.ListarCarro(id);
         if (carro == null) return NotFound();
         return Ok(carro);
      }
   }
}
