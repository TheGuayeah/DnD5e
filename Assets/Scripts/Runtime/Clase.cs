using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "New Class", menuName = "ScriptableObjects/Class", order = 1)]
public class Clase : ScriptableObject
{    
    public LocalizedString nombre;
    public TipoDeClase tipoDeClase;
    public int nivel;
    
    public List<TiradaSalvacion> tiradasSalvacion;
    public int CD_SalvacionConjuros;
    public int dadosDeGolpe;
    public TipoDeDado tipoDeDado;

    [TabGroup("TabGroup1", "Tablas de clase")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    public List<int> bonusCompetencia;

    [TabGroup("TabGroup1", "Tablas de clase")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    [TableList]
    public List<Rasgo> rasgos;

    [Tooltip("Nivel de clase = (id Lista + 1)")]
    [TabGroup("TabGroup1", "Tablas de clase")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    public List<ConjuroPorNivel> conjurosPorNivel;

    [Tooltip("Nivel de conjuros = (id Lista)")]
    [TabGroup("TabGroup1", "Tablas de clase")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    public List<PosiblesConjurosPorNivel> posiblesConjuros;
}

[System.Serializable]
public class ConjuroPorNivel
{
    [Tooltip("Nivel de conjuro = (id Lista + 1)")]
    [ListDrawerSettings(ShowIndexLabels = true)]
    public List<int> conjurosPorDia;
}

[System.Serializable]
public class PosiblesConjurosPorNivel
{
    public List<Conjuro> conjuros;
}

[System.Serializable]
public class Rasgo
{
    public string nombre;
    [Range(1, 20)]
    public int nivel;
    public string efecto;
}
