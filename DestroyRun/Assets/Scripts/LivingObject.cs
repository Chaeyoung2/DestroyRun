using System;
using System.Collections.Generic;
using UnityEngine;

// 생명체로서 동작할 게임 오브젝트들을 위한 뼈대를 제공
// 체력, 데미지 받아들이기, 사망 기능, 사망 이벤트를 제공

enum enemy_state { state_idle, state_run, state_damaged, state_attack, state_dead }


public class LivingObject : MonoBehaviour
{
    public float startingHealth = 100f; // 시작 체력
    public float health { get; protected set; } // 현재 체력
    public bool dead { get; protected set; } // 사망 상태
    //public event Action onDeath; // 사망시 발동할 이벤트

    private void Start()
    {
      
    }

    private void Update()
    {
        dead = false;
    }

    private void LateUpdate()
    {
        
    }
}