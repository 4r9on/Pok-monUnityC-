using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public string name;
    public int pvMax;
    public int pv;
    public int attaque;
    public int defence;
    public int vitesse;
    public Type type1;
    //public Type type2;

    public GameObject _Attaque1;
    public GameObject _Attaque2;
    //public GameObject _Attaque3;
    //public GameObject _Attaque4;

    public int charge;

    public enum Type{
        Normale,
        Feu,
        Plante,
        Eau,
        Insecte,
        Acier,
        Dragon,
        Fee,
        Tenebre,
        Psy,
        Spectre,
        Combat,
        Glace,
        Poisson,
        Roche,
        Vol,
        Sol,
        Electrik
    };

    public void Charge()
    {
        charge = (attaque * 20) / 100;
    }

}
