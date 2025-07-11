using TMPro;
using UnityEngine;

public class ButtonClickCounter : MonoBehaviour
{
    public static ButtonClickCounter Instance { get; private set; }
    [SerializeField] private TMP_Text text;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    void Start()
    {
        SetClickText(0);
    }
    public void SetClickText(int amount)
    {
        text.text = "Click : " + amount.ToString();
    }
}
