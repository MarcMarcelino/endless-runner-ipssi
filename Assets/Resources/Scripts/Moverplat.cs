using UnityEngine;

public class Moverplat : MonoBehaviour
{

    public float Speed = 4f;

     public float minBound = -7f;
    public float maxBound = 7f;
    private int direction = 1; // 1 = avant, -1 = arrière

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            
    }
    void Update()
    {
        Vector3 Forward = new Vector3(1, 0, 0);
        transform.Translate(Forward * Speed * direction * Time.deltaTime);

        // AJOUTÉ : inversion aux bornes
        float posX = transform.position.x;
        if (posX <= minBound) direction = 1;
        if (posX >= maxBound) direction = -1;
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction *= -1;
            Debug.Log("Cubequibouge : inversion !");
        }
    }
}
