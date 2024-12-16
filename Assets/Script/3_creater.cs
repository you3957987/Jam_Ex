using UnityEngine;
using System.Collections;
public class Third_creater : MonoBehaviour
{
    public GameObject circle_node_prefab; // 스몰 노드 프리팹
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
        // (-12, 20) 위치에 스몰 노드 생성
        Instantiate(circle_node_prefab, new Vector3(7, 20, 0), Quaternion.identity);
    }
}
