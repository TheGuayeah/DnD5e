using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "ScriptableObjects/Spell", order = 1)]
public class Conjuro : ScriptableObject
{
    [HorizontalGroup("Fila1", width: 53)]
    [VerticalGroup("Fila1/Col1")]
    [PreviewField, HideLabel, Title("Icon", bold: false, horizontalLine: false)]
    [Space(-9)]
    public GameObject prefab;

    [VerticalGroup("Fila1/Col2")]
    [LabelWidth(75), Space(15)]
    public string nombre;

    [VerticalGroup("Fila1/Col2")]
    [Tooltip("Casillas")]
    [LabelWidth(75)]
    public int alcance;

    [VerticalGroup("Fila1/Col3")]
    [LabelWidth(75), Space(15)]
    public int nivel;

    [VerticalGroup("Fila1/Col3")]
    [LabelWidth(85)]
    public AreaDeEfecto areaEfecto;

    [HorizontalGroup("Fila2")]
    [VerticalGroup("Fila2/Col1")]
    public string duracion;

    [VerticalGroup("Fila2/Col1")]
    public string tiempoLanzamiento;
    [TextArea(4, 6)]
    public string descripcion;

    [Space(25)]

    public List<TiradaSalvacion> tiradasSalvacion;
    public List<TiradaSalvacion> tiradasAtaque;
    public List<Componente> componentes;
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
