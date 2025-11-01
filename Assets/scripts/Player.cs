using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour {
    private NavMeshAgent navegacion;
    private Animator anim;
    private float VelZ = 0f;
    public GameObject Target;
    private bool EstadoCaminar = false;
    public bool Enjuego = true;

    private void Awake() {
        navegacion = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        Time.timeScale = 1;
    }
	
	void FixedUpdate () {
        if (Target != null) {
            EstadoCaminar = true;
        } else {
            EstadoCaminar = false;
        }

        if (EstadoCaminar) {
            if (Enjuego) {
                navegacion.SetDestination(Target.transform.position);
                VelZ += Time.smoothDeltaTime;
            }
        } else {
            VelZ = 0;
        }
        VelZ = Mathf.Clamp(VelZ, 0f, 2f);
        anim.SetFloat("VelZ", VelZ);
    }


}
