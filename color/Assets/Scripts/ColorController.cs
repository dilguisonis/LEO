using UnityEngine;
using System.Collections;

public class ColorController : MonoBehaviour {
	public GameObject[] Line;
	public int position;
	public int TileQuanty;
	int random;
	int random2;
	int must;
	int[] validChoices = new int[3];


	public int GetRandom()
	{
		return Mathf.RoundToInt(validChoices[Random.Range(0, validChoices.Length)]);
	}


	public void Start () {
		int i = TileQuanty;
		if (GameObject.Find ("Player").GetComponent<PlayerController> ().PlayerIsBlue == true) {
			must = 1;
			validChoices = new int[]{2,3,4};
		}
		if (GameObject.Find ("Player").GetComponent<PlayerController> ().PlayerIsGreen == true) {
			must = 2;
			validChoices = new int[]{1,3,4};
		}
		if (GameObject.Find ("Player").GetComponent<PlayerController> ().PlayerIsRed== true) {
			must = 3;
			validChoices = new int[]{1,2,4};
		}
		if (GameObject.Find ("Player").GetComponent<PlayerController> ().PlayerIsYellow == true) {
			must = 4;
			validChoices = new int[]{1,2,3};
		}
			
		foreach (GameObject lines in Line) {
				//CODIGO INTERVIENE CON BONUS POR EL MUST
				if (i==position) {
					switch (must) {
					case 1:
							lines.GetComponent<SpriteRenderer> ().color = new Color (0f, 0.26f, 223f); //Blue
							lines.tag = "Color Blue";
						break;
					case 2:
							lines.GetComponent<SpriteRenderer> ().color = new Color (0f,255f,0f); // Green Color
							lines.tag = "Color Green";
						break;
					case 3:
							lines.GetComponent<SpriteRenderer> ().color = new Color (255f,0f,0f); // Red Color
							lines.tag = "Color Red";
					break;
					case 4:
							lines.GetComponent<SpriteRenderer> ().color = new Color (255f,255f,0f); // Yellow Color
							lines.tag = "Color Yellow";
						break;
					}
					}
				// random primario
				 else {
					random = GetRandom ();
					switch (random) {
					case 1:
								lines.GetComponent<SpriteRenderer> ().color = new Color (0f, 0.26f, 223f); //Blue
								lines.tag = "Color Blue";
					break;
					case 2:
								lines.GetComponent<SpriteRenderer> ().color = new Color (0f,255f,0f); // Green Color
								lines.tag = "Color Green";
						break;
					case 3:
								lines.GetComponent<SpriteRenderer> ().color = new Color (255f,0f,0f); // Red Color
								lines.tag = "Color Red";
						break;
					case 4:
								lines.GetComponent<SpriteRenderer> ().color = new Color (255f,255f,0f); // Yellow Color
								lines.tag = "Color Yellow";	
						break;
					}
				}
			i -= 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
