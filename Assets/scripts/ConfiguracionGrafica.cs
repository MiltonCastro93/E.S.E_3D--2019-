using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfiguracionGrafica : MonoBehaviour {
    public static ConfiguracionGrafica cg;
    public Slider BarraConfig;
    public Image Image;
    public int valor = 5;

	void Start () {
        Time.timeScale = 1;
		if(cg == null) {
            cg = this;
            ConfiguracionGrafica.DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
            return;
        }
        if (PlayerPrefs.HasKey("graficos")) {//existe este dato guardado?
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("graficos"));
            BarraConfig.value = PlayerPrefs.GetInt("graficos");
        }
    }
	
	void Update () {
        QualitySettings.SetQualityLevel(valor);
    }

    public void configuraciones() {
        valor = (int)BarraConfig.value;
        if(valor <= 2) {
            Image.color = Color.green;
        } else if(valor == 3) {
            Image.color = Color.yellow;
        } else {
            Image.color = Color.red;
        }
        if (Image.IsActive()) {
            PlayerPrefs.SetInt("graficos", valor);
            PlayerPrefs.Save();
        }
    }

}
