using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMediator.Dominio.Comandos.Requests;
using WebMediator.Dominio.Comandos.Responses;

namespace WebMediator.Controllers
{
    [ApiController]
    [Route("v1/api/produtos/")]
    
    public class ProdutosController : ControllerBase
    {

        [HttpPost]
        [Route("cadastrar")]
        public async Task<ResponsesProduto> Cadastro(
            [FromServices] IMediator mediator,
            [FromBody] RequestsProduto request)
        {
            return await mediator.Send(request);
        }
    }
}
