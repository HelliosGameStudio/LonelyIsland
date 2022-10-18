using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof (BoxCollider2D))]
public class BasicMovement : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystick;


    public static float speed = 1;
    private Rigidbody2D rb;


    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //убрать плавность GetAxisRaw
        //Управление с клавиш WASD *не работает в симуляции телефона*
        //rb.velocity = new Vector2(speed * Input.GetAxis("Horizontal"), speed * Input.GetAxis("Vertical"));

        //Управление с 2D джостика
        rb.velocity = new Vector2(speed * _joystick.Horizontal, speed * _joystick.Vertical);

        //Управление с Xbox *не работает в симуляции телефона*
        //rb.velocity = new Vector2(speed * Input.GetAxis("MoveXboxHorizontal"), speed * Input.GetAxis("MoveXboxVertical"));

    }
}
