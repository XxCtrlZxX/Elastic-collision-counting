using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box2Collide : MonoBehaviour
{
    public static box2Collide instance;

    public float m2, v2;

    private void Awake()
    {
        m2 = 10000;
        v2 = -1f;
        if (instance == null)
            instance = this;
    }

    private void Update()
    {
        gameObject.transform.Translate(new Vector3(v2, 0, 0) * Time.deltaTime);
    }
}
