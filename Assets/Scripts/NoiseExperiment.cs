using System.Collections;
using Unity.Collections;
using UnityEngine;

public class NoiseExperiment : MonoBehaviour
{
    public float radius = 1f;
    public float movement = 1f;
    public float increment = 0.1f;
    IEnumerator Start()
    {
        float elapsed = 0f;
        while (true)
        {
            elapsed += Time.deltaTime * increment;
            if (elapsed > 1f)
            {
                elapsed = 0f;
                Debug.Log("Looped");
            }
            Vector2 noise = Wrj.Utils.LoopedNoiseV2(radius, elapsed);
            transform.localPosition = new Vector2(Mathf.Lerp(movement * -.5f, movement * .5f, noise.x), Mathf.Lerp(movement * -.5f, movement * .5f, noise.y));
            yield return new WaitForEndOfFrame();
        }
    }

    // public float LoopedNoise(float radius, float time, float offset = 0f)
    // {
    //     time = Mathf.Repeat(time, 1f);
    //     float noiseX = radius * Mathf.Cos(time * 2f * Mathf.PI);
    //     float noiseY = radius * Mathf.Sin(time * 2f * Mathf.PI);
    //     return Mathf.PerlinNoise(noiseX + offset, noiseY + offset);
    // }
    // public Vector2 LoopedNoiseV2(float radius, float time)
    // {
    //     time = Mathf.Repeat(time, 1f);
    //     float x = LoopedNoise(radius, time, 0f);
    //     float y = LoopedNoise(radius, time, radius * 2f);
    //     return new Vector2(x, y);
    // }
    // public Vector3 LoopedNoiseV3(float radius, float time)
    // {
    //     time = Mathf.Repeat(time, 1f);
    //     float x = LoopedNoise(radius, time, 0f);
    //     float y = LoopedNoise(radius, time, radius * 2f);
    //     float z = LoopedNoise(radius, time, radius * 4f);
    //     return new Vector3(x, y, z);
    // }
}
