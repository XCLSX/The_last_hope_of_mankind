using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_move : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        player = GameObject.Find("езл╗");
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 1.0f * Time.deltaTime);
        }
    }
}
