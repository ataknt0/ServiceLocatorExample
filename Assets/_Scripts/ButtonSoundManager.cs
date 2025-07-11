using Unity.VisualScripting;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class ButtonSoundManager : MonoBehaviour
{
    private AudioSource source;
    [Header("References")]
    [SerializeField] private AudioClip clip;

    void Awake()
    {
        if (!TryGetComponent<AudioSource>(out source))
        {
            Debug.LogError("There is no AuidoSource in this gameobject");
        }
    }
    public void PlayButtonSound()
    {
        if (clip == null)
        {
            Debug.LogError("This clip has not been assigned via the Inspector. Please assign the clip in the Inspector.");
        }
        source.PlayOneShot(clip);
    }
}
