using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 50f; // 앞뒤 움직임의 속도
    public float rotateSpeed = 180f; // 좌우 회전 속도

    [SerializeField] private Animator playerAnimator; // 플레이어 캐릭터의 애니메이터
    [SerializeField] private PlayerInput playerInput; // 플레이어 입력을 알려주는 컴포넌트
    [SerializeField] private Rigidbody playerRigidbody; // 플레이어 캐릭터의 리지드바디

    // Start is called before the first frame update
    void Start()
    {
        // 사용할 컴포넌트들의 참조를 가져오기
        playerRigidbody = GetComponent<Rigidbody>();
        //playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // 회전 실행
        Rotate();
        // 움직임 실행
        Move();

    }

    // 입력값에 따라 캐릭터를 앞뒤로 움직임 -> 계속 움직이는 걸로 수정
    private void Move()
    {
        //// 상대적으로 이동할 거리 계산
        //Vector3 moveDistance =
        //    playerInput.move * transform.forward * moveSpeed * Time.deltaTime;
        //// 리지드바디를 통해 게임 오브젝트 위치 변경
        //playerRigidbody.MovePosition(playerRigidbody.position + moveDistance);

        // -> 수정
        playerRigidbody.velocity = Vector3.forward * moveSpeed * Time.deltaTime;
        //print(Vector3.forward);
    }

    // 입력값에 따라 캐릭터를 좌우로 회전
    private void Rotate()
    {

    }
}
