# Controle Financeiro MVC

## Descrição

- Este projeto é uma aplicação de controle financeiro desenvolvida em C# utilizando a arquitetura MVC (Model-View-Controller) e Entity Framework para a criação e manipulação do banco de dados. O sistema simula uma planilha de controle financeiro, permitindo o gerenciamento de pessoas e lançamentos financeiros associados a elas.

## Tecnologias Utilizadas
- Linguagem: C#
- Arquitetura: MVC (Model-View-Controller)
- ORM: Entity Framework
- Banco de Dados: SQL Server

## Funcionalidades

### Modelos

#### Pessoa:
- Cadastro de pessoas com informações como Nome e CPF.
- Edição e exclusão de pessoas.
- Ao excluir uma pessoa, todos os lançamentos associados a ela também são excluídos.

#### Lancamento:
- Criação de lançamentos financeiros associados a uma pessoa cadastrada.
- Edição, visualização de detalhes e exclusão de lançamentos.
- Cada lançamento inclui informações como data da compra, banco, valor e descrição.

### Fluxo de Uso

#### Cadastro de Pessoa:
- O usuário deve cadastrar uma nova pessoa com Nome e CPF.
- Após o cadastro, a pessoa estará disponível para associar a lançamentos financeiros.

#### Cadastro e Gerenciamento de Lançamentos:
- O usuário pode criar, editar e excluir lançamentos financeiros.
- Para criar um lançamento, é necessário selecionar uma pessoa já cadastrada e fornecer informações sobre a data da compra, banco, valor e descrição.
