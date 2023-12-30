using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodexDispenserParticleAudioSync : MonoBehaviour
{

    [Tooltip("The audio source to pull data from")]
    [SerializeField] AudioSource audioSource;
    [Tooltip("The update step for audio data")]
    [SerializeField] float updateStep = 0.1f;
    [Tooltip("The length of the sample data to pull")]
    [SerializeField] int sampleDataLength = 1024;

    [SerializeField] TextMeshPro output;

    float currentUpdateTime = 0f;
    float[] clipSampleData;
    float clipLoudness;

    private void Start()
    {
        clipSampleData = new float[sampleDataLength];
    }

    private void Update()
    {
        currentUpdateTime += Time.deltaTime;
        if (currentUpdateTime >= updateStep)
        {
            currentUpdateTime = 0f;
            audioSource.clip.GetData(clipSampleData, audioSource.timeSamples);
            clipLoudness = 0f;
            foreach (var sample in clipSampleData)
            {
                clipLoudness += Mathf.Abs(sample);
            }
            clipLoudness /= sampleDataLength;

            output.text = clipLoudness.ToString();
        }
    }
}
