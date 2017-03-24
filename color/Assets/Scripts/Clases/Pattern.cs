using UnityEngine;
using System.Collections;

public class PatternObject : System.Object {
	public float positionOfTileInLine;
	public float TileQuantyInLine;



	public PatternObject()
	{
		positionOfTileInLine = 0;
		TileQuantyInLine = 0;

	}

	public PatternObject[] FillPattern(int difficult) //ACÁ SE RECIBE LA DIFICULTAD DE JUEGO
	{
		int counter = 0;
		PatternObject[] vectorOfEachLine= new PatternObject[5]; //INICIALIZO EL VECTOR QUE CONTIENE 5 LINEAS


		for (int i = 0; i < 5; ++i) {
			vectorOfEachLine [i] = new PatternObject (); //LLENO CADA UNA DE LAS 5 LINEAS
		}

		foreach (var eachline in vectorOfEachLine) {
			//SEGÚN LA DIFICULTAD, ESTOY GENERANDO UN BLOQUE DE LINEAS (5 LINEAS). 

			switch (difficult) {
			//PROBLEMA! URGENTE!!!!!

			//Para que se noten los patrones hay que agregar un random range que FUNCIONE. Los Random Range de abajo no funcionan nop sé porque.
			//Testealo, pero no pierdas mucho tiempo.


			//A CADA LINEA SE LE ASIGNA UNA CANTIDAD DE TILES. 
			//DEPENDIENDO DE LA DIFICULTAD SE SELECCIONA LA CANTIDAD DE TILES
			case 1:
				eachline.TileQuantyInLine = Random.Range (2f,2f);
				break;
			case 2:
				eachline.TileQuantyInLine = Random.Range (2f,3f);
				break;
			case 3:
				eachline.TileQuantyInLine = Random.Range (3f, 4f);
				break;
			}
			//DEPENDIENDO DE LA CANTIDAD DE TILES QUE PUEDEN HABER EN UNA LINEA, SE ASIGNA DÓNDE VA A ESTAR EL 
			//TILE PARA QUE EL PLAYER PUEDA PASAR.
			//TODAVÍA NO SE IMPLEMENTO LA VIA PARA QUE ESTA VARIABLE TENGA UN EFECTO EN COLOR CONTROLLER.


			switch ( Mathf.RoundToInt(eachline.TileQuantyInLine)) {
			case 2:
				if (counter == 0) {
					vectorOfEachLine [counter].positionOfTileInLine = GameObject.FindObjectOfType<Auxiliar> ().aux1 + 1;
					if (vectorOfEachLine [counter].positionOfTileInLine > 2) {
						vectorOfEachLine [counter].positionOfTileInLine = GameObject.FindObjectOfType<Auxiliar> ().aux1 - 1;						
					}
				} else {
					vectorOfEachLine [counter].positionOfTileInLine = vectorOfEachLine [counter - 1].positionOfTileInLine + 1; 
					if (vectorOfEachLine [counter].positionOfTileInLine > 2) {
						vectorOfEachLine [counter].positionOfTileInLine = 1;
					}
				}
				//eachline.positionOfTileInLine = Random.Range (1f,2f);
				if (counter == 4) {
					GameObject.FindObjectOfType<Auxiliar> ().aux1 =Mathf.RoundToInt( eachline.positionOfTileInLine);
				}
				break;
			case 3:
				if (counter == 0) {
					vectorOfEachLine [counter].positionOfTileInLine = GameObject.FindObjectOfType<Auxiliar> ().aux2 + 1;
					if (vectorOfEachLine [counter].positionOfTileInLine > 3) {
						vectorOfEachLine [counter].positionOfTileInLine = GameObject.FindObjectOfType<Auxiliar> ().aux2 - 1;						
					}
				} else {
					vectorOfEachLine [counter].positionOfTileInLine = vectorOfEachLine [counter - 1].positionOfTileInLine + 1; 
					if (vectorOfEachLine [counter].positionOfTileInLine > 3) {
						vectorOfEachLine [counter].positionOfTileInLine = 1;
					}
				}
				//eachline.positionOfTileInLine = Random.Range (1f,3f);
				if (counter == 4) {
					GameObject.FindObjectOfType<Auxiliar> ().aux2 =Mathf.RoundToInt( eachline.positionOfTileInLine);
				}

				break;
			case 4:
				if (counter == 0) {
					vectorOfEachLine [counter].positionOfTileInLine = GameObject.FindObjectOfType<Auxiliar> ().aux2 + 1;
					if (vectorOfEachLine [counter].positionOfTileInLine > 4) {
						vectorOfEachLine [counter].positionOfTileInLine = GameObject.FindObjectOfType<Auxiliar> ().aux2 - 1;						
					}
				} else {
					vectorOfEachLine [counter].positionOfTileInLine = vectorOfEachLine [counter - 1].positionOfTileInLine + 1; 
					if (vectorOfEachLine [counter].positionOfTileInLine > 4) {
						vectorOfEachLine [counter].positionOfTileInLine = 1;
					}
				}
				//eachline.positionOfTileInLine = Random.Range (1f,4f);
				if (counter == 4) {
					GameObject.FindObjectOfType<Auxiliar> ().aux3 =Mathf.RoundToInt( eachline.positionOfTileInLine);
				}
				break;
			}

		
			counter++;
		}

		return vectorOfEachLine;
	}

}



