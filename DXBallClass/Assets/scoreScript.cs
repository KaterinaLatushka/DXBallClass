using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // import it

public class scoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public GameObject ball; // Reference to the ball GameObject
    int score = 0;

    public void addScore(int input)
    {
        if (input == 1)
        {
            score = score + input;
            scoreText.text = score.ToString() + " Points";

            if (score == 5) // for testing purpose
            {
                winText.text = "You Win!";
                ball.SetActive(false);
                SceneManager.LoadScene("Level2");
            }
        }
        else if (input == 0)
        {
            winText.text = "Game Over!";
        }
    }
}
