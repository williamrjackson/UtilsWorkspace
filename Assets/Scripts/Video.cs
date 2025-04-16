using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Wrj;
public class Video : MonoBehaviour
{
    [SerializeField]
    Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private IEnumerator Start()
    {
        float elapsed = 0f;
        ImageSequenceRecorder.StartRecording("test", 10);
        while (elapsed < 1f)
        {
            yield return new WaitForEndOfFrame();
            text.text = Time.frameCount.ToString();
            elapsed += Time.deltaTime;
        }
        ImageSequenceRecorder.StopRecording();
    }

}
