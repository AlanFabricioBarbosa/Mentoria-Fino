using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Api
{
   [ApiController]
   [Route("api/[controller]")]
   public class ClienteController : ControllerBase
   {
      private readonly IServicoCliente _service;

      public ClienteController(IServicoCliente service)
      {
         _service = service;
      }

      [HttpPost]
      public IActionResult CadastrarCliente([FromBody] Cliente cliente)
      {
         var id = _service.CadastrarCliente(cliente);
         return CreatedAtAction(nameof(ListarCliente), new { id = id }, cliente);
      }

      [HttpGet]
      public IActionResult ListarClientes() => Ok(_service.ListarClientes());

      [HttpGet("{id}")]
      public IActionResult ListarCliente(int id)
      {
         var cliente = _service.ListarCliente(id);
         return cliente != null ? Ok(cliente) : NotFound();
      }
   }
}
