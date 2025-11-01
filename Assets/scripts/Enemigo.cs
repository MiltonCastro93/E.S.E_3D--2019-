using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour {
    protected NavMeshAgent navegacion;
    protected BoxCollider vista;
    protected AudioSource deteccion;
    protected Animator anim;
    public enum Estados { Patrulla,Deteccion}
    [HideInInspector]
    public Estados EstadoActual;
    public GameObject[] PuntosVigia;
    public GameObject descubrir;
    public GameObject loser;
    public GameObject IrMenu;
    public bool irB = false;
    public float velocidad = 0.5f;
    public float distanciaMax = 5f;
    
    void Start () {
        IrMenu.GetComponent<AudioSource>().enabled = true;
        anim = GetComponent<Animator>();
        anim.SetBool("Deteccion", false);
        vista = GetComponent<BoxCollider>();
        navegacion = GetComponent<NavMeshAgent>();
        deteccion = GetComponent<AudioSource>();
        navegacion.speed = velocidad;
        descubrir.SetActive(false);
        loser.SetActive(false);
        IrMenu.SetActive(false);
    }
	
	void Update () {
        switch (EstadoActual) {
            case Estados.Patrulla:
                controlEmocional();
                break;
            case Estados.Deteccion:
                Detectado();
                break;
        }

    }

    private void FixedUpdate() {
        RaycastHit distancia;
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out distancia, distanciaMax)) {
            vista.size = new Vector3(1.605078f, 1.114026f, (distancia.distance - 2f));
            if (vista.size.z <= 0) {//para que salte error sus boxcollider
                vista.size = new Vector3(1.605078f, 1.114026f, 0);
            }
        }
        Debug.DrawLine(ray.origin, distancia.point, Color.blue);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            anim.SetBool("Deteccion", true);
            deteccion.Play();
            EstadoActual = Estados.Deteccion;
            other.GetComponent<Player>().Enjuego = false;
            navegacion.SetDestination(other.GetComponent<Player>().transform.position);
        }
    }

    public virtual void controlEmocional() {
        if (!irB) {
            navegacion.SetDestination(PuntosVigia[0].transform.position);//voy al A
        } else {
            navegacion.SetDestination(PuntosVigia[1].transform.position);//voy al B
        }
    }

    public void Detectado() {
        descubrir.transform.position = transform.position;
        descubrir.transform.position += new Vector3(0, 1, 0);
        navegacion.isStopped = false;
        navegacion.speed = 0;
        descubrir.SetActive(true);
        loser.SetActive(true);
        IrMenu.SetActive(true);
    }
}
