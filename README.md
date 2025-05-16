# hospital_api

Esta é uma API REST simples desenvolvida em **.NET Core** que permite o **registo, edição e consulta de pacientes**. A aplicação segue uma estrutura MVC básica e foi criada para fins de aprendizagem e evolução contínua.

## 🚀 Funcionalidades atuais

- Criar paciente com validações básicas (data de nascimento e NIF).
- Editar informações de um paciente existente.
- Ver detalhes de um paciente específico (com cálculo automático da idade).
- Listar todos os pacientes.
- Separação clara entre Models, ViewModels e Controllers.
- Validação de NIF com regras personalizadas.

## 🏗 Estrutura do Projeto

- `Model/`: Contém as entidades da aplicação (`Paciente`, `Medico`, `Enfermeiro`, etc.).
- `ViewModel/`: Representações dos dados para input/output da API.
- `Controllers/`: Lógica da API com endpoints RESTful.
- `DB/`: (Reservado para integração com base de dados no futuro).

## 💡 Futuras melhorias

- 🔌 **Persistência de dados** com uma base de dados relacional (ex: SQL Server, PostgreSQL).
- 🧱 **Implementação de arquitetura de microserviços**:
  - Serviço de Pacientes
  - Serviço de Profissionais de Saúde
  - Serviço de Autenticação (futuramente)
- 🔐 Autenticação e autorização com JWT.
- 🖥 Interface gráfica (em desenvolvimento com WinForms).
- 🧪 Testes automatizados para garantir qualidade e estabilidade.

## 🛠 Tecnologias

- [.NET Core 7+](https://dotnet.microsoft.com/)
- ASP.NET Web API
- WinForms (interface cliente, em desenvolvimento)
- C#

## 📦 Como executar

1. Clona este repositório:
   ```bash
   git clone https://github.com/seu-utilizador/hospital-api.git
