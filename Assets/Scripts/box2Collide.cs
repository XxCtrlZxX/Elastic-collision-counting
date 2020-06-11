using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box2Collide : MonoBehaviour
{
    Rigidbody2D rb;

    public float startSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(startSpeed, 0));
        
    }

    private void Update()
    {
        
        //gameObject.transform.Translate(new Vector3(v2, 0, 0) * Time.deltaTime);
    }
}
