
using UnityEngine;

public class Pipes : MonoBehaviour
{
    
    public float speed = 5f;
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f; // We subtract 1 from the edge of camera to make sure the pipe is entirely out of sight
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject); // If the pipe is out of camera, destroy it
        }
    }
}
