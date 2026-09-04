using UnityEngine;


public class DifficultyMode : MonoBehaviour
{
    public int Value;
    Persistent PersScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PersScript = GameObject.Find("Manager").GetComponent<Persistent>();
    }

    // Update is called once per frame
     void Update()
    {
        
    }

    public void SetDifficulty ()
    {
        PersScript.Difficulty = Value;
    }


}
