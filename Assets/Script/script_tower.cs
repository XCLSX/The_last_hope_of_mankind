using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_tower : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera _camera;
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
            var touchArr = Input.touches;
            foreach(var touch in touchArr)
            {
                if (!_fire &&touch.phase == TouchPhase.Began && 1 == 1)
                {
                    _firefingerId = touch.fingerId;
                    _fire = true;
                    _startPos = touch.position;
                    jsCtl.work(_startPos);
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
            if (!_fire && 1 == 1)
            {
                _fire = true;
                _startPos = startPos;
                jsCtl.work(_startPos);
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            stopFire();
            jsCtl.stop();
        }
        else if (_fire)
        {
            Vector2 mousePos = Input.mousePosition;
            fire(mousePos - _startPos);
        }
    }
    private void fire(Vector2 thPos)
    {
        Vector2 toward = thPos.normalized;
        jsCtl.setTwards(toward);
    }
    
    private void stopFire()
    {
        _firefingerId = -1;
        _fire = false;
    }
}
