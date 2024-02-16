using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "New Spell", menuName = "ScriptableObjects/Spell", order = 1)]
public class Spell : ScriptableObject
{
    [HorizontalGroup("Fila1", width: 53)]
    [VerticalGroup("Fila1/Col1")]
    [PreviewField, HideLabel, Title("Icon", bold: false, horizontalLine: false)]
    [Space(-9)]
    public GameObject prefab;

    [VerticalGroup("Fila1/Col2")]
    [LabelWidth(75), Space(15)]
    public LocalizedString name;

    [VerticalGroup("Fila1/Col2")]
    [Tooltip("Casillas")]
    [LabelWidth(75)]
    public int distance;

    [VerticalGroup("Fila1/Col3")]
    [LabelWidth(75), Space(15)]
    public int level;

    [VerticalGroup("Fila1/Col3")]
    [LabelWidth(85)]
    public LocalizedString areaEffect;

    [HorizontalGroup("Fila2")]
    [VerticalGroup("Fila2/Col1")]
    public LocalizedString duration;

    [VerticalGroup("Fila2/Col1")]
    public LocalizedString castTime;
    //[TextArea(4, 6)]
    public LocalizedString description;

    [Space(25)]

    public List<DiceRoll> savingRolls;
    public List<DiceRoll> attackRolls;
    public List<Component> components;
}

public enum Component
{
    VERBAL,
    MATERIAL,
    SOMATIC
}
