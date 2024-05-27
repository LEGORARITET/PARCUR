using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingHeight : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Height"))
        {
            transform.localScale = transform.localScale + new Vector3(1f, 1f, 1f);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("obstacles"))
        {
            transform.localScale = transform.localScale - new Vector3(1f, 1f, 1f);
        }
    }  
}
