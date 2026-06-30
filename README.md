# ProjetoBanco2025 - EG ACADEMY

Sistema desktop desenvolvido em **C# Windows Forms** para gerenciamento de alunos de uma academia, com integração a banco de dados local via **XAMPP/phpMyAdmin**.

## Descrição

O projeto **ProjetoBanco2025** é uma aplicação Windows Forms criada no Visual Studio com o objetivo de realizar operações de cadastro, consulta, edição e exclusão de alunos.

A aplicação possui uma tela inicial da **EG ACADEMY**, com acesso à área de alunos e à área de usuários. A funcionalidade principal implementada está no gerenciamento de alunos, utilizando uma camada de interface, uma classe de modelo e uma camada de acesso a dados.

## Tecnologias utilizadas

- C#
- .NET Framework 4.7.2
- Windows Forms
- Visual Studio
- MySQL/MariaDB
- MySql.Data
- ADO.NET
- phpMyAdmin

## Funcionalidades

- Tela inicial com acesso aos módulos do sistema
- Cadastro de alunos
- Consulta de alunos cadastrados
- Pesquisa de alunos por nome
- Edição de dados de alunos
- Exclusão de alunos
- Integração com banco de dados MySQL/MariaDB
- Organização do projeto em camadas de interface, modelo e acesso a dados

## Estrutura do projeto

```text
ProjetoBanco2025/
├── ProjetoBanco2025.sln
├── ProjetoBanco2025/
│   ├── BLL/
│   │   └── Aluno.cs
│   ├── DAL/
│   │   ├── AlunoDAL.cs
│   │   ├── Conexao.cs
│   │   └── UsuarioDAL.cs
│   ├── UI/
│   │   ├── Form1.cs
│   │   ├── FrmAluno.cs
│   │   └── FrmUsuario.cs
│   ├── Program.cs
│   ├── App.config
│   ├── packages.config
│   └── ProjetoBanco2025.csproj
└── bdacademia.sql
```

## Principais arquivos

### `Form1.cs`

Tela inicial do sistema, com botões para acesso ao módulo de alunos e ao módulo de usuários.

### `FrmAluno.cs`

Tela responsável pelo gerenciamento dos alunos. Nela são realizadas as operações de cadastro, consulta, pesquisa, edição e exclusão.

### `Aluno.cs`

Classe de modelo que representa os dados do aluno, como código, nome, CPF, RG, e-mail e data de nascimento.

### `AlunoDAL.cs`

Classe responsável pela comunicação com o banco de dados para executar as operações de cadastro, consulta, pesquisa, atualização e exclusão de alunos.

### `Conexao.cs`

Classe responsável por abrir e fechar a conexão com o banco de dados MySQL/MariaDB.

### `bdacademia.sql`

Script SQL utilizado para criação do banco de dados e das tabelas necessárias para o funcionamento do sistema.

## Banco de dados

O projeto utiliza o banco de dados `bdacademia`.

As principais tabelas são:

- `aluno`
- `usuario`

A tabela `aluno` armazena informações como:

- código do aluno
- nome
- CPF
- RG
- e-mail
- data de nascimento

## Como executar o projeto

1. Clone este repositório:

```bash
git clone https://github.com/SEU-USUARIO/NOME-DO-REPOSITORIO.git
```

2. Abra o arquivo `.sln` no Visual Studio:

```text
ProjetoBanco2025.sln
```

3. Importe o arquivo `bdacademia.sql` no MySQL/MariaDB utilizando o phpMyAdmin ou outro gerenciador de banco de dados.

4. Confira a string de conexão no arquivo:

```text
ProjetoBanco2025/DAL/Conexao.cs
```

Exemplo de conexão utilizada no projeto:

```csharp
server=localhost;
database=bdacademia;
uid=root;
pwd='';
```

5. Restaure os pacotes NuGet, se necessário.

6. Compile e execute o projeto pelo Visual Studio.

## Observações sobre versionamento

Antes de publicar o projeto no GitHub, recomenda-se não enviar arquivos gerados automaticamente pelo Visual Studio, como:

```text
.vs/
bin/
obj/
packages/
*.user
*.suo
*.exe
*.dll
Thumbs.db
```

Também é recomendado evitar o envio de dados sensíveis ou dados pessoais reais no arquivo SQL.

## Status do projeto

Projeto desenvolvido para fins acadêmicos, com foco no aprendizado de C#, Windows Forms, integração com banco de dados e organização de código em camadas.

## Autor

Desenvolvido por **SEU NOME**.
