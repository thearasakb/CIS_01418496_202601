using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public float horizontalSpeed = 3f;
    
    
    void Update()

    {
        bool isTurning = false;

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            
            transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
           
        }
        if (Input.GetKey(KeyCode.A))
        {
           
            transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime  );
           
            }
     

    }
}
