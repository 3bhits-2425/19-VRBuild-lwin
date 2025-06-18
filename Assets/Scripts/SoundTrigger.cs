using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource audioSource;  // Sound, der im Bereich abgespielt wird

    private void OnTriggerEnter(Collider other)
    {
        // Pr�fen, ob der Spieler den Trigger betritt
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
        // Pr�fen, ob der Spieler den Trigger verl�sst
        if (other.CompareTag("Player"))
        {
            // Sound stoppen, falls er l�uft
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
