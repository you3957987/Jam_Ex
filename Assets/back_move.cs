using UnityEngine;

public class back_move : MonoBehaviour
{
    public CircleMove circlemove;
    public float moveSpeed = 1.4f; // �̵� �ӵ�

    public float cooltime;
    float nextmove = 0f;
    public float randommove = 0f;
    public float start_move;
    public float end_move;

    private void Start()
    {
        if (circlemove == null)
        {
            circlemove = GetComponent<CircleMove>();
        } 
    }

    private void Update()
    {
        if (circlemove != null)
        {
            float newXPosition = transform.position.x + randommove +  (-circlemove.move * moveSpeed * Time.deltaTime);
            Vector3 newPosition = new Vector3(newXPosition, transform.position.y, transform.position.z);

            // ������Ʈ ��ġ ������Ʈ
            transform.position = newPosition;
        }

        if (transform.position.x <= -4f || transform.position.x >= 4f)
        {
            //Debug.Log("��");
        }

        if( Time.time >= nextmove)
        {
            SetRandom();
            nextmove = Time.time + cooltime;
        }
    }
    private void SetRandom()
    {
        randommove = Random.Range(start_move, end_move);
    }
}
