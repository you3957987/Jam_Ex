using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Node : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 1f; //떨어지는 속도
    public float destroyHeight = -6f;
    public float top;
    public float bottom;    

    void Update()
    {
        //아래로 떨어짐
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // 화면 아래로 사라지면 노드 제거
        if (transform.position.y < destroyHeight)
        {
            Destroy(gameObject);
        }

        if(transform.position.y >= bottom && transform.position.y <=  top)
        {
            if( Input.GetKeyDown(KeyCode.Q))
            {
                Destroy(gameObject);
                Debug.Log("a");
            }
           
        }

    }

}
