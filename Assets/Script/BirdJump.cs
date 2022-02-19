using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start() // ó�� �ѹ��� ����
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() // �������Ӹ��� ����
    {
        if(Input.GetMouseButton(0))
        {
            GetComponent<AudioSource>().Play(); // audio play
            rb.velocity = Vector2.up*5;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // collision �浹�Ͽ����� �߻�
    {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene"); // scene�̵�
    }
}
