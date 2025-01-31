using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Update()
    {
        Vector3 moveVector = new Vector3(0, 0, -1);
        transform.Translate(moveVector * Time.deltaTime * moveSpeed); 
    }
}
