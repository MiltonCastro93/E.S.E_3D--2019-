using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MenuDInamico : MonoBehaviour {
    protected NavMeshAgent navegacion;
    public GameObject[] PuntosVigia;
    public bool irB = false;
    
    void Start () {
        navegacion = GetComponent<NavMeshAgent>();
    }
	
	void Update () {
        if (!irB) {
            navegacion.SetDestination(PuntosVigia[0].transform.position);//voy al A
        } else {
            navegacion.SetDestination(PuntosVigia[1].transform.position);//voy al B
        }
    }
}
