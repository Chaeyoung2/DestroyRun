using UnityEngine;

// 게임 점수를 증가시키는 아이템
public class Coin : MonoBehaviour, IItem {
    public int score = 1; // 증가할 점수

    public void Use(GameObject target) {
        // 게임 매니저로 접근해 점수 추가
        GameManager.instance.AddScore(score);
        // 모든 클라이언트에서의 자신을 파괴
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("OnTriggerEnter 진입");
        if (other.CompareTag("Player"))
        {
            // 게임 매니저로 접근해 점수 추가
            GameManager.instance.AddScore(score);
            // 모든 클라이언트에서의 자신을 파괴

            gameObject.SetActive(false);
        }
    }
}