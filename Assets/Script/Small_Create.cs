using UnityEngine;
using System.Collections;

public class Small_NodeManager : MonoBehaviour
{
    public GameObject smallerNodePrefab; // 스몰 노드 프리팹
    public float[] spawnTimes; // 생성 주기 배열

    void Start()
    {
        // 코루틴 시작
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
        // (0, 0) 위치에 스몰 노드 생성
        Instantiate(smallerNodePrefab, Vector3.zero, Quaternion.identity);
    }
}
