using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "New Class", menuName = "ScriptableObjects/Class", order = 1)]
public class CharacterClass : ScriptableObject
{    
    public LocalizedString name;
    public LocalizedString description;
    public ClassType classType;
    public int level;

    [Tooltip("Tiradas de salvación")]
    public List<DiceRoll> savingRolls;
    public int spellSavingDC;
    public int hitPointsLevel1;
    public int hitPointsHigherLevels;
    public int hitDiceCount;
    public DiceType diceType;

    [TabGroup("TabGroup1", "Tablas de clase")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    public List<int> bonusCompetence;

    [TabGroup("TabGroup1", "Tablas de clase")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    [TableList]
    [Tooltip("Rasgos")]
    public List<Trait> traits;

    [Tooltip("Nivel de clase = (id Lista + 1)")]
    [TabGroup("TabGroup1", "Tablas de clase")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    public List<SpellByLevel> spellsByLevel;

    [Tooltip("Nivel de conjuros = (id Lista)")]
    [TabGroup("TabGroup1", "Tablas de clase")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    public List<PossibleSpellsByLevel> possibleSpells;
}

[System.Serializable]
public class SpellByLevel
{
    [Tooltip("Nivel de conjuro = (id Lista + 1)")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    public List<int> dailySpellCount;
}

[System.Serializable]
public class PossibleSpellsByLevel
{
    public List<Spell> spells;
}

[System.Serializable]
/// <summary> Rasgos de clase </summary>
public class Trait
{
    public string name;
    [Range(1, 20)]
    public int level;
    public string effect;
}
