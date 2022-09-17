using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private bool activeXboxContr;


    public GameObject joysticForMobile;
    void Start()
    {
        
    }

    void Update()
    {
        //���������� � ������ WASD *�� �������� � ��������� ��������*
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        //transform.position = transform.position + movement * Time.deltaTime;

        //���������� � 2D ��������
        //Vector3 movement = new Vector3(_joystick.Horizontal, _joystick.Vertical, 0.0f);
        //transform.position = transform.position + movement * Time.deltaTime;

        //���������� � Xbox *�� �������� � ��������� ��������*
        Vector3 movement = new Vector3(Input.GetAxis("MoveXboxHorizontal"), Input.GetAxis("MoveXboxVertical"), 0.0f);
        transform.position = transform.position + movement * Time.deltaTime;

        if (movement.x > 0 || movement.y > 0) // �������� � ���� � Xbox
            joysticForMobile.SetActive(false);
    }
}
