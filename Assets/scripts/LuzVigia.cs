using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzVigia : MonoBehaviour {
    public Vector3 posInicial = new Vector3(50,100,0);
    public Vector3 posFin = new Vector3(50, 200, 0);
    public float TiempoLimite = 0f;
    public float PorcenTiempo = 0f;
    private float TiempoActual = 0f;
    public bool vuelta = true;

    void Update() {
        TiempoActual += Time.deltaTime;
        TiempoActual = Mathf.Clamp(TiempoActual, 0, TiempoLimite);
        PorcenTiempo = TiempoActual / TiempoLimite;

        if (vuelta) {
            transform.rotation = Quaternion.Lerp(Quaternion.Euler(posInicial), Quaternion.Euler(posFin), PorcenTiempo);
            if(transform.rotation.eulerAngles.y >= (posFin.y - 1f)) {
                vuelta = false;
                TiempoActual = 0;
            }
        } else {
            transform.rotation = Quaternion.Lerp(Quaternion.Euler(posFin), Quaternion.Euler(posInicial), PorcenTiempo);
            if(transform.rotation.eulerAngles.y <= (posInicial.y + 1f)){
                vuelta = true;
                TiempoActual = 0;
            }
        }


    }

}
