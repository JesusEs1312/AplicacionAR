using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pikachu : MonoBehaviour {

    public Transform jugador;
    public float tamanoRandom;
    public int puntos;
    public Text txtPuntos;
 
    void Start()
    {
        cambiarPos();
        txtPuntos.text = puntos.ToString();
    }

    void sumarPuntos()
    {
        puntos++;
        txtPuntos.text = puntos.ToString();
    }

    private void OnMouseDown()
    {
        cambiarPos();
        sumarPuntos();
    }
     void cambiarPos () 
    {
        transform.position = new Vector3((Random.insideUnitSphere.x * tamanoRandom), transform.position.y, (Random.insideUnitSphere.z * tamanoRandom));
        Vector3 posjugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
        transform.LookAt (posjugador);
    }

}
