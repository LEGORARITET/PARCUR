using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update CHEBUREC
    public int speed = 20;
    public float horizontal;
    public float vertical;
    public int rotationSpeed = 50;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
      
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);
       


    }



    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Point"))
        {
            Destroy(collision.gameObject);
        }
    }
}
