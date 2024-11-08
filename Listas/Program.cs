using System;
using System.Collections.Generic;

// jeito mais comum
List<string> list = new List<string>();

//colocando os valores direto na instanciação
List<string> nomes = new List<string>() { "Maria", "Luiza", "Alexandre" ,"Mateus", "Fernando" };

//colocando os valores direto na instanciação
List<int> ages = new() { 6, 18, 18, 19 };

//adição de elementos na lista
nomes.Add("João");
nomes.Add("Ana");


//a diferença entre o list.Add() e o list.Insert()
//é q o insert voce podespecificar qual a posição que irá colocar o elemento

ages.Insert(4, 19);

//retorna o tamanho da lista
Console.WriteLine(nomes.Count());

// o Find() ele tem como parametro uma função q faz a pesquisa
// ou pode passar uma expressão lambda no lugar da função, como no exemplo abaixo
string s1 = nomes.Find(x => x[0] == 'A');
Console.WriteLine("First 'A': " + s1);

string s2 = nomes.FindLast(x => x[0] == 'A');
Console.WriteLine(s2);

//string s1 = nomes.Find(FirtsLetterIsA);

//static bool FirtsLetterIsA(string a)
//{
//    return a[0] == 'A';
//}

//mostra a primeira posição dependente da condição que colocar
int position1 = nomes.FindIndex(x => x[0] == 'A');
Console.WriteLine(position1);

//mostra a ultima posição dependente da condição que colocar
int position2 = nomes.FindLastIndex(x => x[0] == 'A');
Console.WriteLine(position2);

// filtrar lista
List<string> filtro = nomes.FindAll(x => x.Length < 5);
foreach (string s in filtro)
{
    Console.WriteLine(s);
}

//remover elementos da lista
nomes.Remove("Ana");

//remove todos que atendam a(s) condições do predicado
nomes.RemoveAll(x => x[0] == 'M');

//remove pela posição
//nomes.RemoveAt(4);

//List.RemoveRange(posicaoInicial, contagem) ele remove a partir de uma posição e até uma contagem
ages.RemoveRange(2, 2);

foreach(string obj in nomes)
{
    Console.WriteLine(obj);
}

foreach(int obj in ages)
{
    Console.WriteLine(obj);
}