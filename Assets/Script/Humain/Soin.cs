using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soin : MonoBehaviour
{
    HidraPokemon hidraPokemon;
    Pokemon pokemon;

    private void HealingOne()
    {
        pokemon.pvMax = hidraPokemon._pvMax;
    }
}
