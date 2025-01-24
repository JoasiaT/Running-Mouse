using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float jumpSpeed = 5f;
    public Animator animator; //(7)
    public int points = 0;
    public GameObject shieldGameObject;
    public bool playerHasShield = false;

   // public Transform minXPlayerPos;

    // Start is called before the first frame update
    void Start()
    {
        shieldGameObject.SetActive(false);
        playerHasShield = false;
    }

    // Update is called once per frame

    void Update()
    {
        //.................................................INSTRUKCJA_K0D0WANIA_W_C#............................................................//
        // 1) JESLI wciskamy przycisk A to jest to w 'if'

        // 2) JESLI pozycja gracza na osi X jest wiêksza od -3.55f to wykonaj to co wewnontrz klamry wykonuje siê to je¿eli warunek jest spe³niony

        // 3) 'transform.Translate' przesuwa obiekt o Vector

        // 4) 'Vector3' uzywa sie do gier 3D, a 'Vector'  uzywa sie do gier 2D

        // 5) JESLI -> 'else' warunek nie jest spe³niony to w klamrach wykomuje sie te rzeczy (*)

        // 6) przyk³ad:  if (Input.GetKey(KeyCode.E)) <-  WARUNEK jest w nawiasie obok 'if'.      <  'if' -> Warunek    >

        // 7)   public Animator animator --> referencja do animatora

        // 8)  if (transform.position.x > minXPlayerPos.position.x) -> Ten fragment u¿ywa sie, gdy dodaje siê ogranicznik w formie EmptyObject


        if (Input.GetKey(KeyCode.A)) // (1)
        {
            if (transform.position.x > -2.55f) // (2)
               //if (transform.position.x > minXPlayerPos.position.x) -> Ten fragment u¿ywa sie, gdy dodaje siê ogranicznik w formie EmptyObject (8)
            {
                transform.Translate(Vector3.left * Time.deltaTime * moveSpeed); // (3) i (4)
            }
            //else if (transform.position.x < 1.55f) // (5)
            //{

            //}
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.55f)
            {
                transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.Play("Jump");
        }
    }
       
    

       


        
}
