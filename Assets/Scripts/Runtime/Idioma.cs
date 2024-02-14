using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "New Langague", menuName = "ScriptableObjects/Langague", order = 1)]
public class Idioma : ScriptableObject
{
    public LocalizedString nombre;
    public Font textFontStyle;    
    public TipoDeEscritura escritura;
    [Tooltip("Texto que aparece cuando no hablas este idioma")]
    public LocalizedString unknownLanguage;
    public List<TipoDeRaza> hablantesTipicos;
    [Tooltip("Sonidos de los pesonajes al hablar")]
    public List<AudioClip> maleAudios, femaleAudios;
}
