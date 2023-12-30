using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodexDispenserTest : MonoBehaviour
{

    [SerializeField] GameObject probe;

    [Header("Component References")]
    [Tooltip("The outwards particle system to activate")]
    [SerializeField] ParticleSystem outwardParticles;
    [Tooltip("The inwards particle system to control")]
    [SerializeField] ParticleSystem inwardParticles;
    [Tooltip("The audio source to use")]
    [SerializeField] AudioSource audioSource;

    [Header("Timing Values")]
    [Tooltip("Total duration of the animation")]
    [SerializeField] float totalDuration;
    [Tooltip("How long it takes the probe to sink into the dispenser")]
    [SerializeField] float sinkDuration;
    [Tooltip("How fast the probe rotates once it's inside the dispenser")]
    [SerializeField] float probeMaxRotationSpeed;
    [Tooltip("The curve used to update the probe's rotation speed")]
    [SerializeField] AnimationCurve probeRotationSpeedCurve;
    [Tooltip("The time when the particle burst occurs")]
    [SerializeField] float particleBurstTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == probe)
        {
            //Disable ability to recall probe here

            StartCoroutine(nameof(DispenseCodexAnimation));
        }
    }

    IEnumerator DispenseCodexAnimation()
    {
        float startTime = Time.time;

        yield return new WaitForEndOfFrame(); //Make sure probe has made itself a child of this object

        //Start rotating the probe
        StartCoroutine(nameof(RotateProbe));

        //Start audio and particles
        audioSource.Play();
        outwardParticles.Play();

        //Probe sinks into dispenser
        float sinkStartTime = Time.time;
        Vector3 probeStartPosition = probe.transform.localPosition;
        while (Time.time - sinkStartTime < sinkDuration)
        {
            float t = (Time.time - sinkStartTime) / sinkDuration;
            probe.transform.localPosition = Vector3.Lerp(probeStartPosition, Vector3.zero, t);

            yield return new WaitForEndOfFrame();
        }

        //Wait for particle burst time
        yield return new WaitForSeconds(particleBurstTime - (Time.time - startTime));

        //Enable inward particles' orbital velocity
        Debug.Log("Changing particles orbital velocity");
        ParticleSystem.VelocityOverLifetimeModule inwardVelocityOverLifetimeModule = inwardParticles.velocityOverLifetime;
        inwardVelocityOverLifetimeModule.speedModifierMultiplier = 1f;

        yield return null;
    }

    IEnumerator RotateProbe()
    {
        float startTime = Time.time;

        while (Time.time - startTime < totalDuration)
        {
            float rotationSpeed = probeRotationSpeedCurve.Evaluate((Time.time - startTime) / totalDuration) * probeMaxRotationSpeed;
            probe.transform.Rotate(transform.up, rotationSpeed * Time.deltaTime);

            yield return new WaitForEndOfFrame();
        }
    }
}
