
# 🎬 Meus Filmes Favoritos

Projeto simples em .NET para salvar seus filmes favoritos no banco de dados.  
Desenvolvido com foco em boas práticas como SOLID, Clean Code e arquitetura Vertical Slice.

---

## 🚀 Tecnologias Utilizadas

- 💻 C#
- 🧱 .NET
- 🗂️ MediatR
- 🛠️ Entity Framework
- 🐬 MySQL

---

## 🧱 Arquitetura

O projeto segue o padrão **Vertical Slice Architecture**, separando a lógica de cada funcionalidade em "fatias", ao invés de camadas tradicionais (controller/service/repository).  
Além disso, utiliza os princípios **SOLID** e práticas de **Clean Code** para um código mais limpo e manutenível.

---

## 📁 Estrutura do Projeto

```
Movies.API/
├── Domain
│ └── Entities
│ └── Movies.cs
├── Features
│ └── Movies
│ ├── Commands
│ │ ├── Create
│ │ ├── Delete
│ │ └── Update
│ └── Queries
│ └── GetAllMovies
├── Infrastructure
│ └── Data
│ └── MoviesDbContext.cs
│ └── Migrations
│ ├── [timestamp]_Initial.cs
│ └── MoviesDbContextModelSnapshot.cs
├── appsettings.json
├── Movies.API.http
└── Program.cs

```

---

## ⚙️ Como Executar

### Pré-requisitos

- .NET 8 SDK instalado
- Banco de dados MySQL configurado
- (Opcional) Visual Studio ou VS Code

### Passos para rodar

```bash
# Clone o repositório
git clone https://github.com/4n4n14s/MyFavoriteMovie

# Acesse a pasta
cd meus-filmes-favoritos

# Restaure os pacotes
dotnet restore

# Rode a aplicação
dotnet run --project src/Movies.API
```

---

## 📡 Endpoints da API

| Método | Rota                        | Descrição                          |
|--------|-----------------------------|-------------------------------------|
| GET    | `/movies`                  | Lista todos os filmes salvos       |
| POST   | `/SaveMovie`              | Salva um novo filme                |
| PUT    | `/editMovie/{UUId}`       | Edita um filme existente           |
| DELETE | `/DeleteMovie/{UUId}`     | Remove um filme pelo ID            |

---

## 📦 Exemplo de Payload para POST

```json
{
  "title": "O Poderoso Chefão",
  "Genre" : "Action",
  "year": 1972
}
```

---

## 🧪 Testes

> *Este projeto ainda não possui testes automatizados implementados.*

---

## 🤝 Contribuição

Este é um projeto de estudo e demonstração.  
Sinta-se à vontade para clonar, adaptar ou contribuir com melhorias!

---

## 📄 Licença

Este projeto está sob a licença MIT.
