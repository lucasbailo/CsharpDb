# 🎵 ScreenSound API

Projeto desenvolvido com o objetivo de praticar a criação de **APIs Mínimas em ASP.NET Core**, aplicando boas práticas de organização, documentação e manutenção de código.

---

## 🚀 Objetivos do Projeto

- ✅ Estruturar um projeto **Console** para consumir e expor dados em uma **Web API**  
- ✅ Conhecer e aplicar recursos da biblioteca **ASP.NET Core**  
- ✅ Desenvolver uma **API Mínima** para o projeto **ScreenSound**  
- ✅ Aplicar boas práticas no contexto de API Web para manter o código organizado e sustentável  
- ✅ Aprender a documentar a API utilizando **Swagger**  

---

## 🛠️ Tecnologias Utilizadas

- [.NET 8 ](https://dotnet.microsoft.com/)
- [ASP.NET Core Minimal API](https://learn.microsoft.com/aspnet/core/fundamentals/minimal-apis)
- [Entity Framework Core](https://learn.microsoft.com/ef/core/) (para persistência de dados)
- [Swagger / Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) (para documentação da API)
- [Microsoft.Data.SqlClient 5.1.6](https://www.nuget.org/packages/Microsoft.Data.SqlClient/)  
- [Entity Framework Core 9.0.8](https://learn.microsoft.com/ef/core/)  
  - `SqlServer` (provedor de banco de dados)  
  - `Design` e `Tools` (migrações via CLI)  
  - `Proxies` (lazy loading)  

---

## 🏗️ Arquitetura da Solução

O projeto segue uma arquitetura em camadas inspirada no **DDD (Domain-Driven Design)** e boas práticas de separação de responsabilidades:

## 📂 Estrutura do Projeto

```bash
📂 ScreenSound.sln
┣ 📂 ScreenSound.API # Camada de apresentação (Minimal API)
┃ ┣ 📂 Endpoints # Endpoints REST da API
┃ ┣ 📂 Requests # DTOs de entrada
┃ ┣ 📂 Response # DTOs de saída
┃ ┣ 📜 Program.cs # Configuração inicial da API
┃ ┗ 📜 appsettings.json # Configurações (string conexão, etc.)
┣ 📂 ScreenSound.Shared.Dados # Camada de acesso a dados
┃ ┣ 📂 Banco # DbContext e repositórios (DAL)
┃ ┗ 📂 Migrations # Histórico de migrações EF Core
┣ 📂 ScreenSound.Shared.Modelos # Entidades de domínio
┃ ┗ 📂 Modelos # Classes: Artista, Genero, Musica
```

Essa divisão permite:
- Independência entre entidades de negócio e persistência
- Facilidade para testar e dar manutenção
- Evoluir endpoints sem quebrar regras de negócio
