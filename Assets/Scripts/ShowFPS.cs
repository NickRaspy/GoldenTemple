using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFPS : MonoBehaviour
{
    [SerializeField] Text fpsText;
    [SerializeField] float refreshRateEverySec = 1f;
    private float deltaTime;
    float fps = 0;

    private void Start()
    {
        StartCoroutine(Tick());
    }

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        fps = 1.0f / deltaTime;
    }

    IEnumerator Tick()
    {
        while(true)
        {
            fpsText.text = Mathf.Ceil(fps).ToString();
            yield return new WaitForSeconds(refreshRateEverySec);
        }
    }
}
