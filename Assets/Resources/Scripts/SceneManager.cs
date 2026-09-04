using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;



public class SceneManager : MonoBehaviour
{
    public GameObject[] Checkpoints;
    public int currentCheckP =0;
    public List<string> OBJS;
    //public Image Donnée;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Checkpoints = GameObject.FindGameObjectsWithTag("CKs");

        for ( int i = 0; i < Checkpoints.Length; i++)
        {
            Checkpoints[i].name = "Checkpoint_" + i;
            Checkpoint Check = Checkpoints[i].GetComponent<Checkpoint>();
            Check.Value = i;
        }

        OBJS = new List<string>(0);

        OBJS.Add("valeurA");
        OBJS.Add("valeurB");


        if (OBJS.Count == 2)
        {
            Debug.Log("j'ai la bonne taille");
        }


      //  Donnée.color = Color.black;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
