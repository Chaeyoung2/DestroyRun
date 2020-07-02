using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSubscriber : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button loadButton;
    [SerializeField] private Button endButton;
    [SerializeField] private Toggle particleToggle;
    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();
        loadButton = GetComponent<Button>();
        endButton = GetComponent<Button>();
        particleToggle = GetComponent<Toggle>();

        // 스타트 버튼이 클릭되었을 때 유니티 메서드 호출
        startButton.onClick.AddListener(OnClickedStart);

        particleToggle.onValueChanged.AddListener(OnCheckedPToggle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    private void OnClickedStart()
    {
        // loadScene();
    }

    private void OnCheckedPToggle(bool value)
    {
        if (value)
        {

        }
        else
        {

        }
    }

}
