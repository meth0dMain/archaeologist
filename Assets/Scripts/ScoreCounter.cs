using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    Text text;
    int score;
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "Score: " + score;
    }

    public void ChangeScore(int points)
    {
        score += points;
        text.text = "Score: " + score;
    }
}
