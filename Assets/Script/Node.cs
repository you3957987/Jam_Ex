using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Node : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 1f; //�������� �ӵ�
    public float destroyHeight = -6f;


    void Update()
    {
        //�Ʒ��� ������
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // ȭ�� �Ʒ��� ������� ��� ����
        if (transform.position.y < destroyHeight)
        {
            Destroy(gameObject);
        }

        if(transform.position.y >= -1.7f && transform.position.y <= -0.6f)
        {
            if( Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(gameObject);
                Debug.Log("a");
            }
           
        }

    }

}
