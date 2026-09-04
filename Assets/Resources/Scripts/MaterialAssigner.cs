using UnityEngine;



[ExecuteInEditMode]
public class MaterialAssigner : MonoBehaviour
{
    public MeshRenderer[] Meshers;
    Material Ground;

    void AssignMats()
    {
        Ground = Resources.Load<Material>("DefaultGround"); // si on se trompe de nom il retourne un rendu graphique violet

        Meshers = GameObject.FindObjectsByType<MeshRenderer>(FindObjectsSortMode.None);

        foreach(MeshRenderer R in Meshers)
        {
            if (R.sharedMaterial == null)
            {
                R.material = Ground;
            }
        }

    }

     void Awake()
    {
        AssignMats();
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // AssignMats();
    }

   



    // Update is called once per frame
    void Update()
    {
        
    }
}
