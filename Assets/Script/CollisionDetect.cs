using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionDetect : MonoBehaviour
{
    public PlayerController playerController;
    public UIManager uiManager;
    public EndGameScreen endGameScreen;
    private AudioManangare audioMananger;

    // ..................................................."The Begginer Guide"...................................................................
    // (1) if (collision.gameObject.tag == "Obsticle") to oznacza, ze sprawdza czy gameObject z ktorym doszlo do kolizji ma tag "Obsticle"

    // (2) ("Take collision") -----> Metoda zostaje wykonana na wejsciu kolizji

    // (3)  SceneManager.LoadScene(SceneManager.GetActiveScene().name) ----> SceneManager wczytuje scene ktora aktualnie dziala

    //............................................................................................................................................

    private void Awake()
    {
        audioMananger = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManangare>();
    }

    private void OnCollisionEnter(Collision collision) //(1)
    {
        if (collision.gameObject.tag == "Obsticle" && !playerController.playerHasShield)
        {
            //Debug.Log("Take collision"); //(2)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //(3)
            if (playerController.playerHasShield)
            {
                playerController.playerHasShield = false;
                playerController.shieldGameObject.SetActive(false);
                uiManager.shieldIcon.enabled = false;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (collision.gameObject.tag == "Shield")
        {
            //Debug.Log("shield activated");
            audioMananger.PlaySFX(audioMananger.shieldTake);
            playerController.shieldGameObject.SetActive(true);
            playerController.playerHasShield = true;
            uiManager.shieldIcon.enabled = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "EndGame")
        {
            endGameScreen.setPlayerPoints(uiManager.playerController.points);
        }

    }
}
