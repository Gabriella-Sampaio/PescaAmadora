Console.Clear();

const double acreMulta = 20;
const double limiteM = 15;
const double limiteC = 10;
const double multa = 1000;
double pesoExcedido;

Console.Write("Peso do peixe (em kg): ");
string pesoString = Console.ReadLine()!.Replace(".", ",");
double peso;
bool pesoTrue = Double.TryParse(pesoString, out peso); //colocar opção

Console.Write("\nÁguas Continentais ou Marinhas? \nDigite [C] ou [M]: ");
string aguaString = Console.ReadLine()!.ToUpper();
bool aguaM = aguaString == "M";
bool aguaC = aguaString == "C";

aguaString = aguaC ? "Continental" : "Marinha"; 
/* DUAS OPÇÕES
uma sempre é verdadeira e outra sempre é falsa
independende de qual das duas colocar, a outra vai ser falsa então a string muda no resultado

                    Pergunta se     compara se é
                      é false       false ou true
 aguaString  =  aguaM   ?   "Marinha"   :  "Continental";
    Var        condição    val se verd      val se falso 

Se colocar M, a C automaticamente vai ser false, mudando a var string pra Marinha e executando o if 
Se colocar C, a M vai ser false, e a strig será Continental pq a C é a true (executa o else if)
Se ambas forem falsas o programa executa o else
Se colocar um "!" antes da var bool, ela inverte
*/

if (aguaM)
{
    Console.WriteLine($"\nAgua: {aguaString}");
    if (peso > limiteM)
    {
        pesoExcedido = peso - limiteM;
        Console.WriteLine($"\nPescaria excede os limites legais em {pesoExcedido:N3}kg \nSujeito a multa de {pesoExcedido * acreMulta + multa:C}");
    }

    else
    {
        Console.WriteLine("\nPescaria dentro dos limites legais");
    }
}

else if (aguaC)
{
    Console.WriteLine($"\nAgua: {aguaString}");
    if (peso > limiteC)
    {
        pesoExcedido = peso - limiteC;
        Console.WriteLine($"\nPescaria excede os limites legais em {pesoExcedido:N3}kg \nSujeito a multa de {pesoExcedido * acreMulta + multa:C}");
    }

    else
    {
        Console.WriteLine("\nPescaria dentro dos limites legais");
    }
}

else
{
    Console.WriteLine("Local não encontrado");
}

Console.WriteLine("\nVer tabela de valores de multa?\n");

Console.WriteLine("S. Sim");
Console.WriteLine("N. Sair");

String opcao = Console.ReadLine()!.ToUpper();

switch (opcao)
{
    case "S":
        Console.WriteLine(@"
––—————————————————————⌈⌉✓
");

        break;

    case "N":
        Console.WriteLine("ok");
        break;

    default:
        Console.WriteLine("");
        break;
}


Console.WriteLine("\nObrigada");

