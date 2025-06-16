# Alpha Project

Sistema de gerenciamento de produtos, com backend em .NET Core e frontend em Vue 3, utilizando integração com banco de dados SQL Server.

---

## 🧱 Tecnologias Utilizadas

### Backend
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server

### Frontend
- Vue 3 + Vite
- Axios
- TailwindCSS
- Vue Router

---

## ⚙️ Requisitos

- .NET SDK 7.0 ou superior
- Node.js 18+
- SQL Server
- VS Code (opcional, mas recomendado)

---

## 🗄️ Configuração do Banco de Dados

1. Certifique-se de que o SQL Server está instalado e rodando.
2. Crie o banco de dados manualmente ou via migrations:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
Swagger
Acesse a documentação da API em:
http://localhost:5193/swagger

Como executar o projeto:

1. dotnet restore
2. dotnet run

