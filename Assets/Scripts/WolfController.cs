using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfController : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rigidBody;
    public Transform startPoint;
    public int zebranePunkty;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float directionHorizontal = Input.GetAxis("Horizontal");
            rigidBody.AddForce(directionHorizontal * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            float directionVertical = Input.GetAxis("Vertical");
            rigidBody.AddForce(0, 0, directionVertical * Time.deltaTime * speed, ForceMode.Impulse);
        }
        if (transform.position.y < 0)
        {
            transform.position = startPoint.position;
            rigidBody.velocity = Vector3.zero;
        }
    }
}
