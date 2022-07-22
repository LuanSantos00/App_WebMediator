using WebMediator.Dominio.Comandos.Requests;
using WebMediator.Dominio.Comandos.Responses;

namespace WebMediator.Dominio.Handlers
{
    public interface ICadastroProdutoHandler
    {
        ResponsesProduto Handle(RequestsProduto request);
    }
}
