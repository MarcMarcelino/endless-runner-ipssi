using UnityEngine;
using TMPro;

public class DisplayName : MonoBehaviour
{
    // Le texte qui affichera le nom en jeu
    public TextMeshProUGUI nameText;

    void Start()
    {
        // Cherche le Manager qui a survécu depuis MainMenu
        GameObject manager = GameObject.Find("Manager");

        if (manager != null)
        {
            Persistent persist = manager.GetComponent<Persistent>();
            if (persist != null && nameText != null)
                nameText.text = "Joueur : " + persist.playerName;
        }
        else
        {
            Debug.Log("Manager non trouvé - test direct depuis TP");
        }
    }
}