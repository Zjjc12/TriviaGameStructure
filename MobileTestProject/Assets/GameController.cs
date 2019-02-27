using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        QuestionDatabase.ImportGame("stuff.csv");
    }

    // Update is called once per frame
    void Update()
    {
        QuestionSet q1 = new QuestionSet(3);

        Debug.Log(q1.Answer);
    }
}
