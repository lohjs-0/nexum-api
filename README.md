<div align="center">

# 🔗 Nexum API
*Uma API REST para gerenciamento de contratos construída com ASP.NET Core & C#*

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/pt-br/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?style=for-the-badge&logo=postgresql&logoColor=white)](https://www.postgresql.org/)
[![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io/)

</div>

---

## 📖 Sobre

*Nexum* (do latim: nexum — um contrato vinculante) é uma API REST para gerenciamento de contratos construída com ASP.NET Core como parte de uma jornada de aprendizado Full Stack focada em C#. O projeto foi desenvolvido para ser limpo, bem estruturado e escalável — servindo tanto como um estudo prático quanto como base para versões futuras mais completas.

---

## ✅ Funcionalidades

- *CRUD* completo para contratos (Criar, Ler, Atualizar, Deletar)
- Busca de contratos individuais *por ID*
- *Documentação interativa da API* via Swagger UI
- Estruturado com *separação de responsabilidades*
- Pronto para evoluir para um sistema em nível de produção

---

## 🛠️ Stack Tecnológica

| Camada         | Tecnologia                        |
|----------------|-----------------------------------|
| Linguagem      | C#                                |
| Framework      | ASP.NET Core Web API (.NET 8)     |
| ORM            | Entity Framework Core             |
| Banco de Dados | PostgreSQL                        |
| Documentação   | Swagger / OpenAPI                 |
| Versionamento  | Git & GitHub                      |

---

## 📦 Como Executar

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)

### Configuração

```bash
# Clonar o repositório
git clone https://github.com/seu-usuario/nexum-api.git

# Entrar na pasta do projeto
cd nexum-api

# Restaurar dependências
dotnet restore
```

Configure a conexão com o banco de dados em `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=nexum;Username=seu_usuario;Password=sua_senha"
}
```

Aplicar migrações e executar:

```bash
# Aplicar migrações do banco de dados
dotnet ef database update

# Iniciar o servidor
dotnet run
```

A API estará disponível em `https://localhost:5001`.  
Swagger UI: `https://localhost:5001/swagger`

---

## 📡 Endpoints

| Método | Rota                   | Descrição                      |
|--------|------------------------|--------------------------------|
| GET    | /api/contracts         | Listar todos os contratos      |
| GET    | /api/contracts/{id}    | Buscar um contrato por ID      |
| POST   | /api/contracts         | Criar um novo contrato         |
| PUT    | /api/contracts/{id}    | Atualizar um contrato existente|
| DELETE | /api/contracts/{id}    | Deletar um contrato            |

### Exemplo de requisição — Criar um contrato

```http
POST /api/contracts
Content-Type: application/json

{
  "title": "Contrato de Serviço",
  "description": "Consultoria mensal",
  "startDate": "2026-04-01",
  "endDate": "2026-12-31"
}
```

### Exemplo de resposta

```json
{
  "id": 1,
  "title": "Contrato de Serviço",
  "description": "Consultoria mensal",
  "startDate": "2026-04-01",
  "endDate": "2026-12-31",
  "createdAt": "2026-03-17T12:00:00Z"
}
```

---

## 🧱 Estrutura do Projeto

```
nexum-api/
├── Controllers/       # Handlers das rotas da API
├── Models/            # Definições de entidades
├── DTOs/              # Objetos de Transferência de Dados
├── Repositories/      # Camada de acesso a dados
├── Services/          # Lógica de negócio
├── Migrations/        # Migrações do banco via EF Core
└── Program.cs         # Ponto de entrada e configuração da aplicação
```

---

## 🎯 Objetivo

Este projeto foi desenvolvido para praticar e consolidar:

- Construção de *APIs REST* com ASP.NET Core
- Uso do *Entity Framework Core* e migrações de banco de dados
- Aplicação de *boas práticas em C#* em um contexto real
- Estruturação de uma *base de código escalável e manutenível*
- Documentação de APIs com *Swagger / OpenAPI*