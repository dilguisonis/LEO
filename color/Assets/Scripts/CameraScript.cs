using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject Player;


	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
