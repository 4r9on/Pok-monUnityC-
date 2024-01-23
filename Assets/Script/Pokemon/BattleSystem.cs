using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleSystem : MonoBehaviour
{
    public GameObject pokemonPlayer;
    public GameObject pokemonEnemy;

    //Pokemon player;
    public Pokemon enemy;

    public void OnAttack()
    {
        enemy.pv -= 10;

        Debug.Log(enemy.pv);

    }

    

}
