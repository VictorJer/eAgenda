namespace EAgendaWeb.WebApp.Modulos.ModuloContato.Aplicacao;

public record ListarContatoDto(
    Guid Id,
    string Nome,
    string Telefone,
    string? Cargo,
    string? Empresa
);

public record CadastrarContatoDto(
    string Nome,
    string Telefone,
    string? Cargo,
    string? Empresa
);

public record EditarContatoDto(
    Guid Id,
    string Nome,
    string Telefone,
    string? Cargo,
    string? Empresa
);

public record DetalhesContatoSto(
    Guid Id,
    string Nome,
    string Telefone,
    string? Cargo,
    string? Empresa
);
