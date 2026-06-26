using EAgendaWeb.WebApp.Compartilhado.Infra.Sql;

namespace EAgendaWeb.WebApp.Modulos.ModuloContato.Dominio;

public sealed class RepositorioContatoEmSql(ISqlConnectionFactory ConnectionFactory)
    : IRepositorioContato
{
    private const string SelecionarTodosSql = """
    SELECT
        [Id],
        [Nome],
        [Email],
        [Telefone],
        [Cargo],
        [Empresa]
    FROM [dbo].[TBContatos]
    ORDER BY [Nome];
    """;

    private const string SelecionarPorId = """
    SELECT
        [Id],
        [Nome],
        [Email],
        [Telefone],
        [Cargo],
        [Empresa]
    FROM [dbo].[TBContatos]
    WHERE [Id] = @Id;
    """;

    public void Cadastrar(Contato entidade)
    {
        throw new NotImplementedException();
    }

    public bool Editar(Guid idSelecionado, Contato entidadeAtualizada)
    {
        throw new NotImplementedException();
    }

    public bool Excluir(Guid idSelecionado)
    {
        throw new NotImplementedException();
    }

    public List<Contato> Filtrar(Predicate<Contato> filtro)
    {
        throw new NotImplementedException();
    }

    public Contato? SelecionarPorId(Guid idSelecionado)
    {
        throw new NotImplementedException();
    }

    public List<Contato> SelecionarTodos()
    {
        throw new NotImplementedException();
    }
}
