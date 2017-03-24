using UnityEngine;
using System.Collections;

public class TouchDetection : MonoBehaviour {
	public bool isplaying;
	public PlayerMovement PM;

	public float maxTime;
	public float minSwipeDist;

	public float leonardo; 

	public GameObject player;

	// Use this for initialization
	void Start () {
		isplaying = GameObject.Find ("Player").GetComponent<PlayerController> ().isplaying;
		player = GameObject.Find ("Player");

	}

	// Update is called once per frame
	void Update () {
		if (isplaying) {
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
		
			if (touch.phase == TouchPhase.Moved) {
				
						Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);
						//Debug.Log (pos);
						player.GetComponent<PlayerMovement> ().Move (pos.x);
					

			}

			}

			/*
			if (touch.phase == TouchPhase.Began)
			{
				startTime = Time.time;
				startPos = touch.position;

				player.GetComponent<PlayerMovement> ().Move (touch.position.x);
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				endTime = Time.time;
				endPos = touch.position;

				swipeDistance = (endPos - startPos).magnitude;
				swipeTime = endTime - startTime;

				if (swipeTime < maxTime && swipeDistance > minSwipeDist)
				{
					swipe();
				}
			}
			*/
		}
	}
		
}
