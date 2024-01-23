using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HidraPokemon : MonoBehaviour
{
    Pokemon pokemon;

    public int _pvMax;
    public int _attaque;
    public int _defence;
    public int _vitesse;

    private void Start()
    {
        Hidra(pokemon);
    }

    private void Hidra(Pokemon pokemon)
    {
        pokemon.pvMax = _pvMax;
        pokemon.attaque = _attaque;
        pokemon.defence = _defence;
        pokemon.vitesse = _vitesse;
    }
}
