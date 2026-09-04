using UnityEngine;

public class ChangeMat : MonoBehaviour
{

    public GameObject Porte;
    MeshRenderer Renderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Renderer = Porte.GetComponent<MeshRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Renderer.material.color = Color.green;
        }
    }



}
