using System.Collections.Generic;

List<string> words = new List<string>();

while (true)
{
    Console.WriteLine("1: add; 2: print; 3: add checkmark; 4: delete; 5: exit");
    int action = Convert.ToInt32(Console.ReadLine());

    if (action == 1)
    {
        Console.WriteLine("Enter what you want to add");
        string x = Console.ReadLine();
        words.Add(x);
    }
    if (action == 2)
    {
        foreach (string i in words)
        {
            Console.WriteLine(i);
        }
    }
    if (action == 3)
    {
        Console.WriteLine("Which action do you want to mark as successful ");
        int user = Convert.ToInt32(Console.ReadLine());
        int index = user - 1;
        words[index] = "[Done] " + words[index];
    }
    if (action == 4)
    {
        Console.WriteLine("Choose which to delete");
        int user = Convert.ToInt32(Console.ReadLine());
        int index = user - 1;
        words.RemoveAt(index);
    }

    if (action == 5)
    {
        break;
    }
    else
    {
        Console.WriteLine("Error, please try again");
    }
}