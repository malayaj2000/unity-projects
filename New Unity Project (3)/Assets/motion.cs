using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class motion : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0.2f, 0);
        }
        gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);
        
    }
}
