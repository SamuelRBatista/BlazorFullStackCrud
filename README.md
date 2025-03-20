# BlazorFullStackCrud

## Sobre o Projeto

BlazorFullStackCrud é um projeto de CRUD full stack utilizando Blazor no frontend e .NET no backend. O objetivo é fornecer uma aplicação completa com operações de criação, leitura, atualização e exclusão de dados.

## Tecnologias Utilizadas
- Blazor (WebAssembly)
- .NET (ASP.NET Core)
- Entity Framework Core
- MySQL ou SQL Server (Banco de Dados)
- Swagger (Documentação da API)

## Requisitos
- .NET SDK 8+
- Visual Studio Code ou Visual Studio
- MySQL ou SQL Server instalado

## Instalação e Execução

1. Clone o repositório:
   ```sh
   git clone https://github.com/seu-usuario/BlazorFullStackCrud.git
   cd BlazorFullStackCrud
   ```

2. Configure a string de conexão no `appsettings.json` dentro do projeto backend.

3. Execute as migrações para criar o banco de dados:
   ```sh
   dotnet ef database update
   ```

4. Inicie o backend:
   ```sh
   cd Backend
   dotnet run
   ```

5. Inicie o frontend:
   ```sh
   cd Frontend
   dotnet run
   ```

6. Acesse a aplicação em:
   ```
http://localhost:5000
   ```

## Funcionalidades
- Listagem de registros
- Criação de novos registros
- Edição de registros existentes
- Exclusão de registros

## Contribuição
Contribuições são bem-vindas! Para contribuir, siga os seguintes passos:
1. Fork o repositório
2. Crie uma branch para sua funcionalidade (`git checkout -b feature/nova-funcionalidade`)
