using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
    public float speedX;
    public int directionX;
    public float speedY;
    public int directionY;
    // Start is called before the first frame update
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
        speedX = 2;
        directionX = 1;
        speedY = 2;
        directionY = 1;
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + speedX * directionX * Time.deltaTime, _compTransform.position.y + speedY * directionY * Time.deltaTime);
        if (_compTransform.position.x > 3.75f)
        {
            directionX = -1;
            _compSpriteRenderer.flipX = true;
        }
        if (_compTransform.position.x < -3.75f)
        {
            directionX = 1;
            _compSpriteRenderer.flipX = false;
        }
        if (_compTransform.position.y > 2.95f)
        {
            directionY = -1;
            _compSpriteRenderer.flipY = true;
        }
        if (_compTransform.position.y < -2.95f)
        {
            directionY = 1;
            _compSpriteRenderer.flipY = false;
        }
    }
}
