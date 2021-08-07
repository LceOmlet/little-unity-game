using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfwayCollide : MonoBehaviour
{
    public GameObject Section;
    public float gap = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        Instantiate(Section, transform.position+ gap*transform.right, Quaternion.identity);
    } 
}
