using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Shooting : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f)&&(hit.collider.gameObject!= gameObject))
                 {  if(hit.collider.gameObject.GetComponent<JellyAI>())
                Destroy(hit.collider.gameObject);
        }

        }
       
        
    }
}
