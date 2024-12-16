using UnityEngine;
using System.Collections;

public class Second_Creater : MonoBehaviour
{
    public GameObject circle_node_prefab; // ���� ��� ������
    public float[] spawnTimes; // ���� �ֱ� �迭
    public float top;
    public float x;

    void Start()
    {
        // �ڷ�ƾ ����
        StartCoroutine(SpawnNodes());
    }

    IEnumerator SpawnNodes()
    {
        foreach (float spawnTime in spawnTimes)
        {
            yield return new WaitForSeconds(spawnTime);
            SpawnSmallerNode();
        }
    }

    void SpawnSmallerNode()
    {
        // (-12, 20) ��ġ�� ���� ��� ����
        Instantiate(circle_node_prefab, new Vector3(x, top, 0), Quaternion.identity);
    }
}
