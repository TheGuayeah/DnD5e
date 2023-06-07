using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Race", menuName = "ScriptableObjects/Race", order = 1)]
[System.Serializable]
public class Raza : ScriptableObject
{
    public TipoDeRaza nombre;
    [TableList]
    public List<IncrementoPuntuacion> incrementoPuntuacion;
    public int edadMaxima;    
    public Etica etica;
    public Moral moral;
    [Range(1, 10)]
    public int alturaMinima;
    [Range(1, 10)]
    public int alturaMaxima;
    public float pesoMedio;
    public int velociadadBase;
    public bool visionOscuridad;
    public List<Idioma> idiomasPosibles;
}

[System.Serializable]
public class IncrementoPuntuacion
{
    public Stats stat;
    public int valor;
}
