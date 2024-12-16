using UnityEngine;
using System.Collections;
public class Third_creater : MonoBehaviour
{
    public GameObject circle_node_prefab; // ���� ��� ������
    public float[] spawnTimes; // ���� �ֱ� �迭

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
        Instantiate(circle_node_prefab, new Vector3(7, 20, 0), Quaternion.identity);
    }
}