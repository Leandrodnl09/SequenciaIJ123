// Exercício do site URI "Seqência I J 2"

// for (int i = 1; i <= 9; i += 2)
// {
//     for (int j = 7; j >= 5; j--)
//     {
//         Console.WriteLine("I=" + i + " J=" + j);
//     }
// }

int j = 7;
for (int i = 1; i <= 9; i = i + 2)
{
    Console.WriteLine("I=" + i + " J=" + j);
    Console.WriteLine("I=" + i + " J=" + (j - 1));
    Console.WriteLine("I=" + i + " J=" + (j - 2));
    j = j + 2;
}
