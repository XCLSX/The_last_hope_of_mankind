using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_monster : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] create_point;
    public float timer = 1.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        int i = Random.Range(0, 16);
        if (timer <= 0)
        {
            create_monsters(i);
            timer = 1.0f;
        }
    }

    void create_monsters(int i)
    {
        GameObject monster = Resources.Load<GameObject>("prefab/monster");
        Instantiate(monster, create_point[i].position, Quaternion.identity);
    }
}
