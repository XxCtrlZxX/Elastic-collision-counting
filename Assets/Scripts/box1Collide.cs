using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class box1Collide : MonoBehaviour
{
    public Text countText;
    public int count;

    private void Start()
    {
        count = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        count++;
        countText.text = "# Collisions: " + count.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.name == "box2")
        {
            m2 = box2Collide.instance.m2;
            v2 = box2Collide.instance.v2;
            float total_v1 = (v1 * (m1 - m2) + 2 * m2 * v2) / (m1 + m2);
            float total_v2 = (v2 * (m2 - m1) + 2 * m1 * v1) / (m1 + m2);
            v1 = total_v1;
            box2Collide.instance.v2 = total_v2;
        }
        if (collision.name == "wall")
            v1 *= -1;

        if (collision.name == "box2" || collision.name == "wall")
        {
            count++;
            countText.text = "# Collisions: " + count.ToString();
        }*/
    }
}
