using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Node : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 1f; //�������� �ӵ�
    public float destroyHeight = -6f;
    public float top;
    public float bottom;    

    void Update()
    {
        //�Ʒ��� ������
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        // ȭ�� �Ʒ��� ������� ��� ����
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
