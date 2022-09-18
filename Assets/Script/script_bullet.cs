using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _speed;
    private Vector2 _towards;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletMove();
    }

    private void bulletMove()
    {
        Vector3 td = new Vector3(_towards.x,_towards.y ,0);
        transform.position = transform.position + td * _speed * Time.deltaTime;
    }
    public void setTwards(Vector2 towards)
    {
        _towards = towards;
    }
}
