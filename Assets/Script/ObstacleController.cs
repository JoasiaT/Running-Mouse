//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour

{
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -1.29)
        {
            Debug.Log("Box is behind the Player");
           playerController.points ++; //-> Dodanie do zmiennej Points +1


            Destroy(gameObject);
            //Dodanie punktu
        }
    }
}
