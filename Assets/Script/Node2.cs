using UnityEngine;

public class Node2 : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 1f; //떨어지는 속도
    public float destroyHeight = -6f;


    void Update()
    {
        //아래로 떨어짐
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // 화면 아래로 사라지면 노드 제거
        if (transform.position.y < destroyHeight)
        {
            Destroy(gameObject);
        }

        if (transform.position.y >= -1.7f && transform.position.y <= -0.6f)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Destroy(gameObject);
                Debug.Log("a");
            }

        }

    }
}
