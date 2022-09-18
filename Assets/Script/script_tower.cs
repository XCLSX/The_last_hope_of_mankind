using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_tower : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 _towards;
    private bool _fire;
    void Start()
    {
        _towards = new Vector2(0, 1);
        _fire = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void turnTowards()
    {
        if (Input.touchCount > 0)
        {
            var touchArr = Input.touches;
            foreach(var touch in touchArr)
            {
                if (!_fire && 1 == 1)
                {
                    _fire = true
                }
            }
        }
    }
}
