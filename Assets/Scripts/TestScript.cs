using UnityEngine;

public class TestScript : MonoBehaviour
{
    [Header("Test Settings")]
    public string testMessage = "Hello World!";
    public float testValue = 1.0f;
    public bool isTestEnabled = true;
    
    void Start()
    {
        Debug.Log("TestScript started!");
        if (isTestEnabled)
        {
            Debug.Log(testMessage);
        }
    }
    
    void Update()
    {
        // 테스트용 업데이트 로직
        if (Input.GetKeyDown(KeyCode.T))
        {
            TestFunction();
        }
    }
    
    public void TestFunction()
    {
        Debug.Log($"Test function called! Value: {testValue}");
    }
}