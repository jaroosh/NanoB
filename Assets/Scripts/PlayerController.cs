using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Vector2 _speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// called every 50th of a second.
    /// </summary>
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h,v);
        Animate(h,v);
    }

    void Move(float h, float v)
    {
        _speed.Set(h, v);
        _speed = _speed.normalized*speed*Time.deltaTime;
        rigidbody2D.MovePosition((Vector2)transform.position + _speed);
    }

    void Animate(float h, float v)
    {
        
    }
}
