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

    // 물리 사용을 위해서 사용하는 지속 호출
    private void FixedUpdate()
    {
        //수평축의 입력을 받아주겠다.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //수직축의 입력을 받아주겠다.
        float moveVertical = Input.GetAxis("Vertical");

        //플레이어를 이동시키겠다.
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        //플레이어에게 힘을 가해서 이동시키겠다.
        rb.AddForce(movement * speed);



    }
