//using System.Collections;
//using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManagare : MonoBehaviour
{
    public PlayerController playerController;
    public TMP_Text playerPointsTex;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPointsTex.text = playerController.points.ToString();
    }
}
