using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;


public class JellyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed = 0.5f;
    public Rigidbody rb;
    public float jumpforce = 6f;
    private Vector3 jmp;
    void Start() {
        rb = GetComponent<Rigidbody>();
        jmp = transform.up * jumpforce;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target);
        if (transform.position.y > target.position.y + 1.5f)
        {

            Jump();
        }
       /* if (Vector3.Distance(transform.position, target.position) < 2f)
            SceneManager.LoadScene(SceneManager.GetActiveScene() );
       */
    }
        bool isGrounded() {
            Collider[] cc = Physics.OverlapSphere(new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z), 0.7f);
            int j = 0;
            for (int i = 0; i < cc.Length; i++) {

                if (cc[i].gameObject != gameObject) {
                    j++;

                }
            }
            return j > 0;
        }
        void Jump() {
            if (isGrounded()) {
                rb.AddForce(jmp, ForceMode.Impulse); }
        }
      /*  void OnCollisionEnter( Collision other) {
            if(other.gameObject.GetComponent<Shooting>().name)
            SceneManager.LoadScene(SceneManager.GetActiveScene());*/
        }
    
    

