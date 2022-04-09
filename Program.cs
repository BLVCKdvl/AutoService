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
        string fileString = File.ReadAllText("UserNotes.txt");
        string[] stringList = fileString.Split(".\r\n");
        int tempIndex = 0;
        for (int i = 0; i < stringList.Length / 6; ++i)
        {
            userList[i].userInitials = stringList[tempIndex]; 
            ++tempIndex;
            userList[i].markAuto = stringList[tempIndex];
            ++tempIndex;
            userList[i].workType = stringList[tempIndex]; 
            ++tempIndex;
            userList[i].dateOfAcceptiom = stringList[tempIndex];
            ++tempIndex;
            userList[i].price = stringList[tempIndex]; 
            ++tempIndex;
            userList[i].status = stringList[tempIndex];
            ++tempIndex;
        }

        return stringList.Length / 6;
    }
}
