using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private int clickAmount;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickAmount++;
            ButtonClickCounter.Instance.SetClickText(clickAmount);
            ButtonSoundManager.Instance.PlayButtonSound();
        }
    }
}
