using System.Collections;
using System.Collections.Generic;
using System;

public static class Questions
{
    public static int totalQuestions;

    public static List<QuestionSet> CompetitveEvents;
    public static List<QuestionSet> BusinessSkills;
    public static List<QuestionSet> AboutFBLA;
    public static List<QuestionSet> FBLAHistory;
    public static List<QuestionSet> NationalOfficers;

    public static QuestionSet GetQuestion(QuestionSet.Categories cat)
    {
        while (true)
        {
            Random rnd = new Random();
            int randomQ = rnd.Next(0, totalQuestions);

            QuestionSet q = new QuestionSet(randomQ);
            if (q.Category == cat)
            {
                return (q);
            }
            else
            {
                q = null;
            }
        }
    }

    public static void SetTotalQuestions(int tq)
    {
        totalQuestions = tq;
    }
}
