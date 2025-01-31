using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGameScreen : MonoBehaviour
{
    public TMP_Text playerPointsText;
    //public TMP_Text endGamePoints;
    
    public void setPlayerPoints(int playerPoints)
    {
        Time.timeScale = 0;
        playerPointsText.text = playerPoints.ToString();
        gameObject.SetActive(true);     
    }

    public void PlayLevel2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
