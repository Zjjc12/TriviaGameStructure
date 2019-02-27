using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class QuestionDatabase
{
    public static List<string> questions;
    public static List<string> choice1s;
    public static List<string> choice2s;
    public static List<string> choice3s;
    public static List<string> choice4s;
    public static List<string> answers;

    public static void ImportGame(string path)
    {
        using (var reader = new StreamReader(@path))
        {
            List<string> questions = new List<string>();
            List<string> choice1s = new List<string>();
            List<string> choice2s = new List<string>();
            List<string> choice3s = new List<string>();
            List<string> choice4s = new List<string>();
            List<string> answers = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                questions.Add(values[0]);
                choice1s.Add(values[1]);
                choice2s.Add(values[2]);
                choice3s.Add(values[3]);
                choice4s.Add(values[4]);
                answers.Add(values[5]);
            }
        }
    }

}
