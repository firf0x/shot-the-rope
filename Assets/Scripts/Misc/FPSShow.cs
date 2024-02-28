using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSShow : MonoBehaviour
{
    public Text text;
    private float deltaTime = 0.0f;
    private int frames = 0;
    private float fps = 0.0f;
    private void Start()
    {
        deltaTime = 0.0f;
        frames = 0;
        fps = 0.0f;
    }
    private void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        ++frames;

        if (Time.frameCount % 60 == 0)
        {
            fps = (frames / deltaTime);
            frames = 0;
            deltaTime = 0.0f;
            text.text = $"FPS: {fps}";
        }
    }
}
