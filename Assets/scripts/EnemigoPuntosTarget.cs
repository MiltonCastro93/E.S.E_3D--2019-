using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPuntosTarget : Enemigo {
    public int ValorPosicional = 0;

    public override void controlEmocional() {
        if (navegacion.remainingDistance < 0.1f) {
            navegacion.SetDestination(PuntosVigia[ValorPosicional].transform.position);
            ValorPosicional = (ValorPosicional + 1) % PuntosVigia.Length;
        }
    }

}
