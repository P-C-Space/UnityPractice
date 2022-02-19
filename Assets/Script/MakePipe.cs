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
        if (timer >= timeDiff) // timer가 입력한 시간(timeDiff)이 지나면 
        {
            GameObject newpipe =Instantiate(Pipe); // 파이프 생성 
            newpipe.transform.position = new Vector3(5.0f, Random.Range(-2.45f,3f), 0);
            timer = 0; // 다시 초기화
            Destroy(newpipe, 7.0f); // 5초뒤 삭제 
        }
    }
}
