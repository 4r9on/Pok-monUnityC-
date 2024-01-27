using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public _Type type;

    public string name;
    public int pvMax;
    public int pv;
    public int attaque;
    public int defence;
    public int vitesse;
    //public Type type1;
    //public Type type2;

    public GameObject _Attaque1;
    public GameObject _Attaque2;
    //public GameObject _Attaque3;
    //public GameObject _Attaque4;

    [SerializeField]
    public int charge;
    [SerializeField]
    private int pistoleAEau;
    [SerializeField]
    private int flam;


    public Pokemon player;
    public Pokemon enemy;


    public void Charge()
    {
        charge = (player.attaque * 20) / 100;

        enemy.pv -= charge;
    }


    public void Pistole()
    {
        if (type == _Type.Eau)
        {
            if (type == _Type.Plante)
            {
                pistoleAEau = ((attaque * 90) / 100)/2;
            }
            if (type == _Type.Feu)
            {
                pistoleAEau = ((attaque * 90) / 100) * 2;
            }
            else
            {
                pistoleAEau = (attaque * 90) / 100;
            }
            enemy.pv -= pistoleAEau;
        }
    }

    public void Flam()
    {
        if (type == _Type.Feu)
        {
            if (type == _Type.Eau)
            {
                flam = ((attaque * 100) / 100) / 2;
            }
            if (type == _Type.Plante)
            {
                flam = ((attaque * 100) / 100) * 2;
            }
            else
            {
                flam = (attaque * 100) / 100;
            }
            enemy.pv -= flam;
        }
    }

    public void Soin()
    {

    }

}

public enum _Type
{
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