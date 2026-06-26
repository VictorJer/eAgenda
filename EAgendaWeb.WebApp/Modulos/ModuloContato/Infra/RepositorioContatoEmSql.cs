using Dapper;
using EAgendaWeb.WebApp.Compartilhado.Infra.Sql;
using Microsoft.Data.SqlClient;

namespace EAgendaWeb.WebApp.Modulos.ModuloContato.Dominio;

public sealed class RepositorioContatoEmSql(ISqlConnectionFactory ConnectionFactory)
    : IRepositorioContato
{
    private const string CadastrarSql = """
    INSERT INTO [dbo].[TBContatos] (Id, Nome, Email, Telefone, Cargo, Empresa)
    VALUES (@Id, @Nome, @Email, @Telefone, @Cargo, @Empresa);
    """;

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

    private const string SelecionarPorIdSql = """
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

    private const string AtualizarSql = """
    UPDATE [dbo].[TBCOntatos]
    SET
        [Nome] = @Nome,
        [Email] = @Email,
        [Telefone] = @Telefone,
        [Cargo] = @Cargo,
        [Empresa] = @Empresa
    WHERE [Id] = @Id;
    """;

    private const string ExcluirSql = """
    DELETE FROM [dbo].[TBContatos]
    WHERE [Id] = @Id;
    """;

    public void Cadastrar(Contato entidade)
    {
        using SqlConnection conexao = ConnectionFactory.CreateConnection();

        conexao.Open();

        conexao.Execute(CadastrarSql, entidade);
    }

    public bool Editar(Guid idSelecionado, Contato entidadeAtualizada)
    {
        using SqlConnection conexao = ConnectionFactory.CreateConnection();

        conexao.Open();

        return conexao.Execute(AtualizarSql, entidadeAtualizada) == 1;
    }

    public bool Excluir(Guid idSelecionado)
    {
        using SqlConnection conexao = ConnectionFactory.CreateConnection();

        conexao.Open();

        return conexao.Execute(ExcluirSql, new { Id = idSelecionado }) == 1;
    }

    public Contato? SelecionarPorId(Guid idSelecionado)
    {
        using SqlConnection conexao = ConnectionFactory.CreateConnection();

        conexao.Open();

        return conexao.QuerySingleOrDefault<Contato>(SelecionarPorIdSql, new { Id = idSelecionado });
    }

    public List<Contato> SelecionarTodos()
    {
        using SqlConnection conexao = ConnectionFactory.CreateConnection();

        conexao.Open();

        return conexao.Query<Contato>(SelecionarTodosSql).ToList();
    }

    public List<Contato> Filtrar(Predicate<Contato> filtro)
    {
        return SelecionarTodos().FindAll(filtro);
    }
}
