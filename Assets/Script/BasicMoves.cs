using UnityEngine;
using System.Collections;

public class BasicMoves : MonoBehaviour {

	[SerializeField]
	private float seuilDepartX;

	[SerializeField]
	private float seuilFinX;

	[SerializeField]
	private float seuilDepartY;
	
	[SerializeField]
	private float seuilFinY;

	[SerializeField]
	private float seuilDepartZ;
	
	[SerializeField]
	private float seuilFinZ;




	[SerializeField]
	private float timer; //en seconde
	private float timerX; // en seconde, ne pas y toucher
	private float timerY; // en seconde, ne pas y toucher
	private float timerZ; // en seconde, ne pas y toucher

	bool debutMoveX = false;
	bool seuilMoveX = false;
	bool finMoveX = false;

	bool debutMoveY = false;
	bool seuilMoveY = false;
	bool finMoveY = false;

	bool debutMoveZ = false;
	bool seuilMoveZ = false;
	bool finMoveZ = false;

	// Use this for initialization
	void Start () {
		// TODO - modifier seuilDebutX et seuilFinX en fonction de la valeur donnee et de la position du joueur
	
	}

	#region "Mouvement de X"
	bool mouvementX (float x)
	{
		// On verifie que le mouvement n'a pas ete initialise
		if (x < seuilDepartX) 
		{
			debutMoveX = true;
			seuilMoveX = false;
			finMoveX = false;
			//Debug.Log ("seuilDepartX pas atteint : " + x + " < " + seuilDepartX);
		}
		
		// Si on peut lancer le mouvement
		if (debutMoveX)
		{
			//On regarde si la premiere valeur seuil a ete atteinte, si oui :
			if (x > seuilDepartX) 
			{

				//Debug.Log ("seuilDepartX atteint !!  " + seuilDepartX + " < " + x + " < " + seuilFinX);
				
				//on initialise un timer
				if (!seuilMoveX)
				{
					timerX = 0;
					seuilMoveX = true;
				}
				else
				{
					timerX += Time.deltaTime;
					if(timerX > timer)
					{
						//trop tard, on doit refaire le mouvement
						seuilMoveX = false;
						debutMoveX = false;
						finMoveX = false;
						Debug.Log ("Fin du timer X: " + timerX);
					}
					// si on a termine le mouvement, on precise que le mouvement est termine
					if (x > seuilFinX)
					{
						//Debug.Log ("seuilFinX a ete atteint : " + seuilFinX + " < " + x );
						finMoveX = true;
					}
				}
			}
		}
		return finMoveX;
	}
	#endregion

	bool mouvementY (float x)
	{
		//Debug.Log ("seuilDepartY pas atteint : " + x + " < " + seuilDepartY);

		// On verifie que le mouvement n'a pas ete initialise
		if (x < seuilDepartY) 
		{
			debutMoveY = true;
			seuilMoveY = false;
			finMoveY = false;
		}
		
		// Si on peut lancer le mouvement
		if (debutMoveY)
		{
			//On regarde si la premiere valeur seuil a ete atteinte, si oui :
			if (x > seuilDepartY) 
			{
				
				Debug.Log ("seuilDepartY atteint !!  " + seuilDepartY + " < " + x + " < " + seuilFinY);
				
				//on initialise un timer
				if (!seuilMoveY)
				{
					timerY = 0;
					seuilMoveY = true;
				}
				else
				{
					timerY += Time.deltaTime;
					if(timerY > timer)
					{
						//trop tard, on doit refaire le mouvement
						seuilMoveY = false;
						debutMoveY = false;
						finMoveY = false;
						Debug.Log ("Fin du timer Y : " + timerY);
					}
					// si on a termine le mouvement, on precise que le mouvement est termine
					if (x > seuilFinY)
					{
						//Debug.Log ("seuilFinX a ete atteint : " + seuilFinX + " < " + x );
						finMoveY = true;
					}
				}
			}
		}
		return finMoveY;
	}


	bool mouvementZ (float x)
	{
		//Debug.Log ("seuilDepartZ pas atteint : " + x + " < " + seuilDepartZ);

		// On verifie que le mouvement n'a pas ete initialise
		if (x < seuilDepartZ) 
		{
			debutMoveZ = true;
			seuilMoveZ = false;
			finMoveZ = false;
		}
		
		// Si on peut lancer le mouvement
		if (debutMoveZ)
		{
			//On regarde si la premiere valeur seuil a ete atteinte, si oui :
			if (x > seuilDepartZ) 
			{
				
				Debug.Log ("seuilDepartZ atteint !!  " + seuilDepartZ + " < " + x + " < " + seuilFinZ);
				
				//on initialise un timer
				if (!seuilMoveZ)
				{
					timerZ = 0;
					seuilMoveZ = true;
				}
				else
				{
					timerZ += Time.deltaTime;
					if(timerZ > timer)
					{
						//trop tard, on doit refaire le mouvement
						seuilMoveZ = false;
						debutMoveZ = false;
						finMoveZ = false;
						Debug.Log ("Fin du timer Z : " + timerZ);
					}
					// si on a termine le mouvement, on precise que le mouvement est termine
					if (x > seuilFinZ)
					{
						//Debug.Log ("seuilFinX a ete atteint : " + seuilFinX + " < " + x );
						finMoveZ = true;
					}
				}
			}
		}
		return finMoveZ;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;

		if (mouvementX (position.x))
		{
			Debug.Log ("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX !!!!! : " + seuilFinX + " < " + position.x );
		}

		if (mouvementY (position.y))
		{
			Debug.Log ("YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY !!!!! : " + seuilFinY + " < " + position.y );
		}

		if (mouvementZ (position.z))
		{
			Debug.Log ("ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ !!!!! : " + seuilFinZ + " < " + position.z );
		}

	}
}
