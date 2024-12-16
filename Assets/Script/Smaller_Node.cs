using UnityEngine;

public class SmallerNode : MonoBehaviour
{
    public Vector3 initialScale = new Vector3(7f, 7f, 1f); // 초기 스케일
    public Vector3 targetScale = new Vector3(1f, 1f, 1f); // 목표 스케일
    public float shrinkSpeed;// 축소 속도

    public float start_scale;
    public float end_scale;

    void Start()
    {
        // 초기 스케일 설정
        transform.localScale = initialScale;
    }

    void Update()
    {
        // 스케일을 점점 줄임
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, shrinkSpeed * Time.deltaTime);

        // 목표 스케일에 도달하면 오브젝트 삭제
        if (transform.localScale.x <= 1f)
        {
            Destroy(gameObject);
        }

        // 스케일이 1.3 ~ 1.7일 때 스페이스 키를 누르면 성공 출력
        if (transform.localScale.x >= start_scale && transform.localScale.x <= end_scale &&
            transform.localScale.y >= start_scale && transform.localScale.y <= end_scale)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("성공");
                Destroy(gameObject);
            }
        }
    }
}