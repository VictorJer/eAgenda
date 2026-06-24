# 📑 e-Agenda 2026

<div align="center">
  <img src="https://img.shields.io/badge/.NET%2010.0-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/ASP.NET%20Core%20MVC-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt="ASP.NET MVC" />
  <img src="https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt="EF Core" />
  <img src="https://img.shields.io/badge/GitHub%20Actions-2088FF?style=for-the-badge&logo=github-actions&logoColor=white" alt="GitHub Actions" />
</div>

<br />

O **e-Agenda** é uma aplicação completa para gerenciamento pessoal desenvolvida em .NET 10 utilizando o padrão arquitetural MVC. O sistema permite o controle rigoroso de tarefas, compromissos, contatos, categorias e despesas, aplicando boas práticas de Programação Orientada a Objetos, persistência de dados relacional e pipelines automatizados de CI/CD via GitHub Actions.

---

## 🚀 Funcionalidades & Módulos do Sistema

O sistema é composto por módulos centrais amplamente integrados para atender aos requisitos de negócio:

### 👥 1. Módulo de Contatos
* **CRUD Completo:** Permite a inserção, edição, exclusão e visualização de contatos.
* **Regras de Negócio:**
  * **Campos obrigatórios:** Nome (2-100 caracteres), Email (formato válido) e Telefone validado no formato `(XX) XXXX-XXXX` ou `(XX) XXXXX-XXXX`. Cargo e Empresa são opcionais.
  * **Unicidade:** Bloqueio de cadastros com o mesmo e-mail e/ou telefone.
  * **Integridade:** Impede a exclusão de contatos vinculados a compromissos ativos.

### 📅 2. Módulo de Compromissos
* **Gerenciamento de Agenda:** Inserção, edição, exclusão e visualização de compromissos.
* **Campos Obrigatórios:** Assunto (2-100 caracteres), Data de Ocorrência, Hora de Início, Hora de Término e Tipo de Compromisso (Remoto ou Presencial). Contato associado é opcional.
* **Diferenciação de Tipo:** Validação obrigatória de Local para compromissos presenciais ou Link para compromissos remotos.
* **Regras de Negócio:**
  * **Concorrência:** O sistema impede o agendamento caso haja conflito de horários entre compromissos.

### 🗂️ 3. Módulo de Categorias
* **Organização:** Cadastro, edição, exclusão e visualização de todas as categorias.
* **Regras de Negócio:**
  * **Campos obrigatórios:** Título (2-100 caracteres).
  * **Unicidade:** Não permite categorias com o mesmo título.
  * **Integridade:** Bloqueia a exclusão de categorias que possuam despesas relacionadas.
  * **Visualização:** Permite listar todas as despesas pertencentes a uma categoria específica.

### 💰 4. Módulo de Despesas
* **Fluxo Financeiro:** Cadastro, edição, exclusão e visualização de todas as despesas.
* **Regras de Negócio:**
  * **Campos obrigatórios:** Descrição (2-100 caracteres), Valor (R$), Forma de Pagamento (À Vista, Crédito ou Débito) e vínculo com 1 ou mais Categorias.
  * **Data de Ocorrência:** Campo opcional, assumindo a data de cadastro por padrão.

### 📋 5. Módulo de Tarefas & Itens
* **Gestão de Produtividade:** Cadastro, edição, exclusão e filtros de visualização de tarefas (todas, pendentes e concluídas), além de agrupamento por prioridade.
* **Campos obrigatórios:** Título (2-100 caracteres), Prioridade (Baixa, Normal, Alta), Data de Criação, Data de Conclusão, Status de Conclusão e Percentual Concluído.
* **Subtarefas (Itens de Tarefas):** Permite adicionar, remover e concluir itens opcionais vinculados a uma determinada tarefa. Cada item exige Título e Status de Conclusão.
* **Regras de Negócio:**
  * A conclusão de itens altera automaticamente o percentual (%) de conclusão da tarefa principal.

---

## 🎬 Demonstração da Aplicação

*(Substitua a imagem abaixo pelo GIF ou prints das telas do seu projeto rodando)*

<div align="center">
  <img src="https://via.placeholder.com/800x450.png?text=Insira+aqui+o+GIF+ou+Print+das+telas+do+seu+sistema" alt="Demonstração do e-Agenda" />
</div>

---

## 🏗️ Arquitetura e Critérios Técnicos Atendidos

O projeto foi construído seguindo rigorosamente as diretrizes de qualidade exigidas na avaliação:

* **Modelo em 3 Camadas:** Separação física e lógica clara entre as responsabilidades de Apresentação, Domínio e Dados.
* **Organização de Código:** Classes de objetos bem definidas representando de forma coesa as entidades do domínio e View Models.
* **Persistência de Dados:** Implementada de forma robusta utilizando o **Entity Framework Core**.
* **Tratamento de Erros e Validações:** Camada de apresentação protegida através de validações consistentes com `ModelState` e o uso correto de `TagHelpers` do MVC.
* **Boas Práticas de Nomenclatura:** Código limpo com identificadores descritivos e aderência estrita aos padrões `PascalCase` e `camelCase`.
* **Reutilização de Código:** Estrutura otimizada para evitar repetições desnecessárias através do reaproveitamento eficiente de métodos e classes.

---

## ⚙️ Pipeline de CI/CD (GitHub Actions)

A esteira de automação do projeto garante a integração e a entrega contínua através das seguintes configurações:
* **Gatilhos Automáticos:** O pipeline é acionado de forma ágil a cada evento relevante de `push` ou `pull request`.
* **Workflow de Execução:** Configuração otimizada do ambiente de execução com o SDK do .NET 10, realizando o build e rodando os testes necessários.
* **Publicação em Nuvem:** Deploy automatizado tanto da aplicação quanto do banco de dados em ambiente de produção na nuvem.

---
