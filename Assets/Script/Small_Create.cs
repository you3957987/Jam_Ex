using UnityEngine;
using System.Collections;

public class Small_NodeManager : MonoBehaviour
{
    public GameObject smallerNodePrefab; // ���� ��� ������
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
        // (0, 0) ��ġ�� ���� ��� ����
        Instantiate(smallerNodePrefab, Vector3.zero, Quaternion.identity);
    }
}
