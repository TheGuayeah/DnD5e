using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;

public class Character : MonoBehaviour
{
    public string nombre;
    public Genero genero;
    public Raza raza;
    public Clase clase;

    public int puntosDeGolpeNv1;
    public int puntosDeGolpeNvSuperiores;


    [Header("Stats")]
    #region STATS
    public int fuerza;
    public int destreza;
    public int constitucion;
    public int inteligencia;
    public int sabiduria;
    public int carisma;
    [Space(10)]
    public int bonusCompetencia;
    #endregion

    [Header("Habilidades")]
    #region HABILIDADES
    public int acrobacias;
    public int atletismo;
    public int conocimientoArcano;
    public int engano;
    public int historia;
    public int interpretacion;
    public int investigacion;
    public int intimidacion;
    public int juegoDeManos;
    public int medicina;
    public int naturaleza;
    public int percepcion;
    public int perspicacia;
    public int persuasion;
    public int religion;
    public int sigilo;
    public int supervivencia;
    public int tratoConAnimales;
    #endregion

    void Start()
    {
        switch (raza.nombre)
        {
            case TipoDeRaza.AZOTAMENTES:
                break;
            case TipoDeRaza.CELESTIAL:
                break;
            case TipoDeRaza.CONTEMPLADOR:
                break;
            case TipoDeRaza.C_INFRAOSCURIDAD:
                break;
            case TipoDeRaza.DEMONIO:
                break;
            case TipoDeRaza.DIABLO:
                break;
            case TipoDeRaza.DRACONIDO:
                break;
            case TipoDeRaza.DRAGON:
                break;
            case TipoDeRaza.ELEMENTAL:
                break;
            case TipoDeRaza.ELFO:
                break;
            case TipoDeRaza.ENANO:
                break;
            case TipoDeRaza.FEERICO:
                break;
            case TipoDeRaza.GIGANTE:
                break;
            case TipoDeRaza.GOBLINOIDE:
                break;
            case TipoDeRaza.GNOMO:
                break;
            case TipoDeRaza.HUMANO:
                break;
            case TipoDeRaza.MEDIANO:
                break;
            case TipoDeRaza.SEMIELFO:
                break;
            case TipoDeRaza.SEMIORCO:
                break;
            case TipoDeRaza.TIFLIN:
                break;
            default:
                break;
        }

        switch (clase.nombre)
        {
            case TipoDeClase.BARBARO:
                break;
            case TipoDeClase.BARDO:
                break;
            case TipoDeClase.BRUJO:
                break;
            case TipoDeClase.CLERIGO:
                break;
            case TipoDeClase.DRUIDA:
                break;
            case TipoDeClase.EXPLORADOR:
                break;
            case TipoDeClase.GERRERO:
                break;
            case TipoDeClase.HECHICERO:
                break;
            case TipoDeClase.MAGO:
                break;
            case TipoDeClase.MONJE:
                break;
            case TipoDeClase.PALADIN:
                puntosDeGolpeNv1 = 10 + constitucion;
                puntosDeGolpeNvSuperiores = DiceOrNumber(10, 6) + 
                    (constitucion * (clase.nivel - 1));

                break;
            case TipoDeClase.PICARO:
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
