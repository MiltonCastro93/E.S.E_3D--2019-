using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetivosVigia : MonoBehaviour {//soy A
    public string NombrePunto = " ";

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemigo")) {
            if (NombrePunto == "A") {
                other.GetComponent<Enemigo>().irB = true;
            } else {
                other.GetComponent<Enemigo>().irB = false;
            }
        }
        if (other.CompareTag("Enemigo2")) {
            if (NombrePunto == "A") {
                other.GetComponent<MenuDInamico>().irB = true;
            } else {
                other.GetComponent<MenuDInamico>().irB = false;
            }
        }


        /*
        if (other.CompareTag("Enemigo2")) {
            if (NombrePunto == "A") {
                other.GetComponent<EnemigoPuntosTarget>().ValorPosicional = 1;
            }
            if(NombrePunto == "B") {
                other.GetComponent<EnemigoPuntosTarget>().ValorPosicional = 2;
            }
            if(NombrePunto == "C") {
                other.GetComponent<EnemigoPuntosTarget>().ValorPosicional = 0;
            }
        }
        */
    }

}
