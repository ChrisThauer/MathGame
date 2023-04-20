string[] results;
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

    if (choice == "f")
    {
        playing = false;
    }
};