using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldValueReader : MonoBehaviour
{
    
    private InputField _inputField;
    // Start is called before the first frame update
    void Start()
    {
        _inputField = GetComponent<InputField>();
        _inputField.onValueChanged.AddListener(OnValueChanged);
        _inputField.onEndEdit.AddListener(OnEndEdit);
    }

    void OnValueChanged(string value)
    {
        // id에 value값 세팅
    }

    void OnEndEdit(string value)
    {
        // 최종 입력 값 : value
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
