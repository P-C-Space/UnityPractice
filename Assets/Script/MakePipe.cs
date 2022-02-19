using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;

    public float timeDiff;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {   
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // timer count
        if (timer >= timeDiff) // timer�� �Է��� �ð�(timeDiff)�� ������ 
        {
            GameObject newpipe =Instantiate(Pipe); // ������ ���� 
            newpipe.transform.position = new Vector3(5.0f, Random.Range(-2.45f,3f), 0);
            timer = 0; // �ٽ� �ʱ�ȭ
            Destroy(newpipe, 7.0f); // 5�ʵ� ���� 
        }
    }
}
