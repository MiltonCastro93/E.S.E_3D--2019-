using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour {
    public GameObject victoria;
    public GameObject irMenu;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            if (other.GetComponent<Player>().Enjuego == true) {
                victoria.SetActive(true);
                irMenu.SetActive(true);
                irMenu.GetComponent<AudioSource>().enabled = false;
                Time.timeScale = 0;
            }
        }
    }

}
