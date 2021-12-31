using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;

public class Character : MonoBehaviour
{
    public string nombre;
    public enum Genero { HOMBRE, MUJER, INDEFINIDO }
    public Genero genero;
    public Raza raza;
    public Clase clase;

    public int puntosDeGolpeNv1;
    public int puntosDeGolpeNvSuperiores;


    [Header("Stats")]
    public int fuerza;
    public int destreza;
    public int constitucion;
    public int inteligencia;
    public int sabiduria;
    public int carisma;
    [Space(10)]
    public int bonusCompetencia;

    [Header("Habilidades")]
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

    void Start()
    {
        switch (raza.nombre)
        {
            case Raza.TipoDeRaza.ENANO:
                break;
            case Raza.TipoDeRaza.ELFO:
                break;
            case Raza.TipoDeRaza.MEDIANO:
                break;
            case Raza.TipoDeRaza.HUMANO:
                break;
            case Raza.TipoDeRaza.DRACONIDO:
                break;
            case Raza.TipoDeRaza.GNOMO:
                break;
            case Raza.TipoDeRaza.SEMIELFO:
                break;
            case Raza.TipoDeRaza.SEMIORCO:
                break;
            case Raza.TipoDeRaza.TIFLIN:
                break;
            default:
                break;
        }

        switch (clase.nombre)
        {
            case Clase.TipoDeClase.BARBARO:
                break;
            case Clase.TipoDeClase.BARDO:
                break;
            case Clase.TipoDeClase.BRUJO:
                break;
            case Clase.TipoDeClase.CLERIGO:
                break;
            case Clase.TipoDeClase.DRUIDA:
                break;
            case Clase.TipoDeClase.EXPLORADOR:
                break;
            case Clase.TipoDeClase.GERRERO:
                break;
            case Clase.TipoDeClase.HECHICERO:
                break;
            case Clase.TipoDeClase.MAGO:
                break;
            case Clase.TipoDeClase.MONJE:
                break;
            case Clase.TipoDeClase.PALADIN:
                puntosDeGolpeNv1 = 10 + constitucion;
                puntosDeGolpeNvSuperiores = DiceOrNumber(10, 6) + 
                    (constitucion * (clase.nivel - 1));

                break;
            case Clase.TipoDeClase.PICARO:
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
