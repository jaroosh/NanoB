using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public Transform player;

    private float _dtime;
    private Vector3 _position;


	// Use this for initialization
	void Start () {
        _position = new Vector3(0, 0, transform.position.z);
	}
	
	// Update is called once per frame
	void Update ()
	{
	    FollowPlayer();
	}

    private void FollowPlayer()
    {
        _dtime = Time.deltaTime;
        _position.x = Mathf.Lerp(transform.position.x, player.position.x, _dtime);
        _position.y = Mathf.Lerp(transform.position.y, player.position.y, _dtime);

        transform.position = _position;
    }
}
