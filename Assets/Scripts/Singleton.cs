using UnityEngine;
using System.Collections.Generic;

	// Simple implementation of a singleton class.
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

	private static T _instance;
	private static bool _applicationIsQuitting;

	public static T Instance { 
		get { 
			if(_applicationIsQuitting) {
				Debug.Log("<Instance> - Application already destroyed");
				return null;
			}
			if (_instance == null) {
				_instance = (T) FindObjectOfType(typeof(T));

				Debug.Log("SEARCHING for " + _instance);

				if ( FindObjectsOfType(typeof(T)).Length == 1 )
				{
					Debug.Log("<Instance> - Instance of this class was already created.");
					return _instance;
				}
				else {
					GameObject singleton = new GameObject();
					_instance = singleton.AddComponent<T>();
					singleton.name = "(singleton) "+ typeof(T).ToString();
					DontDestroyOnLoad(singleton);
					Debug.Log("<Instance> - An instance of " + typeof(T) + 
						" is needed in the scene, so '" + singleton +
						"' was created with DontDestroyOnLoad.");
				} 
			}
			return _instance;
		}
	}

	public void OnDestroy() {
		_applicationIsQuitting = true;
	}
}

