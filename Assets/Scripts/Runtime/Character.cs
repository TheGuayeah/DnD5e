using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;

public class Character : MonoBehaviour
{
    public string name;
    public Gender gender;
    public Race race;
    public CharacterClass characterClass;

    public int armorClass;
    public int difficultyClass;


    [Header("Stats")]
    #region STATS
    public int strength;
    public int dexterity;
    public int constitution;
    public int inteligence;
    public int wisdom;
    public int charisma;
    [Space(10)]
    public int bonusCompetence;
    #endregion

    [Header("Skill Checks")]
    #region HABILIDADES
    public int acrobatics;
    public int athletics;
    [Tooltip("Conocimiento arcano")]
    public int arcana;
    [Tooltip("Engaño")]
    public int deception;
    public int history;
    public int interpretation;
    public int investigation;
    public int intimidation;
    [Tooltip("Juego de manos")]
    public int sleightOfHand;
    public int medicine;
    public int nature;
    public int perception;
    [Tooltip("Perspicacia")]
    public int insight;
    public int persuasion;
    public int religion;
    [Tooltip("Sigilo")]
    public int stealth;
    public int survival;
    [Tooltip("Trato con animales")]
    public int animalHandling;
    #endregion

    void Start()
    {
        switch (race.racialOrigin)
        {
            case RacialOrigin.MIND_FLAYER:
                break;
            case RacialOrigin.CELESTIAL:
                break;
            case RacialOrigin.CONTEMPLADOR:
                break;
            case RacialOrigin.C_INFRAOSCURIDAD:
                break;
            case RacialOrigin.DEMON:
                break;
            case RacialOrigin.DEVIL:
                break;
            case RacialOrigin.DRAGON_BORN:
                break;
            case RacialOrigin.DRAGON:
                break;
            case RacialOrigin.ELEMENTAL:
                break;
            case RacialOrigin.ELF:
                break;
            case RacialOrigin.DWARF:
                break;
            case RacialOrigin.FEERICO:
                break;
            case RacialOrigin.GIANT:
                break;
            case RacialOrigin.GOBLINOID:
                break;
            case RacialOrigin.GNOME:
                break;
            case RacialOrigin.HUMAN:
                break;
            case RacialOrigin.HALFLING:
                break;
            case RacialOrigin.SEMIELF:
                break;
            case RacialOrigin.SEMIORC:
                break;
            case RacialOrigin.TIEFLING:
                break;
            default:
                break;
        }

        switch (characterClass.classType)
        {
            case ClassType.BARBARIAN:
                break;
            case ClassType.BARD:
                break;
            case ClassType.WARLOCK:
                break;
            case ClassType.CLERIC:
                break;
            case ClassType.DRUID:
                break;
            case ClassType.RANGER:
                break;
            case ClassType.FIGHTER:
                break;
            case ClassType.SORCERER:
                break;
            case ClassType.WIZARD:
                break;
            case ClassType.MONK:
                break;
            case ClassType.PALADIN:
                characterClass.hitPointsLevel1 = 10 + constitution;
                characterClass.hitPointsHigherLevels = DiceOrNumber(10, 6) + 
                    (constitution * (characterClass.level - 1));

                break;
            case ClassType.ROGUE:
                break;
            default:
                break;
        }

    }

    private int DiceOrNumber(int diceMax, int number)
    {
        int dice = Random.Range(0, 1);

        if (dice == 1)
            return Random.Range(1, diceMax);
        else
            return number;
    }
}
