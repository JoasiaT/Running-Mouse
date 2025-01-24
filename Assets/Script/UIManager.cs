using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManagare : MonoBehaviour
{
    public PlayerController playerController;
    public TMP_Text playerPointsTex;
    public Image shieldIcon;


    // Start is called before the first frame update
    void Start()
    {
        shieldIcon.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerPointsTex.text = playerController.points.ToString();
    }
}
