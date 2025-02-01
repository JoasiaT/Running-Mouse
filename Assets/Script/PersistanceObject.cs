using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistanceObject : MonoBehaviour
{
    public static PersistanceObject instnce;

   private void Awake()
    {
        if (instnce == null)
        {
            instnce = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
}
