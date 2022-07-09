using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        
        
        if (transform.position.x < this.deadLine)
        {
               Destroy (gameObject);
        }
        transform.Translate (this.speed * Time.deltaTime,0,0);
    }
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (gameObject.tag == "cube")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
