using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script_joyStick : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform _center;
    private Image _img;
    private Image _cneterimg;
    private Vector2 _startPos;
    private bool _work;

    void Start()
    {
        _img = GetComponent<Image>();
        _center = transform.GetChild(0);
        _cneterimg = _center.GetComponent<Image>();
        stop();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void work(Vector2 startPos)
    {
        _startPos = startPos;
        transform.position = _startPos;
        _work = true;
        _img.enabled = true;
        _cneterimg.enabled = true;
    }

    public void stop()
    {
        _work = false;
        _img.enabled = false;
        _cneterimg.enabled = false;
    }

    public void setTwards(Vector2 pos)
    {
        if (_work)
        {
            _center.position = _startPos + pos * 40;
        }
    }
}
