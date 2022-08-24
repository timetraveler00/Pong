
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidBody { get; private set; }
    public float speed = 8f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        System.Console.WriteLine("aWAKE");

    }

    public void ResetPosition()
    {
        _rigidBody.velocity = Vector2.zero;
        _rigidBody.position = new Vector2(_rigidBody.position.x, 0f);
    }

}
