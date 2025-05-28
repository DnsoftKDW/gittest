using UnityEngine;

public class CubeColorChanger : MonoBehaviour
{
    [Header("Color Settings")]
    public Color cubeColor = Color.blue;
    
    private Renderer cubeRenderer;
    private MaterialPropertyBlock propertyBlock;
    
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        propertyBlock = new MaterialPropertyBlock();
        
        // 초기 색상 적용
        UpdateColor();
    }
    
    void Update()
    {
        // 색상이 변경되었는지 확인하고 업데이트
        UpdateColor();
        
        // 키보드 입력으로 색상 변경 테스트
        if (Input.GetKeyDown(KeyCode.R))
            SetColor(Color.red);
        else if (Input.GetKeyDown(KeyCode.G))
            SetColor(Color.green);
        else if (Input.GetKeyDown(KeyCode.B))
            SetColor(Color.blue);
        else if (Input.GetKeyDown(KeyCode.Y))
            SetColor(Color.yellow);
        else if (Input.GetKeyDown(KeyCode.Space))
            SetRandomColor();
    }
    
    public void UpdateColor()
    {
        if (cubeRenderer != null)
        {
            propertyBlock.SetColor("_Color", cubeColor);
            cubeRenderer.SetPropertyBlock(propertyBlock);
        }
    }
    
    public void SetColor(Color newColor)
    {
        cubeColor = newColor;
        UpdateColor();
    }
    
    public void SetRandomColor()
    {
        cubeColor = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            1f
        );
        UpdateColor();
        Debug.Log($"Random color set: {cubeColor}");
    }
}