using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource audioSource;  // Sound, der im Bereich abgespielt wird

    private void OnTriggerEnter(Collider other)
    {
        // Prüfen, ob der Spieler den Trigger betritt
        if (other.CompareTag("Player"))
        {
            // Sound starten, falls nicht bereits spielend
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Prüfen, ob der Spieler den Trigger verlässt
        if (other.CompareTag("Player"))
        {
            // Sound stoppen, falls er läuft
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
