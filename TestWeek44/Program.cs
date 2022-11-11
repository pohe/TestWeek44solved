// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Weektest 44!");

Console.WriteLine("Opgave 1");

//TODO: Opgave 1
// Lav et For loop som udskriver tallene fra og med 15 til og med 25
// skriv din kode her

for (int i = 15; i<=25; i++)
{
    Console.Write(i + "  ");
}

Console.WriteLine("\nSlut på opgave 1");


Console.WriteLine("\nOpgave 2");
//TODO: Opgave 2
// Lav et WHILE loop som udskriver tallene fra og med 15 til og med 25
// skriv din kode her

int j = 15; 
while (j<= 25)
{
    Console.Write(j + "  ");
    j++;
}
Console.WriteLine("\nSlut på opgave 2");


Console.WriteLine("\nOpgave 3");
//TODO: Opgave 3
// Lav et FOR loop som beregner summen af tallene fra og med 15 til og med 25
// skriv din kode her
int sum = 0;
for (int i = 15; i <=25; i++)
{
    sum = sum + i; 
}
Console.WriteLine($"Summen af tallene fra og med 15 til og med 25 er : {sum}");
Console.WriteLine("Slut på opgave 3");

Console.WriteLine("\nOpgave 4");
// TODO: Opgave 4
// Lav et FOREACH loop som udskriver alle tallene i myFirstArray
// skriv din kode her

int[] myFirstArray = new int[7];

myFirstArray[0] = 34;
myFirstArray[1] = 12;
myFirstArray[2] = 1;
myFirstArray[3] = 7;
myFirstArray[4] = 2;
myFirstArray[5] = 9;
myFirstArray[6] = 7;


foreach (int i in myFirstArray)
{
    Console.Write(i + " ");
}
Console.WriteLine("\nSlut opgave 4");


Console.WriteLine("\nOpgave 5");
// TODO: Opgave 5
// Lav et FOR loop som beregner summen af tallene i myFirstArray
// skriv din kode her

int arraySum = 0;

for (int i = 0; i < myFirstArray.Length; i++)
{
    arraySum = arraySum + myFirstArray[i];
}

Console.WriteLine($"Summen af alle tallen i myFirstArray er: {arraySum}");

Console.WriteLine("Slut opgave 5");


Console.WriteLine("Opgave 6");
// TODO: Opgave 6
// Lav et FOREACH loop som udskriver tallene i listOfInt
// skriv din kode her

List<int> listOfInt = new List<int>();
listOfInt.Add(4);
listOfInt.Add(12);
listOfInt.Add(9);
listOfInt.Add(5);
listOfInt.Add(12);
listOfInt.Add(2);

foreach (int item in listOfInt)
{
    Console.Write(item + " ");
}
Console.WriteLine("\nSlut opgave 6");

Console.WriteLine("Opgave 7");
// TODO: Opgave 7
// Lav et FOR loop som beregner summen som af tallene i listOfInt
// skriv din kode her
int listSum = 0; 
for(int i = 0; i < listOfInt.Count; i++)
{
    listSum = listSum + listOfInt[i];
}
Console.WriteLine();
Console.WriteLine($"Summen af tallene i listOfInt: {listSum}");

Console.WriteLine("\nSlut opgave 7");


Console.WriteLine("Opgave 8");
// TODO: Opgave 8
// Lav et While loop som beregner summen som af alle de lige tal i listOfInt
// skriv din kode her
int listSumWhile = 0;
int k = 0;
while(k < listOfInt.Count)
{
    if (listOfInt[k] % 2 == 0)
        listSumWhile = listSumWhile + listOfInt[k];
    k++;
}

Console.WriteLine();
Console.WriteLine($"Summen af de lige tal i listOfInt: {listSumWhile}");
Console.WriteLine("\nSlut opgave 8");

Console.WriteLine("Opgave 9");
// TODO: Opgave 9
// Lav et loop som undersøger om tallet i variablen searchNumber findes i listOfInt
// Hvis tallet i searchNumber findes skal det udskrives at det findes. 
// Hvis tallet ikke findes skal det udskrives at searchNumber ikke findes
// skriv din kode her

int searchNumber = 5;
bool found = false; 
foreach (int item in listOfInt)
{
    if (searchNumber == item)
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine($"Tallet {searchNumber}  findes i listOfInt");
}
else
{
    Console.WriteLine($"Tallet {searchNumber}  findes ikke i listOfInt");
}
Console.WriteLine("\nSlut opgave 9");


Console.WriteLine("Opgave 10");
// TODO: Opgave 10
// Lav et loop som beregner hvor mange gange variablen aNumber findes i listOfInt
// skriv din kode her

int aNumber = 12;
int countOfaNumber = 0; 
foreach (int item in listOfInt)
{
    if (aNumber == item)
    {
        countOfaNumber++;
    }
}
Console.WriteLine($"Tallet {aNumber}  findes {countOfaNumber} gange i listOfInt");

Console.WriteLine("\nSlut opgave 10");

//TODO:Opgave 11
// Lav et loop der finder det højeste tal i listOfInt


//int highestNumber = int.MinValue;
if (listOfInt.Count > 0)
{
    int highestNumber = listOfInt[0];
    //foreach (int i10 in listOfInt)
    //{
    //    if (i10 > highestNumber)
    //        highestNumber = i10;
    //}

    for (int i = 1; i < listOfInt.Count; i++)
    {
        if (listOfInt[i]> highestNumber)
            highestNumber = listOfInt[i];
    }

    Console.WriteLine($"Highest number in listOfInt er {highestNumber}");

}
else
    Console.WriteLine("Lister er tom");


//TODO: Lav et loop der finder de to største tal i ListOfInt og udskriver resultatet
// Hjemmeopgave til torsdag
int highest1;//indeholder højeste tal
int highest2; //indeholder næst højeste
if (listOfInt.Count > 0)
{
    if (listOfInt.Count == 1)
        Console.WriteLine($"Højeste tal  {listOfInt[0]} der er {listOfInt.Count} tal i listen");
    else if (listOfInt.Count == 2)
    {
        if (listOfInt[0] > listOfInt[1])
            Console.WriteLine($"Højeste tal er {listOfInt[0]} og næst højest er {listOfInt[1]} der er {listOfInt.Count} tal i listen");
        else
            Console.WriteLine($"Højeste tal er {listOfInt[1]} og næst højest er {listOfInt[0]} der er {listOfInt.Count} tal i listen");
    }
    else
    {
        highest1 = listOfInt[0];
        highest2 = listOfInt[1];
        if ( highest1 < highest2)
        {
            //Byt om
            int temp = highest1;
            highest1 = highest2;
            highest2 = temp; 
        }
        for (int i = 2; i < listOfInt.Count; i++)
        {
            if (listOfInt[i]> highest1)
            {
                highest2 = highest1;
                highest1= listOfInt[i];
            } else if (listOfInt[i]> highest2)
            {
                highest2= listOfInt[i];
            }
        }
        Console.WriteLine($"Højeste tal er {highest1} og næst højest er {highest2} der er {listOfInt.Count} tal i listen");

    }



}





//    Console.WriteLine($"Højeste tal er {highest1} og næst højest er {highest2} der er {listOfInt.Count} tal i listen");

