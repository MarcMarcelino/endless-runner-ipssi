using UnityEngine;
using TMPro; // TextMeshPro au lieu de UnityEngine.UI

public class AnimTrigger : MonoBehaviour
{
    [Header("Animation")]
    public Animator targetAnimator;
    public string paramName = "IsRotating";

    [Header("UI")]
    public TextMeshProUGUI paramDisplay; // TextMeshPro au lieu de Text

    private bool isRotating = false;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        
        // Bascule la valeur true/false
        isRotating = !isRotating;
        
        // Met à jour le paramètre dans l'Animator
        targetAnimator.SetBool(paramName, isRotating);
        
        // Met à jour le texte à l'écran
        UpdateUI();
    }

    void UpdateUI()
    {
        if (paramDisplay != null)
            paramDisplay.text = paramName + " : " + isRotating;
    }
}