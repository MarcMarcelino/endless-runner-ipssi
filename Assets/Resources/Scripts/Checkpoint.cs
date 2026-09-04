using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public int Value;
    SceneManager Manager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Manager = GameObject.Find("GlobalManager").GetComponent<SceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Manager.currentCheckP = Value;
            
        }
    }




}
