using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Call this from the UI button OnClick()
    public void StartGame()
    {
        // Replace "Scene1" with your actual game scene name
        SceneManager.LoadScene("Scene1");
    }
}
