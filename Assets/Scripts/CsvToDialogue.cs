using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CsvToDialogue
{
    static string csvFile = "Assets/Ludum Dare Team 5 Dialogue - Sheet1.csv";
    static FileInfo theSourceFile = null;
    static StreamReader reader = null;

    public static string pullColumn(int colNum)
    {

        theSourceFile = new FileInfo(csvFile);
        reader = theSourceFile.OpenText();

        for (int x = 0; x < colNum - 1; x++)
        {
            reader.ReadLine();
        }

        string fullCol = reader.ReadLine();

        int temp = 0;
        for (int x = 0; x < fullCol.Length; x++)
        {
            if (fullCol[x] == ',')
            {
                temp = x;
                break;
            }
        }

        fullCol = fullCol.Substring(temp + 1);
        fullCol = fullCol.Remove(fullCol.Length - 1, 1);
        if (fullCol.StartsWith("\""))
        {
            fullCol = fullCol.Remove(0, 1);
            fullCol = fullCol.Remove(fullCol.Length - 1, 1);
        }

        return fullCol;
    }
}