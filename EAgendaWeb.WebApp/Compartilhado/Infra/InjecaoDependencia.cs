using EAgendaWeb.WebApp.Compartilhado.Infra.Sql;


namespace EAgendaWeb.WebApp.Compartilhado.Infra;

public static class InjecaoDependencia
{
    public static void AddInfraRepositories(this IServiceCollection services)
    {
        services.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>();
        // services.AddScoped<IRepositorioFornecedor, RepositorioFornecedorEmSql>();
    }
}
