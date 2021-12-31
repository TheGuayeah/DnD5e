using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "ScriptableObjects/Spell", order = 1)]
public class Conjuro : ScriptableObject
{
    public string nombre;
    public int nivel;
    public string tiempoLanzamiento;
    [Tooltip("Casillas")]
    public int alcance;
    public string duracion;
    public AreaDeEfecto areaEfecto;
    public List<TiradaSalvacion> tiradasSalvacion;
    public List<TiradaSalvacion> tiradasAtaque;
    public List<Componente> componentes;
    public GameObject prefab;
    [TextArea(4, 6)]
    public string descripcion;
}

public enum AreaDeEfecto
{
    LINEA,
    CONO,
    CUBO,
    ESFERA,
    CILINDRO
}

public enum Componente
{
    VERBAL,
    MATERIAL,
    SOMATICO
}
