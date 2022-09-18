using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_tower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform joyStick;
    private script_joyStick jsCtl;
    private Vector2 _towards;
    private bool _fire;
    private int _firefingerId;
    private Vector2 _startPos;
    void Start()
    {
        _towards = new Vector2(0, 1);
        _fire = false;
        _firefingerId = -1;
        jsCtl = joyStick.GetComponent<script_joyStick>();
    }

    // Update is called once per frame
    void Update()
    {
        //turnTowards();
        turnTowardsOnPc();

    }

    private void turnTowards()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log(Input.touchCount);
            var touchArr = Input.touches;
            foreach(var touch in touchArr)
            {
                if (!_fire &&touch.phase == TouchPhase.Began && 1 == 1)
                {
                    _firefingerId = touch.fingerId;
                    _fire = true;
                    _startPos = touch.position;
                    jsCtl.work();
                }
                if (!_fire && touch.fingerId == _firefingerId && touch.phase == TouchPhase.Moved)
                {
                    fire(touch.position);
                }
                else if (!_fire && touch.fingerId == _firefingerId && touch.phase == TouchPhase.Ended)
                {
                    stopFire();
                    jsCtl.stop();
                }
            }
        }
      
    }
    
    private void turnTowardsOnPc()
    {
        if (Input.GetMouseButtonDown(0) )
        {
            Vector2 startPos = Input.mousePosition;
            Debug.Log(startPos);
            if (!_fire && 1 == 1)
            {
               
                _fire = true;
                _startPos = startPos;
                jsCtl.work();
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            stopFire();
            jsCtl.stop();
        }
        else
        {
            Vector2 mousePos = Input.mousePosition;

            fire(mousePos - _startPos);
        }
    }
    private void fire(Vector2 thPos)
    {
        if (_fire)
        {
            jsCtl.setTwards(thPos);
        }
    }
    
    private void stopFire()
    {
        _firefingerId = -1;
        _fire = false;
    }
}
