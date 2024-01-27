using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dresseur : MonoBehaviour
{
    [field : SerializeField]
    public List<GameObject> pokemon;
    [field : SerializeField]
    public List<GameObject> myPokemon;
    private int index;
    private int index2;
    private GameObject inPokemon1;
    private GameObject inPokemon2;

    void Start()
    {
        index = Random.Range(0, pokemon.Count);
        Debug.Log(index);
        inPokemon1 = pokemon[index];
        myPokemon.Add(inPokemon1);
        pokemon.Remove(pokemon[index]);
        index2 = Random.Range(0, pokemon.Count);
        inPokemon2 = pokemon[index2];
        myPokemon.Add(inPokemon2);
    }
}
