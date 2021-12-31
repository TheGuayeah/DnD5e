using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Race", menuName = "ScriptableObjects/Race", order = 1)]
[System.Serializable]
public class Raza : ScriptableObject
{
    public enum TipoDeRaza { 
        AZOTAMENTES,
        CELESTIAL,
        CONTEMPLADOR,
        C_INFRAOSCURIDAD,
        DEMONIO,
        DIABLO,
        DRACONIDO,
        DRAGON,
        ELEMENTAL,
        ELFO,
        ENANO,
        FEERICO,
        GIGANTE,
        GOBLINOIDE,
        GNOMO,
        HUMANO,
        MEDIANO,
        OGRO,
        ORCO,
        SEMIELFO,
        SEMIORCO,
        TIFLIN };

    public TipoDeRaza nombre;
    [Tooltip("Incremento de Puntuación de Característica")]
    public int IPC;
    public int edad;
    public enum Etica { Legal, Neutral, Malvado };
    public Etica etica;
    public enum Moral { Bueno, Neutral, Caotico };
    public Moral moral;
    public float altura;
    public int velociadad;
    public int visionOscuridad;
    public List<Idioma> idiomasPosibles;
}
