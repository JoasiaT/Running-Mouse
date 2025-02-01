using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionDetect : MonoBehaviour
{
    public PlayerController playerController;
    public UIManager uiManager;
    public EndGameScreen endGameScreen;

    // ..................................................."The Begginer Guide"...................................................................
    // (1) if (collision.gameObject.tag == "Obsticle") to oznacza, ze sprawdza czy gameObject z ktorym doszlo do kolizji ma tag "Obsticle"

    // (2) ("Take collision") -----> Metoda zostaje wykonana na wejsciu kolizji

    // (3)  SceneManager.LoadScene(SceneManager.GetActiveScene().name) ----> SceneManager wczytuje scene ktora aktualnie dziala

    //............................................................................................................................................


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
