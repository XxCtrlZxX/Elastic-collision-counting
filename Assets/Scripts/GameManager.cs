using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /*public Text countText;

    public static GameManager instance;

    public GameObject box1, box2;

    public float v1, m1, v2, m2 = 100;

    public int count;

    void Awake()
    {
        if (instance == null)
            instance = this;
        v1 = 0;
        m1 = 1;
        v2 = -1;
        count = 0;
    }

    void Update()
    {
        box1.transform.Translate(new Vector3(v1, 0, 0) * Time.deltaTime);
        box2.transform.Translate(new Vector3(v2, 0, 0) * Time.deltaTime);
        countText.text = "# Collisions: " + count.ToString();
    }*/
}


/*float total_v1 = (v1 * (m1 - m2) + 2 * m2 * v2) / (m1 + m2);
float total_v2 = (v2 * (m2 - m1) + 2 * m1 * v1) / (m1 + m2);

if (collision.name == "box2" || collision.name == "wall")
      countText.text = "# Collisions: " + count.ToString();*/