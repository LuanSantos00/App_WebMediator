using MediatR;
using WebMediator.Dominio.Comandos.Requests;
using WebMediator.Dominio.Comandos.Responses;

namespace WebMediator.Dominio.Handlers
{
    public class CadastroProdutoHandler : IRequestHandler<RequestsProduto, ResponsesProduto>
    {

        public Task<ResponsesProduto> Handle(RequestsProduto request, CancellationToken cancellationToken)
        {
            var result = new ResponsesProduto
            {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                Valor = request.Valor,
                Date = DateTime.Now,

            };

            return Task.FromResult(result);

        }
    }
}
