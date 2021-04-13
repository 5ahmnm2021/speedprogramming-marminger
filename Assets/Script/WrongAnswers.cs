using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongAnswers : MonoBehaviour
{
    public int answers;

    public void QuestionOneRight()
    {
        StartCoroutine(LoadQuestionOneRight());
    }

    public void QuestionTwoRight()
    {
        StartCoroutine(LoadQuestionTwoRight());
    }

    public void AnswerRight()
    {
        StartCoroutine(LoadAnswerRight());
    }


    IEnumerator LoadQuestionOneRight()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Szene2");
    }

    IEnumerator LoadQuestionTwoRight()
    {
        answers = answers + 1;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Szene3");
    }

    IEnumerator LoadAnswerRight()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Szene1");
    }
}
