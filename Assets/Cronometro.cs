using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public Text tiempoText; // Referencia al texto UI
    private float tiempoTranscurrido = 0f;
    private bool estaPausado = true; // Comienza pausado hasta que el usuario inicie

    void Update()
    {
        if (!estaPausado)
        {
            tiempoTranscurrido += Time.deltaTime;
            ActualizarTiempoDisplay();
        }
    }

    void ActualizarTiempoDisplay()
    {
        int horas = (int)(tiempoTranscurrido / 3600);
        int minutos = (int)((tiempoTranscurrido % 3600) / 60);
        int segundos = (int)(tiempoTranscurrido % 60);

        tiempoText.text = string.Format("{0:00}:{1:00}:{2:00}", horas, minutos, segundos);
    }

    public void Pause()
    {
        estaPausado = true;
    }

    public void Play()
    {
        estaPausado = false;
    }

    public void Restart()
    {
        tiempoTranscurrido = 0f;
        estaPausado = true;
        ActualizarTiempoDisplay();
    }
}