using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obsticle") //Sprawdza czy gameObject z kt�rym dosz�o do kolizji ma tag "Obsticle"
        {
            Debug.Log("Take collision"); // Metoda zostaje wykonana na wej�ciu kolizji
        }
        
    }
}
