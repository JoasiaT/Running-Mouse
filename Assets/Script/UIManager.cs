using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerController playerController;
    public Image shieldIcon;
    public EndGameScreen endGameScreen;
    public TMP_Text playerPointsText;

    // Start is called before the first frame update
    void Start()
    {
        shieldIcon.enabled = false;
        endGameScreen.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerPointsText.text = playerController.points.ToString();
        //endGamePoints.text = endGamePoints.points.ToString();

    }
}
