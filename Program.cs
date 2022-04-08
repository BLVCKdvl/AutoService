using System;
using System.IO;

public class Project
{
    public struct Note
    {
        string userInitials;
        string markAuto;
        string workType;
        string dateOfAcceptiom;
        string price;
        string status;
    };
    public static int Main()
    {
        Note[] userlist = new Note[100];
        int numberOfNotes = FillUserNotesReturnsNumberOfNotes(userlist);

        return 0;
    }

    public static int FillUserNotesReturnsNumberOfNotes(Note[] userList)
    {
        //ifstream fin("ClientsNotesInput.txt", ios_base::in);
        string s = File.ReadAllText("UserNoteInput.txt");
        Console.WriteLine(s);
        return 0;
        //    int i = 0;
        //    while (!fin.eof())
        //    {
        //        fin >> userList[i].userInitials >> userList[i].markAuto
        //            >> userList[i].workType >> userList[i].dateOfAcceptiom
        //            >> userList[i].price >> userList[i].status;
        //        ++i;
        //    }

        //    fin.close();
        //    return i + 1;
        //}
    }
}
