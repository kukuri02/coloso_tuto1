using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetCommponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ���� ����� ���ؼ� ����ϴ� ���� ȣ��
    private void FixedUpdate()
    {
        //�������� �Է��� �޾��ְڴ�.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //�������� �Է��� �޾��ְڴ�.
        float moveVertical = Input.GetAxis("Vertical");

        //�÷��̾ �̵���Ű�ڴ�.
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        //�÷��̾�� ���� ���ؼ� �̵���Ű�ڴ�.
        rb.AddForce(movement * speed);



    }
