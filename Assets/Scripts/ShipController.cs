using UnityEngine;
using UnityEngine.InputSystem;
//TT
public class ShipController : MonoBehaviour
{
  [SerializeField]
  GameObject boltPrefab;

  [SerializeField]
  Transform gunPosition;

  [SerializeField]
  float speed = 5f;

  Vector2 move = Vector2.zero;

  float timeBetweenShots = 0.5f;
  float timeSinceLastShot = 0;

  void Update()
  {
    transform.Translate(move * Time.deltaTime * speed);

    timeSinceLastShot += Time.deltaTime;

    if (timeSinceLastShot >= timeBetweenShots)
    {
      Fire();
    }
  }

  void Fire()
  {
    Instantiate(boltPrefab, gunPosition.position, Quaternion.identity);
    timeSinceLastShot = 0;
  }

  void OnMove(InputValue value)
  {
    move = value.Get<Vector2>();
    // print("Move");
  }

}
