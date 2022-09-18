using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_monster : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] create_point;
    public float timer = 1.0f;
    public float timer_reduce = 1.0f;//作为赋给怪物生成定时器的时间长度，随击杀怪物数量增多而减少
    int monster_num = 0;
    void Start()
    {
        timer = timer_reduce;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        int i = Random.Range(0, 32);
        if (timer <= 0)
        {
            create_monsters(i);
            monster_num++;
            timer = timer_reduce;
            if (monster_num % 10 == 0)
            {
                if (timer_reduce > 0.2f)
                    timer_reduce -= 0.1f;
            }
        }

    }

    void create_monsters(int i)
    {
        GameObject monster = Resources.Load<GameObject>("prefab/monster");
        Instantiate(monster, create_point[i].position, Quaternion.identity);
    }
}
