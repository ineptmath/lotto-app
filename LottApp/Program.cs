Random rnd = new Random();

//int RandomPicks(Int[], lowestValue, highestValue)

    int[] lottoNumbers = new int[8];
    for (int i = 0; i < lottoNumbers.Length; i++)
    {
        int rand = rnd.Next(1, 46);
        lottoNumbers[i] = rand;
        Console.WriteLine(lottoNumbers[i]);
    }

//debug
Console.WriteLine(lottoNumbers[5]);


int[] userPicks = new int[8];
for (int i = 0; i < userPicks.Length; i++)
    {
        Console.WriteLine("Enter a Lottery Number Selection 1-46: ");
        string userInput = Console.ReadLine();
        int result = Int32.Parse(userInput);
        userPicks[i] = result;

    }  

Array.Sort(lottoNumbers);
Array.Sort(userPicks);

//debug
for (int i = 0;i < lottoNumbers.Length; i++) { Console.WriteLine(userPicks[i]); Console.WriteLine(lottoNumbers[i]); }

int Search(int[] arr, int N, int x)
{
    for (int i = 0; i < N; i++)
    {
        if (arr[i] == x)
            return i;
    }
    return -1;
}

int find = Search(userPicks, userPicks.Length, lottoNumbers[7]);
if (find == -1)
    Console.WriteLine(
                "Element is not present in array");
else
    Console.WriteLine("Element is present at index "
                      + find);









/*


try
{
    string userInput = Console.ReadLine();
    int result = Int32.Parse(userPicks[]);
    Console.WriteLine(result);
}
catch (FormatException)
{
    Console.WriteLine($"Unable to parse, probably not a number '{input}'");
}


int[] userPicks;
for (int i = 0; i < userPicks.Length; i++)
*/