using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoCam : MonoBehaviour {
    protected AudioSource deteccion;
    private bool detectadoMirar = false;
    private GameObject jugador;
    public float VelRotacional = 1f;
    public float AnguloVigia = 0f;//tiene que ser menor de 180, a no ser que quiera que sean las camaras de 360
    public bool NuevaRotacion;
    public GameObject descubrir;
    public GameObject loser;
    public GameObject IrMenu;

    private void Start() {
        descubrir.SetActive(false);
        loser.SetActive(false);
        IrMenu.SetActive(false);
        deteccion = GetComponent<AudioSource>();
    }

    void Update () {
        orientacionTipo();
    }

    public void orientacionTipo() {
        if (!detectadoMirar) {
            if (NuevaRotacion) {
                if (transform.rotation.eulerAngles.y > AnguloVigia) {
                    transform.Rotate(Vector3.up, -VelRotacional, Space.Self);
                    if (transform.rotation.eulerAngles.y < AnguloVigia) {
                        NuevaRotacion = false;
                    }
                }
            } else {
                if (transform.rotation.eulerAngles.y < (AnguloVigia * 3)){//si es 90, lo multiplico por 3 para que me de 270
                    transform.Rotate(Vector3.up, VelRotacional, Space.Self);
                    if (transform.rotation.eulerAngles.y > (AnguloVigia * 3)) {
                        NuevaRotacion = true;
                    }
                }
            }
        } else {
            transform.LookAt(jugador.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            jugador = other.GetComponent<Player>().gameObject;
            detectadoMirar = true;
            deteccion.Play();
            other.GetComponent<Player>().Enjuego = false;
            descubrir.transform.position = transform.position;
            descubrir.transform.position += new Vector3(0, 0.5f, 0);
            descubrir.SetActive(true);
            loser.SetActive(true);
            IrMenu.SetActive(true);
        }
    }
}
