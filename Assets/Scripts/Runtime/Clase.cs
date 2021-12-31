using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Class", menuName = "ScriptableObjects/Class", order = 1)]
public class Clase : ScriptableObject
{
    public enum TipoDeClase {
        BARBARO,
        BARDO,
        BRUJO,
        CLERIGO,
        DRUIDA,
        EXPLORADOR,
        GERRERO,
        HECHICERO,
        MAGO,
        MONJE,
        PALADIN,
        PICARO };
    public TipoDeClase nombre;
    public int nivel;
    
    public List<TiradaSalvacion> tiradasSalvacion;
    public int CD_SalvacionConjuros;
    public int dadosDeGolpe;
    public enum DadoDeGolpe { D4, D6, D8, D10, D12, D20, D100 };
    public DadoDeGolpe tipoDeDado;

    [Header("Tablas de clase")]
    public List<int> bonusCompetencia;
    public List<Rasgo> rasgos;
    [Tooltip("Nivel de clase = (id Lista + 1)")]
    public List<ConjuroPorNivel> conjurosPorNivel;
    [Tooltip("Nivel de conjuros = (id Lista)")]
    public List<PosiblesConjurosPorNivel> posiblesConjuros;
}

public enum TiradaSalvacion
{
    FUERZA,
    DESTREZA,
    CONSTITUCION,
    INTELIGENCIA,
    SABIDURIA,
    CARISMA
};

[System.Serializable]
public class ConjuroPorNivel
{
    [Tooltip("Nivel de conjuro = (id Lista + 1)")]
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
