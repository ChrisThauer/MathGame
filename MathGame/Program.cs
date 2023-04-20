List<string> results = new List<string>();
bool playing = true;
string choice;

Console.WriteLine("Welcome to the Math Game");
Console.WriteLine("===========================");

while (playing)
{
    Play();
}
void Play()
{
    Console.WriteLine("A) Addition");
    Console.WriteLine("B) Subtraction");
    Console.WriteLine("C) Multiplication");
    Console.WriteLine("D) Division");
    Console.WriteLine("E) View Results");
    Console.WriteLine("F) Exit");
    Console.Write("Please select an operation: ");
    choice = Console.ReadLine().ToLower();

    if (choice == "a")
    {
        AdditionTest();
    }
    if (choice == "f")
    {
        playing = false;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Please select a valid option");
        Console.WriteLine("");
    }
};

void AdditionTest()
{
    int a = GetRandom();
    int b = GetRandom();
    int answer = a + b;
    Console.WriteLine("");
    Console.Write($"What is the result of the following operation: {a} + {b}? ");
    int userAnswer = Convert.ToInt32(Console.ReadLine());
    DetermineResult(answer, userAnswer);
}

// Returns a random number between 1 and 100
int GetRandom()
{
    Random random = new Random();
    return random.Next(1, 101);
}

// Determines if result is correct and adds it to the results list
void DetermineResult(int answer, int userAnswer)
{
    if (answer == userAnswer)
    {
        Console.WriteLine("");
        Console.WriteLine("You answered correctly!");
        results.Add("Correct");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine($"Sorry, you answered incorrectly. The correct answer was {answer}");
        results.Add("Incorrect");
    }
}