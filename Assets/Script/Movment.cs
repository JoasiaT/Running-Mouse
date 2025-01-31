using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] private float forwardSpeed = 10f;
    private int targetLane = 1; // poruszanie si� w lewo - (pozycja) 0, 1 - na �rodek, 2 = w prawo
    [SerializeField] private float laneDistance = 3f; // Dystans do pokonania mi�dzy ka�dymi trzema sektorami "Lan"
    float sideSpeed;
    public Animator p_Animator;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void HandleFarwardMovment()
    {
        Vector3 forwardMove = transform.forward * forwardSpeed * Time.deltaTime;
        Vector3 worldForwardMove = transform.TransformDirection(forwardMove);
        controller.Move(worldForwardMove);
    }
    private void HandleLaneSwitching()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            MoveLane(-1);
            p_Animator.Play("dodgeLeft");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            MoveLane(1);
            p_Animator.Play("dodgeRight");
        }
    }
    private void MoveLane(int direction)
    {
        targetLane += direction;
        targetLane = Mathf.Clamp(targetLane, 0, 2); //Zachowaj target mi�dzy 0 i 2
    }
    private Vector3 CalculateTargetosition() //Oblicz pozycj� targetu -> Target czyli gracz
    {
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (targetLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (targetLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }
        return targetPosition; // Zwr�� pozycj� targetu
    }
    private void MoveTowardsTargetLane()
    {
        Vector3 targetPosition = CalculateTargetosition();
        if (transform.position != targetPosition)
        {
            Vector3 diff = targetPosition - transform.position;
            Vector3 moveDri = diff.normalized * sideSpeed * Time.deltaTime;

            if (moveDri.sqrMagnitude < diff.sqrMagnitude)
                controller.Move(moveDri);
            else
                controller.Move(diff);
        }
    }
}