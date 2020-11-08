using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8;
    [SerializeField] private Rigidbody2D _rigidbody2D = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.position = new Vector3(
            transform.position.x + (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime),
            transform.position.y + (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime),
            0f
            );*/
        _rigidbody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * moveSpeed;
    }
}
