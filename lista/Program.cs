using System;
using System.Globalization;


List<string> list = new List<string>();

list.Add("Maria");
list.Add("ALEX");
list.Add("ROGER");
list.Add("TELMA");
list.Add("AMANDA");
list.Add("Maria");

list.Insert(2, "Marco"); // o insert adicona elementos na posição que vc determinar.


foreach(string nome in list)
{
    Console.WriteLine(nome);
}

Console.WriteLine("lista count:" +list.Count );
Console.WriteLine("----------------------");

string s1 = list.Find(X => X[0] == 'A'); // find localiza o primeiro elemento com  paramento escrito.
Console.WriteLine(" list A:" + s1);

string s2 = list.FindLast(X => X[0] == 'A');
Console.WriteLine(s2);

Console.WriteLine("----------------------");

int pos1 = list.FindIndex(x => x[0] == 'M'); // index localiza a posição do objeto/nome.
Console.WriteLine( "posição do primeiro nome que começa com M:" + pos1 );



int pos2 = list.FindLastIndex(x => x[0] == 'M');
Console.WriteLine("posição do ultimo nome que começa com M:"+ pos2);

Console.WriteLine("----------------------");

list.Remove("TELMA");  // remove um objeto/nome na lista.

foreach (String nome in list)
{
    Console.WriteLine(nome);
}

Console.WriteLine("-----------------------");

list.RemoveAll(x => x[0] == 'M'); // remove todos os nome/objeto de acordo o parametro digitado.
foreach (string nome in list)
{
    Console.WriteLine(nome);
}
Console.WriteLine("----------------------");

list.RemoveAt(0);

foreach( string nome in list)
{
    Console.WriteLine(nome);
}



// Matrize

double[,] mat = new double[2, 3];

// switch - case

int x = int.Parse(Console.ReadLine());
string day;

switch (x)
{
    case 1:
    day = " sunday";
      break;
    case 2:
    day = " monday";
      break;
    case 3:
    day = " tuesday";
      break;
    default:
    day =  " invalid day";
        break;
}
Console.WriteLine(" day" + day);


// espressao condicional Terná

var preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double desconto = (preco < 20) ? preco * 0.1 : preco * 0.5; // com a condicional ternária  vc resolver o problema em uma simoles linha de codigo
/*                                v          /      F
if(preco < 20)
{
    desconto = preco * 0.1;
}
else
{
    desconto = preco * 0.5;
} */

Console.WriteLine("seu desconto é de: " + desconto + " REAIS");

Console.WriteLine("----------------------------");

// funções interssantes para string
class Program
{
    static void Main(string[] args)
    {
        string letras = "abcf ADCB  TYBU aaaaa  ";

        string s8 = letras.ToUpper(); // converter toda a  string em Maiusculo.
        string s9 = letras.ToLower(); // converter todas a string em minusculo.
        string s6 = letras.Trim(); // acerta os epaços em branco.
        int n1 = letras.IndexOf("bc"); // informa a posição da estring.
        int n2 = letras.LastIndexOf("BU"); //

        Console.WriteLine(" letras -" + letras + "-");
        Console.WriteLine(" toupper -" + s8 + "-");
        Console.WriteLine("tolower -" + s9 + "-");
        Console.WriteLine(" trim -" + s6 + "-");
        Console.WriteLine(" indexof" + n1);
    }
}