using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8;
    [SerializeField] private SpriteRenderer _spriteRenderer = null;
    [SerializeField] private Sprite[] playerDirectionSprite = new Sprite[0];
    [SerializeField] private Animator weaponAnim = null;
    private Rigidbody2D _rigidbody2D = null;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * moveSpeed;
        _animator.SetFloat("Speed", _rigidbody2D.velocity.magnitude);
        if (_rigidbody2D.velocity != Vector2.zero)
        {
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                _spriteRenderer.sprite = playerDirectionSprite[1];
                if (Input.GetAxisRaw("Horizontal") < 0)
                {
                    _spriteRenderer.flipX = true;
                }
                else
                {
                    _spriteRenderer.flipX = false;
                }
            }
            else
            {
                if (Input.GetAxisRaw("Vertical") < 0)
                {
                    _spriteRenderer.sprite = playerDirectionSprite[0];
                }
                else
                {
                    _spriteRenderer.sprite = playerDirectionSprite[2];
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Attack");
            weaponAnim.SetTrigger("Attack");
        }
    }
}
