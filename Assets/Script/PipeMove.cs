using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * Speed;
        //Time.deltaTime ==> 1 / �� ���ɿ� �´� ������ ��
    }
}
