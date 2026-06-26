using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using EAgendaWeb.WebApp.Compartilhado.Dominio;

namespace EAgendaWeb.WebApp.Modulos.ModuloContato.Dominio;

public class Contato : EntidadeBase<Contato>
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;
    public string Empresa { get; set; } = string.Empty;

    public Contato(string nome, string email, string telefone, string cargo, string empresa)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Cargo = cargo;
        Empresa = empresa;
    }

    public override void Atualizar(Contato entidadeAtualizada)
    {
        Nome = entidadeAtualizada.Nome;
        Email = entidadeAtualizada.Email;
        Telefone = entidadeAtualizada.Telefone;
        Cargo = entidadeAtualizada.Cargo;
        Empresa = entidadeAtualizada.Empresa;
    }

    public override List<string> Validar()
    {
        List<string> erros = new List<string>();

        if (string.IsNullOrWhiteSpace(Nome) || Nome.Length < 2 || Nome.Length > 100)
            erros.Add("O campo \"Nome\" deve conter entre 2 e 100 caracteres.");

        if (!Regex.IsMatch(Telefone, @"^\(\d{2}\) \d{4,5}-\d{4}$"))
            erros.Add("O campo \"Telefone\" deve estar no formato (DDD) 90000-0000.");

        if (!Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled))
            erros.Add("O campo \"E-mail\" deve estar em um formato válido (ex: nome@dominio.com).");

        return erros;
    }
}
