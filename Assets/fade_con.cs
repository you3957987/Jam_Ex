using UnityEngine;

public class fade_con : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float fadeDuration = 10.0f; // Duration of the fade in seconds
    private float elapsedTime = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Color color = spriteRenderer.color;
        color.a = 0.0f; // Set initial alpha to 0 (completely transparent)
        spriteRenderer.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Clamp01(elapsedTime / fadeDuration); // Calculate alpha value
            Color color = spriteRenderer.color;
            color.a = alpha; // Update alpha value
            spriteRenderer.color = color;
        }
    }
}
