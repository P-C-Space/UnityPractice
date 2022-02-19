using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // 트리거 진입시 이벤트
    {
        Score.score+=10;
    }
}
