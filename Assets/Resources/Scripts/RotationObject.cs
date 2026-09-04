using UnityEngine;

public class RotationObject : MonoBehaviour
{
  [Header("Rotation")]
    public float rotationSpeed = 90f;
    public Vector3 rotationAxis = Vector3.up;

    private bool isRotating = false; // AJOUTÉ : pas de rotation au départ
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      rb = GetComponent<Rigidbody>();
        rb.useGravity = false;           //  pas de gravité
        rb.angularVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
            transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
    public void AllCoinsCollected()
    {
        isRotating = true;
        Debug.Log("Tous les coins ramassés → rotation activée !");
    }

     void OnCollisionEnter(Collision collision)
    {
     if (collision.collider != null)
        {
          //  Debug.Log("do something");
        }
    }
}
