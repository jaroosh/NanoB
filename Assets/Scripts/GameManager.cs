using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager>
{

    private AudioManager _audioManager;

    void Awake()
    {
        LoadResources();
        DontDestroyOnLoad(transform.gameObject);
    }

    void LoadResources()
    {
        _audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

	// Use this for initialization
	void Start () {
	    _audioManager.PlayLevel1Back();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
