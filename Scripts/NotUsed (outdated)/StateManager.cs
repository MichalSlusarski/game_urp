using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;

    [SerializeField] Vector3 PlayerPosition;
    [SerializeField] Vector3 EnemyPosition;

    bool PlayerTurn;
    bool EnemyTurn;

    void Start()
    {
        PlayerTurn = true;
        EnemyTurn = false;
        
        Player.transform.position = PlayerPosition;
        Enemy.transform.position = EnemyPosition;
    }

    void Update()
    {
        if(PlayerTurn == true)
        {
            if(Input.GetKeyDown("w"))
            {
                PlayerPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + 1.25f);
                PlayerTurn = false;
                EnemyTurn = true;
            }
            if(Input.GetKeyDown("s"))
            {
                PlayerPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - 1.25f);
                PlayerTurn = false;
                EnemyTurn = true;
            }
            if(Input.GetKeyDown("a"))
            {
                PlayerPosition = new Vector3(Player.transform.position.x - 1.25f, Player.transform.position.y, Player.transform.position.z);
                PlayerTurn = false;
                EnemyTurn = true;
            }
            if(Input.GetKeyDown("d"))
            {
                PlayerPosition = new Vector3(Player.transform.position.x + 1.25f, Player.transform.position.y, Player.transform.position.z);
                PlayerTurn = false;
                EnemyTurn = true;
            }
        }

        if(EnemyTurn == true)
        {
           if(Input.GetKeyDown("u"))
            {
                EnemyPosition = new Vector3(Enemy.transform.position.x, Enemy.transform.position.y, Enemy.transform.position.z + 1.25f);
                PlayerTurn = true;
                EnemyTurn = false;
            }
            if(Input.GetKeyDown("j"))
            {
                EnemyPosition = new Vector3(Enemy.transform.position.x, Enemy.transform.position.y, Enemy.transform.position.z - 1.25f);
                PlayerTurn = true;
                EnemyTurn = false;
            }
            if(Input.GetKeyDown("h"))
            {
                EnemyPosition = new Vector3(Enemy.transform.position.x - 1.25f, Enemy.transform.position.y, Enemy.transform.position.z);
                PlayerTurn = true;
                EnemyTurn = false;
            }
            if(Input.GetKeyDown("k"))
            {
                EnemyPosition = new Vector3(Enemy.transform.position.x + 1.25f, Enemy.transform.position.y, Enemy.transform.position.z);
                PlayerTurn = true;
                EnemyTurn = false;
            } 
        }
    }
}
