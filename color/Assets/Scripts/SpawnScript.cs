using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public ArrayList LineList = new ArrayList();


	public float spawntime;
	public bool isbonus = false;


	public GameObject aux;


	public GameObject Tile3Colores;
    public GameObject Tile2Colores;
    public GameObject Tile4Colores;
	public GameObject Bonus;
	int count;
	int count2;
    int random;
	float time;
	float time2;
	public int dificulty;
	bool boolaux;
	public bool dificultchanged;
	public DestroyScript DS;
	public PatternObject pattern;
	public PatternObject[] vectorOfPattern;

	// Use this for initialization
	void Start () {
		dificultchanged = false;
		spawntime = GameObject.FindObjectOfType<TimeInGame> ().spawntime;
		count2 = 1;
		time = 1f;
		DS = GameObject.FindObjectOfType<DestroyScript> ();
		pattern = new PatternObject ();
		vectorOfPattern = new PatternObject[]{ };
		boolaux = true;
		isbonus = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindObjectOfType<TimeInGame>().bonustime > 5f && !isbonus) {
			isbonus = true;
		}

		if (boolaux) {
			if (Mathf.RoundToInt(GameObject.FindObjectOfType<TimeInGame>().time) >= 0) {
				dificulty = 1;
				spawntime = 0.8f;
				dificultchanged = true;
				if (Mathf.RoundToInt(GameObject.FindObjectOfType<TimeInGame>().time) > 10f) {
					dificultchanged = true;
					dificulty = 2;
					if (Mathf.RoundToInt(GameObject.FindObjectOfType<TimeInGame>().time) > 25f) {
						dificultchanged = true;
						dificulty = 3;
					}
					if (Mathf.RoundToInt(GameObject.FindObjectOfType<TimeInGame>().time) > 35f) {
						dificultchanged = true;
						dificulty = 3;
					}
				}
			}
			vectorOfPattern = pattern.FillPattern (dificulty);	//ACÁ SE SELECCIONA LA DIFICULTAD DE JUEGO (REVISAR PATTERN)
			Debug.Log ("El pattern cambió a " + count2);
			boolaux = false;
		}


		time -= Time.deltaTime;
		if (time < 0) {
			time = spawntime;
			if (!isbonus) {
				Spawner ();	
			} else {
				isbonus = false;
				BonusSpawner ();
			}
		}
			
		}

	void Spawner()
	{
		StartCoroutine (Timer(spawntime));	
		aux = new GameObject ();
		switch ( Mathf.RoundToInt(vectorOfPattern[count].TileQuantyInLine)) {
		case 2:
			aux = (GameObject)Instantiate (Tile2Colores, new Vector2 (0, 250), Quaternion.identity);
			aux.GetComponent<ColorController> ().TileQuanty = Mathf.RoundToInt (vectorOfPattern [count].TileQuantyInLine);
			aux.GetComponent<ColorController> ().position = Mathf.RoundToInt (vectorOfPattern [count].positionOfTileInLine);
			break;
		case 3:
			aux = (GameObject)Instantiate (Tile3Colores, new Vector2 (0, 250), Quaternion.identity);
			aux.GetComponent<ColorController> ().TileQuanty =  Mathf.RoundToInt(vectorOfPattern[count].TileQuantyInLine);
			aux.GetComponent<ColorController> ().position = Mathf.RoundToInt(vectorOfPattern[count].positionOfTileInLine);
			break;
		case 4:
			aux = (GameObject)Instantiate (Tile4Colores, new Vector2 (0, 250), Quaternion.identity);
			aux.GetComponent<ColorController> ().TileQuanty =  Mathf.RoundToInt(vectorOfPattern[count].TileQuantyInLine);
			aux.GetComponent<ColorController> ().position = Mathf.RoundToInt(vectorOfPattern[count].positionOfTileInLine);
			break;	
		}
		LineList.Add (aux);
		count++;
		Debug.Log (count);
		if (count >= 5) {
			boolaux = true;
			count = 0;
			Debug.Log ("TAKE THIS MTF");
		}
		count2++;
		if (count2 > 3) {
			count2 = 1;
		}
	}


	void BonusSpawner()
	{
		StartCoroutine (Timer (spawntime));	
		aux = (GameObject)Instantiate (Bonus, new Vector2 (0, 250), Quaternion.identity);
		Debug.Log ("BONUS");
		GameObject.FindObjectOfType<TimeInGame> ().bonustime = 0f;
	}

	IEnumerator Timer(float time) {
		yield return new WaitForSeconds(time);
	}

}


