using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Race", menuName = "ScriptableObjects/New Race", order = 1)]
[System.Serializable]
public class Raza : ScriptableObject
{
    public enum TipoDeRaza { 
    ENANO,
    ELFO,
    MEDIANO,
    HUMANO,
    DRACONIDO,
    GNOMO,
    SEMIELFO,
    SEMIORCO,
    TIFLIN};
    public TipoDeRaza nombre;
    public int IPC;
    public int edad;
    public enum Etica { Legal, Neutral, Malvado };
    public Etica etica;
    public enum Moral { Bueno, Neutral, Caotico };
    public Moral moral;
    public float altura;
    public int velociadad;
    public int visionOscuridad;
    public List<string> idiomasPosibles;
}
