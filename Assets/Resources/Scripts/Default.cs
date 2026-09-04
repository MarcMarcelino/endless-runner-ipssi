using UnityEngine;


public class Default : MonoBehaviour
{
    Material Basic;
    public string Asset = "Child1";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GiveMaterial();
    }


    void GiveMaterial ()
    {
        Basic = Resources.Load<Material>("Yellow");


        GameObject.Find(Asset).GetComponent<MeshRenderer>().material = Basic;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
