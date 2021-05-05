using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereArea : MonoBehaviour
{
    public enum DetectorType {Sphere, Torus, Cone};
    public DetectorType detectorType;
    Renderer rTorus, rSphere, rCone;
    public Material red, transparent, green;
    public AudioSource myAudioSource;
    public AudioClip coneSoundYes, coneSoundNo, torusSoundYes, torusSoundNo, sphereSoundYes, sphereSoundNo;
    Rigidbody rigidBody;




    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        // The Dtetection of objects entering the Torus Area
        if (other.tag == "torus" && detectorType == DetectorType.Torus)
        {
            rTorus.material = green;
            myAudioSource.Play();
            if (torusSoundYes != null)
            {
                OVRHapticsClip ovrClip = new OVRHapticsClip(torusSoundYes);
                OVRHaptics.RightChannel.Preempt(ovrClip);
                OVRHaptics.LeftChannel.Preempt(ovrClip);
            }
            //At this point the clip has played and when the item is released, it should lock into position
            //Require assistance (
            rigidBody.constraints = RigidbodyConstraints.FreezeAll;
        }
        else if (other.tag == "cone" && detectorType == DetectorType.Torus)
        {
            rTorus.material = red;
            myAudioSource.Play();
            if (torusSoundNo != null)
            {
                OVRHapticsClip ovrClip = new OVRHapticsClip(torusSoundNo);
                OVRHaptics.RightChannel.Preempt(ovrClip);
                OVRHaptics.LeftChannel.Preempt(ovrClip);
            }
        }
        else if (other.tag == "sphere" && detectorType == DetectorType.Torus)
        {
            rTorus.material = red;
            myAudioSource.Play();
            if (torusSoundNo != null)
            {
                OVRHapticsClip ovrClip = new OVRHapticsClip(torusSoundNo);
                OVRHaptics.RightChannel.Preempt(ovrClip);
                OVRHaptics.LeftChannel.Preempt(ovrClip);
            }
        }

        // The Detection for objects entering the Shpere Area
        if (other.tag == "torus" && detectorType == DetectorType.Sphere)
        {
            rTorus.material = red;
            myAudioSource.Play();
            if (sphereSoundNo != null)
            {
                OVRHapticsClip ovrClip = new OVRHapticsClip(sphereSoundNo);
                OVRHaptics.RightChannel.Preempt(ovrClip);
                OVRHaptics.LeftChannel.Preempt(ovrClip);
            }

        }
        else if (other.tag == "cone" && detectorType == DetectorType.Sphere)
        {
            rTorus.material = red;
            myAudioSource.Play();
            if (sphereSoundNo != null)
            {
                OVRHapticsClip ovrClip = new OVRHapticsClip(sphereSoundNo);
                OVRHaptics.RightChannel.Preempt(ovrClip);
                OVRHaptics.LeftChannel.Preempt(ovrClip);
            }
        }
        else if (other.tag == "sphere" && detectorType == DetectorType.Sphere)
        {
            rTorus.material = green;
            myAudioSource.Play();
            if (sphereSoundYes != null)
            {
                OVRHapticsClip ovrClip = new OVRHapticsClip(sphereSoundYes);
                OVRHaptics.RightChannel.Preempt(ovrClip);
                OVRHaptics.LeftChannel.Preempt(ovrClip);
                rigidBody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
        
        // The Detection of objects in the Cone Areaw
        if (other.tag == "torus" && detectorType == DetectorType.Cone)
        {
            rTorus.material = red;
            myAudioSource.Play();
            if (coneSoundNo != null)
            {
                OVRHapticsClip ovrClip = new OVRHapticsClip(coneSoundNo);
                OVRHaptics.RightChannel.Preempt(ovrClip);
                OVRHaptics.LeftChannel.Preempt(ovrClip);
            }
 

        }
        else if (other.tag == "cone" && detectorType == DetectorType.Cone)
        {
            rTorus.material = green;
            myAudioSource.Play();
            if (coneSoundYes != null)
            {
                OVRHapticsClip ovrClip = new OVRHapticsClip(coneSoundYes);
                OVRHaptics.RightChannel.Preempt(ovrClip);
                OVRHaptics.LeftChannel.Preempt(ovrClip);
                rigidBody.constraints = RigidbodyConstraints.FreezeAll;
            }
 
        }
        else if (other.tag == "sphere" && detectorType == DetectorType.Cone)
        {
            rTorus.material = red;
            myAudioSource.Play();
            if (coneSoundNo != null)
            {
                OVRHapticsClip ovrClip = new OVRHapticsClip(coneSoundNo);
                OVRHaptics.RightChannel.Preempt(ovrClip);
                OVRHaptics.LeftChannel.Preempt(ovrClip);
            }

        }
    }











}
