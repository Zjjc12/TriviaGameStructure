using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private int totalQuestions = 10;

    void Start()
    {
        QuestionDatabase.ImportGame("stuff.csv");
        Questions.SetTotalQuestions(totalQuestions);
    }

    // Update is called once per frame
    void Update()
    {
        // HOW TO USE
        QuestionSet q1 = Questions.GetQuestion(QuestionSet.Categories.AboutFBLA);

        Debug.Log(q1.Answer);
    }
}
