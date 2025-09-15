using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    int score = 0;

    public void addScore(int input)
    {
        if (input == 1)
        {
            score = score + input;
            scoreText.text = score.ToString() + " Points";

            if (score == 1) // for testing purpose
            {
                winText.text = "You Win!";
            }
        }
        else if (input == 0)
        {
            winText.text = "Game Over!";
        }
    }
}
