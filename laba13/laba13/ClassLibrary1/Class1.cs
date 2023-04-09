using System;
using System.Collections.Generic;


public interface IObserver
{
    void Update(string message, string author);
}


public class Chat
{
    private List<IObserver> observers = new List<IObserver>();

    
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    
    public void SendMessage(string message, string author)
    {
        Console.WriteLine($"{author}: {message}");
        NotifyObservers(message, author);
    }

    
    private void NotifyObservers(string message, string author)
    {
        foreach (var observer in observers)
        {
            observer.Update(message, author);
        }
    }
}


public class ChatParticipant : IObserver
{
    private string name;

    public ChatParticipant(string name)
    {
        this.name = name;
    }

    
    public void Update(string message, string author)
    {
        Console.WriteLine($"{name} отримав(ала) повідомлення від {author}: {message}");
    }
}