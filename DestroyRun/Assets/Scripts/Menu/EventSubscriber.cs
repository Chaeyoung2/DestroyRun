using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSubscriber : MonoBehaviour
{
    [SerializeField] private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        // 클릭되었을 때 유니티 메서드 호출
        button.onClick.AddListener( ()=> { // lambda
            // loadScene();
        }); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
