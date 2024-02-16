using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "New Race", menuName = "ScriptableObjects/Race", order = 1)]
[System.Serializable]
public class Race : ScriptableObject
{
    public LocalizedString name;
    public RacialOrigin racialOrigin;
    [TableList]
    public List<ScoreIncrement> scoreIncrement;
    public int maxAge;    
    public Ethics ethics;
    public Moral moral;
    [Range(1, 10)]
    public int minHeight;
    [Range(1, 10)]
    public int maxHeight;
    public float weightAvg;
    public int speedBase;
    public bool darknessVision;
    public List<Langague> possibleLanguages;
}

[System.Serializable]
public class ScoreIncrement
{
    public Stats stat;
    public int value;
}
