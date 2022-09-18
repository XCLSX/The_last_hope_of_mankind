using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_joyStick : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform _center;
    private SpriteRenderer _sr;
    private SpriteRenderer _cnetersr;
    private bool _work;

    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _center = transform.GetChild(0);
        _cnetersr = _center.GetComponent<SpriteRenderer>();
        stop();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void work()
    {
        _work = true;
        _sr.enabled = true;
        _cnetersr.enabled = true;
    }

    public void stop()
    {
        _work = false;
        _sr.enabled = false;
        _cnetersr.enabled = false;
    }

    public void setTwards(Vector2 pos)
    {
        if (_work)
        {

        }
    }
}
