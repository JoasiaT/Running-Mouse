//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionDetect : MonoBehaviour

// ..................................................."The Begginer Guide"...................................................................
// (1) if (collision.gameObject.tag == "Obsticle") to oznacza, ze sprawdza czy gameObject z ktorym doszlo do kolizji ma tag "Obsticle"

// (2) ("Take collision") -----> Metoda zostaje wykonana na wejsciu kolizji

// (3)  SceneManager.LoadScene(SceneManager.GetActiveScene().name) ----> SceneManager wczytuje scene ktora aktualnie dziala

//............................................................................................................................................
{
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
        if (collision.gameObject.tag == "Obsticle")
        {
            //Debug.Log("Take collision"); //(2)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //(3)
        }
        if (collision.gameObject.tag == "Shield")
        {
            Debug.Log("shield activated");
            
        }


    }
}
