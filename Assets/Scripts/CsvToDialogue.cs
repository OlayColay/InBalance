using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;


/*
 * If you want to use the pullColumn function to get dialogue from the CSV file
 * Call CsvToDialgoue.pullColumn(n) where n is the column you want to get.
 * It will return a string with that column
 * Dont call a column that doesnt exist
 * Dont subtract one from the column number
 */
public class CsvToDialogue
{
    static string SPLIT_RE = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))";
    static string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";
    static char[] TRIM_CHARS = { '\"' };

    static List<Dictionary<string, object>> list;
 
    public static string pullColumn(int num)
    {
        if (list == null)
            CreateList();
    
        return list[num-2]["Actual Text (There will be a character limit but IDK what it is yet)"].ToString();
    }

    private static void CreateList()
    {
        list = new List<Dictionary<string, object>>();
        TextAsset data = Resources.Load ("Ludum Dare Team 5 Dialogue") as TextAsset;
 
        var lines = Regex.Split (data.text, LINE_SPLIT_RE);
 
        if(lines.Length <= 1) return;
 
        var header = Regex.Split(lines[0], SPLIT_RE);
        for(var i=1; i < lines.Length; i++) {
 
            var values = Regex.Split(lines[i], SPLIT_RE);
            // if(values.Length == 0 ||values[0] == "") continue;
 
            var entry = new Dictionary<string, object>();
            for(var j=0; j < header.Length && j < values.Length; j++ ) {
                string value = values[j];
                value = value.TrimStart(TRIM_CHARS).TrimEnd(TRIM_CHARS).Replace("\\", "");
                object finalvalue = value;
                int n;
                float f;
                if(int.TryParse(value, out n)) {
                    finalvalue = n;
                } else if (float.TryParse(value, out f)) {
                    finalvalue = f;
                }
                entry[header[j]] = finalvalue;
            }
            list.Add (entry);
        }
    }
}
