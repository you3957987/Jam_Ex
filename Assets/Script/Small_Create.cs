using UnityEngine;
using System.Collections;

public class Small_NodeManager : MonoBehaviour
{
    public GameObject smallerNodePrefab; // ���� ��� ������
    public float[] spawnTimes; // ���� �ֱ� �迭
    public Vector3 spawnPosition = Vector3.zero; // ���� ��ġ, �⺻���� (0, 0, 0)

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
        // ������ ��ġ�� ���� ��� ����
        Instantiate(smallerNodePrefab, spawnPosition, Quaternion.identity);
    }
}
