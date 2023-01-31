//Exercise One

bool repeat = true;
do
{
    Console.Write("Enter a sentence: ");
    string userSentence = Console.ReadLine();
    string[] userSplit = userSentence.Split(' ');
    for (int i = 0; i < userSplit.Length; i++)
    {
        Console.WriteLine(userSplit[i]);
    }

    string answer;
    do
    {
        Console.Write("would you like to continue (y/n)? ");
        answer = Console.ReadLine();
        if (answer == "n")
        {
            Console.WriteLine("Goodbye!\n");
            repeat = false;
        }
        else if (answer != "y")
        {
            Console.WriteLine("I'm sorry, that isn't a valid response.");
        }
    } while (answer != "y" && answer != "n");

} while (repeat == true);

//Exercise Two

repeat = true;

List<string> userWords = new List<string>();
do
{
    Console.Write("Enter some text: ");
    string userWord = Console.ReadLine();
    userWords.Add(userWord);
    Console.Write("You have entered: ");
    foreach (string word in userWords)
    {
        Console.Write(word + " ");
    }

    Console.WriteLine(); //just a spacer

    string answer;
    do
    {
        Console.Write("would you like to continue (y/n)? ");
        answer = Console.ReadLine();
        if (answer == "n")
        {
            Console.WriteLine("Goodbye!");
            repeat = false;
        }
        else if (answer != "y")
        {
            Console.WriteLine("I'm sorry, that isn't a valid response.");
        }
    } while (answer != "y" && answer != "n");



} while (repeat == true);