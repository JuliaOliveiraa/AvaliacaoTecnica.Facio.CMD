# Teste de Resolução de Dependências

Este é um teste que envolve a resolução de dependências em um projeto.

## Enunciado

Um projeto tem uma lista de dependências que precisam ser instaladas. Cada dependência pode ter suas próprias dependências. O objetivo é determinar a ordem correta de instalação das dependências.

Exemplo:

Projeto X: Dependências A, B, C, D, E

Dep. A: Dependências B, C

Dep. D: Dependência E

Ordem correta de instalação: E, C, B, D, A

## Explicação

A resolução de dependências é um problema comum em desenvolvimento de software. Quando há uma hierarquia de dependências, é importante instalar as dependências na ordem correta para garantir que todos os componentes funcionem adequadamente.

Neste teste, utilizei uma estrutura de dados chamada dicionário para representar as dependências. No dicionário, cada dependência é mapeada para uma lista de suas dependências dependentes.

Para determinar a ordem correta de instalação das dependências, utilizei uma técnica chamada busca em profundidade (DFS - Depth-First Search). Começamos com uma dependência inicial e percorremos recursivamente suas dependências dependentes, seguindo a hierarquia de dependências até encontrar todas as dependências necessárias. Em seguida, repetimos o processo para as dependências dependentes, garantindo que todas as dependências sejam visitadas corretamente.

## Como Executar o Projeto

1. Certifique-se de ter o ambiente de desenvolvimento configurado com o .NET Framework.
2. Faça o download ou clone o repositório.
3. Abra o projeto em sua IDE preferida.
4. Compile o projeto para garantir que não haja erros de compilação.
5. Execute o projeto.
6. Siga as instruções no console para inserir as dependências.
7. Após inserir todas as dependências, o programa exibirá a ordem correta de instalação das dependências.


## Obs

- As entradas desse projeto *não são case sensitive*;

#### Deixo meu email para caso tenha mais duvidas: [Julia Oliveira](oliveiradesilvajulia@gmail.com) :wink:


