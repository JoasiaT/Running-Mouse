using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{


    public void PlayButton()
    {
        SceneManager.LoadSceneAsync("Level1");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
