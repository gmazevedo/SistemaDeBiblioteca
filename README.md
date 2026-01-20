📚 Sistema de Biblioteca
--

Este projeto consiste em um sistema simples de biblioteca, desenvolvido com programação orientada a objetos, que simula o funcionamento básico de empréstimos de livros.

O sistema é operado por um bibliotecário, que pode visualizar os livros disponíveis, realizar empréstimos e encerrar o programa por meio de um menu interativo no console.

O objetivo principal é praticar conceitos fundamentais de POO, como classes, atributos, encapsulamento e relacionamento entre objetos.


🧱 Estrutura do Sistema
--

O sistema é composto por três classes principais:

### 📘 Livro

Representa um livro da biblioteca.

Atributos:
- ISBN do livro
- Título do livro
- Status (Disponível ou Emprestado)
- Nome do locatário (quando emprestado)

### 👤 Pessoa
Representa um usuário que pode pegar livros emprestados.

Atributos:
- ID
- Nome da pessoa
- Lista de livros em sua posse

### 🏛️ Biblioteca

Responsável por gerenciar os livros e as pessoas cadastradas.

Atributos:
- Lista de livros
- Lista de pessoas (locatários)

## 📋 Funcionalidades

O sistema apresenta um menu interativo com as seguintes opções:
1. Listar todos os livros
        
    Exibe todos os livros cadastrados na biblioteca, mostrando:
    - ISBN
    - Nome do livro
    - Status (Disponível ou Emprestado)
2. Emprestar um livro
    - Permite escolher um livro disponível
    - Exige o cadastro do locatário 
    - Atualiza o status do livro para Emprestado
3. Sair
    - Encerra a execução do sistema

---

### 👨‍💻 Projeto desenvolvido como exercício de aprendizado em Programação Orientada a Objetos no Programa de Formação CodeRDIversity - RDI.