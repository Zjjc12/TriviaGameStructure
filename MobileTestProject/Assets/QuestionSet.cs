using System.Collections;
using System.Collections.Generic;
using System;

public class QuestionSet
{
    private string question;
    private string choice1;
    private string choice2;
    private string choice3;
    private string choice4;
    private string answer;

    private Categories category;


    public enum Categories
    {
        CompetitveEvents,
        BusinessSkills,
        AboutFBLA,
        FBLAHistory,
        NationalOfficers
    }

    public QuestionSet (int question)
    {
        // Load Question set
        this.Question = load(question, 0);
        this.Choice1 = load(question, 1);
        this.Choice2 = load(question, 2);
        this.Choice3 = load(question, 3);
        this.Choice4 = load(question, 4);
        this.Answer = load(question, 5);
        String stringCat = load(question, 6);
        
        switch (Convert.ToInt32(stringCat))
        {
            case 1:
                this.category = Categories.CompetitveEvents;
                break;
            case 2:
                this.category = Categories.BusinessSkills;
                break;
            case 3:
                this.category = Categories.AboutFBLA;
                break;
            case 4:
                this.category = Categories.FBLAHistory;
                break;
            case 5:
                this.category = Categories.NationalOfficers;
                break;
            default:
                this.category = Categories.CompetitveEvents;
                break;
        }
    }

    private string load(int question, int type)
    {
        List<string> list;
        switch (type)
        {
            case 0:
                list = QuestionDatabase.questions;
                break;
            case 1:
                list = QuestionDatabase.choice1s;
                break;
            case 2:
                list = QuestionDatabase.choice2s;
                break;
            case 3:
                list = QuestionDatabase.choice3s;
                break;
            case 4:
                list = QuestionDatabase.choice4s;
                break;
            case 5:
                list = QuestionDatabase.answers;
                break;
            default:
                Console.WriteLine("ERROR: Type Can Only Be From 0 - 5");
                list = QuestionDatabase.questions;
                break;
        }
        return list[question];
    }

    public string Question
    {
        get { return question; }
        set { question = value; }
    }
    public string Choice1
    {
        get { return choice1; }
        set { choice1 = value; }
    }
    public string Choice2
    {
        get { return choice2; }
        set { choice2 = value; }
    }
    public string Choice3
    {
        get { return choice3; }
        set { choice3 = value; }
    }
    public string Choice4
    {
        get { return choice4; }
        set { choice4 = value; }
    }
    public string Answer
    {
        get { return answer; }
        set { answer = value; }
    }

    public Categories Category
    {
        get { return category; }
        set { category = value; }
    }



}
