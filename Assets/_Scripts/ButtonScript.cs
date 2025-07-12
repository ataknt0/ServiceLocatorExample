using UnityEngine;
public class ButtonScript : MonoBehaviour
{
    // Keeps track of how many times the user has clicked.
    private int clickAmount;

    // Reference to the UI manager responsible for updating the click counter text.
    private ButtonClickCounter clickManager;

    // Reference to the audio manager responsible for playing click sounds.
    private ButtonSoundManager soundManager;

    private void Awake()
    {
        // Retrieves the services from the ServiceLocator during initialization.
        // This approach avoids hard dependencies and improves code modularity.
        clickManager = ServiceLocator.GetService<ButtonClickCounter>();
        soundManager = ServiceLocator.GetService<ButtonSoundManager>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Increments the internal click counter.
            clickAmount++;

            // Updates the UI with the new click count.
            clickManager.SetClickText(clickAmount);

            // Plays the click sound using the sound manager.
            soundManager.PlayButtonSound();
        }
    }
}
