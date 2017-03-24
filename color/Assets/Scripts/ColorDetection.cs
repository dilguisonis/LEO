using UnityEngine;
using System.Collections;

public class ColorDetection : MonoBehaviour {

	int[] validChoices = new int[3];


	public int GetRandom()
	{
		return Mathf.RoundToInt(validChoices[Random.Range(0, validChoices.Length)]);
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
//		Debug.Log (this.gameObject.tag + " es " + GameObject.Find("Player").GetComponent<PlayerController>().ColorString);
		if (this.gameObject.tag != GameObject.Find("Player").GetComponent<PlayerController>().ColorString) 
		{
			GameObject.Find("Player").GetComponent<PlayerController> ().isplaying = false;
		}

		if (this.gameObject.tag == "Bonus") {
			int colortoset;

			switch (GameObject.Find("Player").GetComponent<PlayerController> ().colorint) {
			case 1:
				validChoices = new int[]{2,3,4};
				break;
			case 2:
				validChoices = new int[]{1,3,4};
				break;
			case 3:
				validChoices = new int[]{1,2,4};
				break;
			case 4:
				validChoices = new int[]{1,2,3};
				break;
			}
			GameObject.Find ("Player").GetComponent<PlayerController> ().SetColorPlayer (GetRandom());
			Debug.Log ("Color changed !!!!!!!!!!!!!!!!!!!!!!!!!");

			foreach (GameObject item in GameObject.FindObjectOfType<SpawnScript>().LineList) {
				ColorController foo = item.gameObject.GetComponent<ColorController> ();
				foo.Start();

			}
	//LETS FIND OUT WHAT IS HAPPENING HERE

		}
	}
}
