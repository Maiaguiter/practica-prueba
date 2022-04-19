using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica : MonoBehaviour
{
    public int entradasplatea;
    public int entradascampo;

    // Start is called before the first frame update
    void Start()
    {
        int precioentradasplatea = entradasplatea * 2000;
        int precioentradascampo = entradascampo * 1200;
        int totalentradas = entradasplatea + entradascampo;
        int faltante = 36600 - totalentradas;

        if(entradascampo < 0 && entradasplatea < 0 && entradasplatea > 16200 && entradascampo > 20400)
        {
            Debug.Log("Error");
        }
        else
        {
            Debug.Log("Sold Out!");

            if (entradascampo > 0 && entradasplatea > 0)
            {
                Debug.Log("Se recaudo " + precioentradasplatea + " pesos para las entradas de platea y " + precioentradascampo + " pesos para las entradas del campo, el total recaudado es de " + totalentradas + " pesos");
            }
            if (entradascampo < 20400 && entradasplatea < 16200)
            {
                Debug.Log("La cantidad de entradas que no se compraron fueron de " + faltante);
            }
            if (entradascampo > 10200 && entradasplatea > 8100)
            {
                Debug.Log("El festival fue un exito!");
            }
            if (entradascampo < 10200 && entradasplatea < 8100)
            {
                Debug.Log("Debemos mejorar la convocatoria");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
