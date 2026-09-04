using UnityEngine;

public class DeathZone : MonoBehaviour
{
    SceneManager Manager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Manager = GameObject.Find("GlobalManager").GetComponent<SceneManager>();      
    }

    // Update is called once per frame
    void Update()
    {
        TT();



    }


    void TT ()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("Hallo");
            GameObject Player = GameObject.FindWithTag("Player");
            Player.transform.position = Manager.Checkpoints[2].transform.position;
        }
    }



    // Met le joueur à un autre endroit
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int Value = Manager.currentCheckP;
            other.transform.position = Manager.Checkpoints[Value].transform.position;
            Debug.LogError("stop");
        }
    }



}
