using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Chat chat = new Chat();

        
        ChatParticipant participant1 = new ChatParticipant("Учасник 1");
        chat.AddObserver(participant1);

        ChatParticipant participant2 = new ChatParticipant("Учасник 2");
        chat.AddObserver(participant2);

        
        chat.SendMessage("Привіт всім!", "Автор");

        
        chat.RemoveObserver(participant2);

        
        chat.SendMessage("Як справи?", "Автор");

        Console.ReadLine();
    }
}