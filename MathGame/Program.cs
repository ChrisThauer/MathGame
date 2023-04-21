List<string> results = new List<string>();
bool playing = true;
string choice;
int difficulty = 1;

Console.WriteLine("Welcome to the Math Game");
Console.WriteLine("===========================");
SelectDifficulty();

while (playing)
{
    Play();
}
void Play()
{
    Console.WriteLine("");
    Console.WriteLine("A. Addition");
    Console.WriteLine("B. Subtraction");
    Console.WriteLine("C. Multiplication");
    Console.WriteLine("D. Division");
    Console.WriteLine("E. Change Difficulty");
    Console.WriteLine("F. View Results");
    Console.WriteLine("G. Exit");
    Console.Write("Please select an operation: ");
    choice = Console.ReadLine().ToLower();

    if (choice == "a")
    {
        AdditionTest();
    }
    else if (choice == "b")
    {
        SubtractionTest();
    }
    else if (choice == "c")
    {
        MultiplicationTest();
    }
    else if (choice == "d")
    {
        DivisionTest();
    }
    else if (choice == "e")
    {
        SelectDifficulty();
    }
    else if (choice == "f")
    {
        ViewResults();
    }
    else if (choice == "g")
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

void SubtractionTest()
{
    int a = GetRandom();
    int b = GetRandom();
    int answer = a - b;
    Console.WriteLine("");
    Console.Write($"What is the result of the following operation: {a} - {b}? ");
    int userAnswer = Convert.ToInt32(Console.ReadLine());
    DetermineResult(answer, userAnswer);
}

void DivisionTest()
{
    int a = GetRandom();
    int b = GetRandom();
    int answer = a / b;
    Console.WriteLine("");
    Console.Write($"What is the result of the following operation: {a} / {b} (rounded down)? ");
    int userAnswer = Convert.ToInt32(Console.ReadLine());
    DetermineResult(answer, userAnswer);
}

void MultiplicationTest()
{
    int a = GetRandom();
    int b = GetRandom();
    int answer = a * b;
    Console.WriteLine("");
    Console.Write($"What is the result of the following operation: {a} * {b}? ");
    int userAnswer = Convert.ToInt32(Console.ReadLine());
    DetermineResult(answer, userAnswer);
}

// Returns a random number between 1 and 100
int GetRandom()
{
    int maxNum;
    Random random = new Random();
    if (difficulty == 1 )
    {
        maxNum = 11;
    }
    else if (difficulty == 2 )
    {
        maxNum = 101;
    }
    else
    {
        maxNum = 1001;
    }
    return random.Next(1, maxNum);
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

void ViewResults()
{
    int correct = 0;
    int total = 0;
    results.ForEach(result =>
    {
        if (result == "Correct")
        {
            correct++;
        }
        total++;
    });

    Console.WriteLine("");
    Console.WriteLine("Results");
    Console.WriteLine("===============");
    for (int i = 0; i < results.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {results[i]}");
    }
    Console.WriteLine($"Total: {correct}/{total}");
    Console.WriteLine("");
}

void SelectDifficulty()
{
    Console.WriteLine("");
    Console.WriteLine("1. Easy");
    Console.WriteLine("2. Moderate");
    Console.WriteLine("3. Advanced");
    Console.Write("Please select your difficulty: ");
    int userChoice;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out userChoice))
        {
            if (userChoice == 1 || userChoice == 2 || userChoice == 3)
            {
                difficulty = userChoice;
                return;
            }
            else
            {
                Console.WriteLine("");
                Console.Write("Invalid selection. Please select your difficulty: ");
            }
        }
        else
        {
            Console.WriteLine("");
            Console.Write("Invalid selection. Please select your difficulty: ");
        }
    }
}