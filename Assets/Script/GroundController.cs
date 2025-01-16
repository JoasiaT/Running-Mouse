//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{

    public float moveSpeed = 3f; // zmienna okreslajaca z jaka prendkosia bedzie poruszac siê podlorze
    public PlayerController playerController;
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = new Vector3(0, 0, -1); // wektor porusza sie
        transform.Translate(moveVector * Time.deltaTime * moveSpeed); //przesuwanie obiektu po osi Z

        if (transform.position.z > -4.465)
        {
            //playerController.moveSpeed++; // (1) -----> Jak to bylo inaczej napisane? Gdzie to jest w filmiku? 
            
        }
    }

}
