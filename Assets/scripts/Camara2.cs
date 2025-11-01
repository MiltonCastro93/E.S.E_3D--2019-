using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara2 : MonoBehaviour {
    protected AudioSource deteccion;
    private bool detectado = false;
    private GameObject elise;
    public bool nuevaPos = true;
    public float speed = 1f;
    public GameObject descubrir;
    public GameObject loser;
    public GameObject IrMenu;

    private void Start() {
        descubrir.SetActive(false);
        loser.SetActive(false);
        IrMenu.SetActive(false);
        deteccion = GetComponent<AudioSource>();
        elise = transform.GetChild(1).gameObject;
    }

    void Update () {
        elise.transform.Rotate(Vector3.up * 10f);
        if (!detectado) {
            if (nuevaPos) {
                if (transform.position.z < 4.30f) {
                    if (transform.position.z > 4.20f) {
                        nuevaPos = false;
                    }
                    transform.position -= transform.forward * speed;
                }
            } else {
                if (transform.position.z > -4.30f) {
                    if (transform.position.z < -4.20f) {
                        nuevaPos = true;
                    }
                    transform.position -= -transform.forward * speed;
                }
            }
        }
	}

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            descubrir.transform.position = transform.position;
            descubrir.transform.position += new Vector3(0, 1, 0);
            descubrir.SetActive(true);
            loser.SetActive(true);
            IrMenu.SetActive(true);
            detectado = true;
        }
    }

}
