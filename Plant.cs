using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public SpriteOutline outline;
    public bool move = false;
    public float startTime;

    private void OnEnable()
    {
        EventManager.onClickPlant += Move;
    }

    private void OnDisable()
    {
        EventManager.onClickPlant -= Move;
    }

    void Start()
    {
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
    }

    private void Update()
    {
        if (Time.time - startTime > 1.2f)
        {
            move = false;
        }

        if(move)
        {
            transform.Translate(Vector2.left * 2.0f * Time.deltaTime);
        }

    }

    private void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            EventManager.MovePlant();
            gameObject.layer = 2;
        }
        outline.OutlineColor = Color.white;

    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }

    private void Move()
    {
        startTime = Time.time;
        move = true;
    }
}
