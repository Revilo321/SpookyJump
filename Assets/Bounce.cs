using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0){
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
            source.Play();
        }
    }
}
