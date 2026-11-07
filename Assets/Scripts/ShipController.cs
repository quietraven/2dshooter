using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
   float speed = 5;

  Vector2 move = Vector2.zero; 
    
    void Start()
    {
         
    }

    void Update()
    {
    //   Vector2 movement = new(.01f, 0);
      transform.Translate(move * Time.deltaTime);  
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
        // print("Move");
    }

}
