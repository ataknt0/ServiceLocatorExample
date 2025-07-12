using TMPro;
using UnityEngine;
public class ButtonClickCounter : MonoBehaviour
{
    // Reference to the TextMeshPro text component in the UI.
    // This should be assigned via the Inspector.
    [SerializeField] private TMP_Text text;
    
    // Initializes the counter display to zero.
    private void Start()
    {
        SetClickText(0);
    }

    // Public method to update the displayed click count.
    // This can be called from other scripts when the click count changes.
    public void SetClickText(int amount)
    {
        // Updates the text to show something like "Click : 5"
        text.text = "Click : " + amount.ToString();
    }
}
