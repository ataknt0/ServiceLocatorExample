using Unity.VisualScripting;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class ButtonSoundManager : MonoBehaviour
{
    // Reference to the AudioSource component responsible for playing sounds.
    private AudioSource source;

    [Header("References")]
    // The audio clip to be played when a button is clicked.
    [SerializeField] private AudioClip clip;

    private void Awake()
    {
        // Attempts to retrieve the AudioSource component from the GameObject.
        // If not found (shouldn't happen due to [RequireComponent]), logs an error.
        if (!TryGetComponent<AudioSource>(out source))
        {
            Debug.LogError("There is no AudioSource on this GameObject.");
        }
    }
    public void PlayButtonSound()
    {
        // Ensures the clip has been assigned in the Inspector.
        if (clip == null)
        {
            Debug.LogError("AudioClip is missing. Please assign one in the Inspector.");
            return;
        }

        // Plays the clip once without interrupting any currently playing sounds.
        source.PlayOneShot(clip);
    }
}
