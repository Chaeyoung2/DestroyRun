using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float moveSpeed; // 앞뒤 움직임의 속도
   [SerializeField] private float jumpPower;

    [SerializeField] private PlayerInput playerInput; // 플레이어 입력을 알려주는 컴포넌트
    [SerializeField] private Rigidbody playerRigidbody; // 플레이어 캐릭터의 리지드바디
    public SpawnManager spawnManager;

    public bool jump = false;
    public bool run = false;
    public bool dash = false;

    // Start is called before the first frame update
    void Start()
    {
        // 사용할 컴포넌트들의 참조를 가져오기
        playerRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        //playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // 움직임 실행
        Move();
        // 점프
        Jump();
        // 대시
        Dash();

    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnerTriggerEntered();
    }

    // 입력값에 따라 캐릭터를 앞뒤로 움직임 -> 계속 움직이는 걸로 수정
    private void Move()
    {
        // 대시
        if (dash)
        {
            moveSpeed *= 2f;
        }

        //상대적으로 이동할 거리 계산
        Vector3 moveDistance =
            playerInput.move * transform.forward * moveSpeed * Time.deltaTime;
        // 리지드바디를 통해 게임 오브젝트 위치 변경
        playerRigidbody.MovePosition(playerRigidbody.position + moveDistance);
        

        // -> 수정 -> 다시 폐기
        //playerRigidbody.velocity = Vector3.forward * moveSpeed * Time.deltaTime;
        //print(Vector3.forward);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            jump = true;
        }
    }

    void Dash()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            dash = true;
        }
    }

}
