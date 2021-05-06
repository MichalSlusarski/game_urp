using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTurn : MonoBehaviour
{

[SerializeField] GameObject Player; 
[SerializeField] GameObject Enemy;

PlayerFixedMove PlayerFixedMove;
EnemyFixedMove EnemyFixedMove;

void Start()
{
	PlayerFixedMove PlayerFixedMove = Player.GetComponent<PlayerFixedMove>();
	EnemyFixedMove EnemyFixedMove = Enemy.GetComponent<EnemyFixedMove>();

	PlayerFixedMove.enabled = true;
	EnemyFixedMove.enabled = false;
}

void LateUpdate()
{
	if(Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d"))
	{
		Debug.Log("Hai");

		PlayerFixedMove PlayerFixedMove = Player.GetComponent<PlayerFixedMove>();
		EnemyFixedMove EnemyFixedMove = Enemy.GetComponent<EnemyFixedMove>();

		PlayerFixedMove.enabled = false;
		EnemyFixedMove.enabled = true;
		//EnemyFixedMove.enabled = true;
	}
	
	if(Input.GetKeyDown("u") || Input.GetKeyDown("j") || Input.GetKeyDown("h") || Input.GetKeyDown("k"))
	{
		Debug.Log("Pak");

		PlayerFixedMove PlayerFixedMove = Player.GetComponent<PlayerFixedMove>();
		EnemyFixedMove EnemyFixedMove = Enemy.GetComponent<EnemyFixedMove>();

		PlayerFixedMove.enabled = true;
		EnemyFixedMove.enabled = false;
	}
}
}
