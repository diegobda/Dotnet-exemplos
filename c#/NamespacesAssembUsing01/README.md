/*
 * -----------------------------------------------------------
 * Treinamento em C#
 * Autor: Diego dos Santos Gonçalves
 * Data: [29/11/2024]
 * Descrição: [Programação em C# - Namespaces, Assemblies e a Diretiva using - 01.]
 * -----------------------------------------------------------
 */



 --Namespaces:
 -Usado para organizar tipos (classes), permitindo evitar coliões de nomes.
Basicamente uma coleção nomeada de classes.

Boa prática: todas as classes devem ser definidas de um namespace

Ex.:
classe console
System.console

classe console (definida pelo usuário)
Namespace MinhasClasses
MinhasClasses.console


Diretiva using:
Diretivas using trazem os namespaces para para dentro do scopo de seu projeto;
Seu projeto; desta forma, não é necessário qualificar explicitamente os objetivos com o respectivo namespace.

Console.WriteLine()
System.Console.WriteLine

- ou seja, inclui outros namespace no programa


Assembly / Montagem
- As classes são compiladas em Assemblies - sao arquivos usualmente com a extessão dll
As classes mais comuns, System.Console pertencem a Assembly mscorlib.dll
Uma montagem pode conter classes definidas e varios namespaces, e um namespace pode ocupar vários assemblies
Para usarmos as classes de uma assembly, devemos adicionar uma referencia ao projeto, e incluir diretiva "using "adequada.

Referencias: 
Uma referencia permite que utilizemos tipos disponiveis em outros Assemblies, tanto do fcl quanto de terceiros.
FCL - Framework Class Library




