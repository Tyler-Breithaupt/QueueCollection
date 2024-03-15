using System;
using System.Collections.Generic;

namespace QueueCollection;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> familyMembers = new Queue<string>();

        familyMembers.Enqueue("Tino");
        familyMembers.Enqueue("Stacie");
        familyMembers.Enqueue("Ashley");
        familyMembers.Enqueue("Amanda");
        familyMembers.Enqueue("Tyler");

        string specificMember = "Ashley";
        bool containsItem = familyMembers.Contains(specificMember);
        Console.WriteLine($"Queue {(containsItem ? "contains" : "does not contain")} the member: {specificMember}");

        string removedMember = familyMembers.Dequeue();
        Console.WriteLine($"Removed member from the queue: {removedMember}");

        int memberCount = familyMembers.Count;
        Console.WriteLine($"Number of members in the queue: {memberCount}");

        Console.WriteLine("Members in the queue:");
        foreach (var member in familyMembers)
        {
            Console.WriteLine(member);
        }
    }
}

