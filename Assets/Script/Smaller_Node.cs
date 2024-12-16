using UnityEngine;

public class SmallerNode : MonoBehaviour
{
    public Vector3 initialScale;
    public Vector3 targetScale;
    public float shrinkSpeed;// 축소 속도

    public float start_scale;
    public float end_scale;

    public AudioSource smallaudio;
    private SpriteRenderer spriteRenderer;

    private float creationTime;

    void Start()
    {
        // 초기 스케일 설정
        transform.localScale = initialScale;
        smallaudio = gameObject.GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        creationTime = Time.time; // 생성 시각 기록
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
                float elapsedTime = Time.time - creationTime;
                Debug.Log("Node 생존 시간: " + elapsedTime + "초");
                //Debug.Log("성공");
                smallaudio.Play();
                MakeTransparent();
                //Destroy(gameObject);
            }
        }
    }

    void MakeTransparent()
    {
        Color color = spriteRenderer.color;
        color.a = 0f; // 알파 값을 0으로 설정하여 완전히 투명하게 만듦
        spriteRenderer.color = color;
    }
}