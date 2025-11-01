using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearTarget : MonoBehaviour {
    private Vector3 _posicionStart;
    public GameObject targetPrefab;
    public GameObject TargetInstanciado;
    public Player jugador;

    private void Start() {
        _posicionStart = transform.position;
    }

    void Update () {
        RaycastHit golpe;
        if (!TargetInstanciado && jugador.Enjuego) {
            if (Input.GetMouseButtonDown(0)) {
                Ray inicio = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(inicio, out golpe, Mathf.Infinity)) {
                    if(golpe.collider.CompareTag("piso")) {
                        Vector3 posicionChoque = golpe.point;
                        TargetInstanciado = Instantiate<GameObject>(targetPrefab, posicionChoque, Quaternion.identity);
                        jugador.Target = TargetInstanciado;
                    }
                }
            }
        }
        _posicionStart = jugador.transform.position;
        _posicionStart.y = transform.position.y;
    }
    private void LateUpdate() {
        transform.position = _posicionStart;
        transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
    }
}
