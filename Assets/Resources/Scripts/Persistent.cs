using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class Persistent : MonoBehaviour
{
    public int Difficulty;

    // Stocke le nom saisi dans l'InputField
    public string playerName = "";

    // Référence à l'InputField du menu
    public InputField nameInputField;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Appelé par le bouton Play
    public void LoadGame()
    {
        if (nameInputField != null)
            playerName = nameInputField.text;

        // On utilise le nom complet pour éviter le conflit
        // avec le script SceneManager.cs du projet
        UnityEngine.SceneManagement.SceneManager.LoadScene("TP");
    }
}