using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "New Langague", menuName = "ScriptableObjects/Langague", order = 1)]
public class Langague : ScriptableObject
{
    public LocalizedString name;
    public Font textFontStyle;    
    public WritingStyle writingStyle;
    [Tooltip("Texto que aparece cuando no hablas este idioma")]
    public LocalizedString unknownLanguage;
    public List<RacialOrigin> typicalSpeakers;
    [Tooltip("Sonidos de los pesonajes al hablar")]
    public List<AudioClip> maleAudios, femaleAudios;
}
