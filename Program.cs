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
        Note[] userList = new Note[100];
        int numberOfNotes = FillUserNotesReturnsNumberOfNotes(userList);
        // userList[0].price = "9999999";
        // userList[2].status = "hug";
        WriteOnFile(userList, numberOfNotes);

        return 0;
    }

    public static void WriteOnFile(Note[] userList, int numberOfNotes)
    {
        string[] structArrayInfo = new string[6 * numberOfNotes];
        int tempIndex = 0, listTempIndex = 0;
        while (tempIndex < numberOfNotes * 6 && listTempIndex < numberOfNotes)
        {
            structArrayInfo[tempIndex] = userList[listTempIndex].userInitials;
            ++tempIndex;
            structArrayInfo[tempIndex] = userList[listTempIndex].markAuto;
            ++tempIndex;
            structArrayInfo[tempIndex] = userList[listTempIndex].workType;
            ++tempIndex;
            structArrayInfo[tempIndex] = userList[listTempIndex].dateOfAcceptiom;
            ++tempIndex;
            structArrayInfo[tempIndex] = userList[listTempIndex].price;
            ++tempIndex;
            structArrayInfo[tempIndex] = userList[listTempIndex].status;
            ++tempIndex; ++listTempIndex;
        }

        File.WriteAllLines("UserNotes.txt", structArrayInfo);
    }

    public static int FillUserNotesReturnsNumberOfNotes(Note[] userList)
    {
        string[] stringList = File.ReadAllLines("UserNotes.txt");
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

    public static void FillStructArray(string[] structArrayInfo, Note oneNote)
    {
        structArrayInfo[0] = oneNote.userInitials;
        structArrayInfo[1] = oneNote.markAuto;
        structArrayInfo[2] = oneNote.workType;
        structArrayInfo[3] = oneNote.dateOfAcceptiom;
        structArrayInfo[4] = oneNote.price;
        structArrayInfo[5] = oneNote.status;
    }
}
