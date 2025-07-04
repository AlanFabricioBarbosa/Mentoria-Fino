using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Api
{
   [ApiController]
   [Route("api/[controller]")]
   public class TransacaoController : ControllerBase
   {
      private readonly IServicoTransacao _service;

      public TransacaoController(IServicoTransacao service)
      {
         _service = service;
      }

      [HttpPost]
      public IActionResult InserirTransacao([FromBody] Transacao transacao)
      {
         var id = _service.InserirTransacao(
            transacao.Tipo,
            transacao.ClienteID,
            transacao.CarroID,
            transacao.Data,
            transacao.Valor
         );
         return CreatedAtAction(nameof(ListarTransacao), new { id }, transacao);
      }

      [HttpGet("{id}")]
      public IActionResult ListarTransacao(int id)
      {
         var t = _service.ListarTransacao(id);
         return t != null ? Ok(t) : NotFound();
      }

      [HttpGet]
      public IActionResult ListarTransacoes([FromQuery] TipoTransacao tipo, [FromQuery] int mes)
      {
         return Ok(_service.ListarTransacoes(tipo, mes));
      }
   }
}
