
using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public float speed = 200f;
    public new Rigidbody2D _rigidbody {get; private set; }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    public void Start()
    {
      
        ResetPosition();
        
    }
    public void AddStartingForce()
    {
        // Flip a coin to determine if the ball starts left or right
        float x = Random.value < 0.5f ? -1f : 1f;

        // Flip a coin to determine if the ball goes up or down. Set the range
        // between 0.5 -> 1.0 to ensure it does not move completely horizontal.
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
                                      : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
        Debug.Log("Ball->AddStartingForce->" + x + " - " + y ); 
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

    public void ResetPosition()
    {
     //   _rigidbody.position = Vector3.zero;
      //  _rigidbody.velocity = Vector3.zero;
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.position = new Vector2(0f, 0f);
        Debug.Log("Ball->ResetPosition->" + _rigidbody.position.x + " - " + _rigidbody.position.y);
           
        AddStartingForce();
        
    }


}
