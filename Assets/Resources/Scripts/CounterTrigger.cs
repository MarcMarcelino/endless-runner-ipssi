using UnityEngine;

[RequireComponent(typeof(Collider))]
public class CounterTrigger : MonoBehaviour
{
    [Header("Couleurs")]
    public Color defaultColor = Color.white;
    public Color activatedColor = Color.magenta;
    public int threshold = 3;

    private int count = 0;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        GetComponent<Collider>().isTrigger = true;
        rend.material.color = defaultColor;
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        count++;
        Debug.Log("Entree trigger n° : " + count);
        if (count >= threshold)
            rend.material.color = activatedColor;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(200, 10, 250, 30),
            "Compteur trigger : " + count);
    }
}