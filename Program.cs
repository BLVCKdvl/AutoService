using System;
using System.IO;

public class Project
{
    public struct Note
    {
        public string userInitials,
            markAuto,
            workType,
            dateOfAcceptiom,
            price, 
            status;
    };

    public static int Main()
    {
        Note[] userlist = new Note[100];
        int numberOfNotes = FillUserNotesReturnsNumberOfNotes(userlist);
        return 0;
    }

    public static int FillUserNotesReturnsNumberOfNotes(Note[] userList)
    {
        string s = File.ReadAllText("UserNotesInput.txt");
        // Console.WriteLine(s);
        int i = 0;
        while (s[i] != '.')
        {
            ++i;
        }

        StreamWriter print = new StreamWriter("UserNotesOutput.txt", true);
        print.Write(s[0..i]);

        return 0;        
    }
}
