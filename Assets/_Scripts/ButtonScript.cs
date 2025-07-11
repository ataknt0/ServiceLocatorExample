using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private int clickAmount;
    private ButtonClickCounter clickManager;
    private ButtonSoundManager soundManager;


    void Awake()
    {
        clickManager = ServiceLocator.GetService<ButtonClickCounter>();
        soundManager = ServiceLocator.GetService<ButtonSoundManager>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickAmount++;
            clickManager.SetClickText(clickAmount);
            soundManager.PlayButtonSound();
        }
    }
}
