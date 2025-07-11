using TMPro;
using UnityEngine;

public class ButtonClickCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    void Start()
    {
        SetClickText(0);
    }
    public void SetClickText(int amount)
    {
        text.text = "Click : " + amount.ToString();
    }
}
