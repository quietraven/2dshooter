using UnityEngine;


public class BoltController : MonoBehaviour
{
    [SerializeField]
    float speed = 8;

    void Update()
    {
      transform.Translate(Vector2.up * speed * Time.deltaTime);  
    }

}
