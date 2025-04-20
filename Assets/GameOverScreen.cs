using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    
    public TextMeshProUGUI pointsText;
    private PlayerController playerControllerScript;

    public void SetUp(float score)
    {
        gameObject.SetActive(true);
        pointsText.text = Mathf.Round(score).ToString() + "POINTS";

    }
    public void Restart ()
    {
        
        SceneManager.LoadScene("Prototype 3");

    }
    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
