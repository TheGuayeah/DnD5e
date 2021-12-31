using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Langague", menuName = "ScriptableObjects/Langague", order = 1)]
public class Idioma : ScriptableObject
{
    public string nombre;
    public Font textFontStyle;
    public enum TipoDeEscritura
    {
        NINGUNA,
        CELESTIAL,
        COMUN,
        DRACONIDO,
        ELFICO,
        ENANO,
        INFERNAL
    };
    public TipoDeEscritura escritura;
    [Tooltip("Texto que aparece cuando no hablas este idioma")]
    public string unknownLanguage;
    public List<Raza.TipoDeRaza> hablantesTipicos;
    [Tooltip("Sonidos de los pesonajes al hablar")]
    public List<AudioClip> maleAudios, femaleAudios;
}
