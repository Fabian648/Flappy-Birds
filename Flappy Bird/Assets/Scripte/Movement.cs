using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 10f;
    private float max_height = 2f;
    private float min_height = -2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0f);

        float offset = Random.Range(min_height, max_height);
        transform.position = new Vector2(transform.position.x, transform.position.y + offset);

        Destroy(gameObject, 10);
    }
}
