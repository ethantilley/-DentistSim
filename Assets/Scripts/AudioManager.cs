using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        else
            instance = this;
    }


    [System.Serializable]
    public class SFXData
    {
        public string sfxName;
        public AudioClip sfxClip;
        [Range(0,3)]
        public float volume = 0.1f;
        public float pitchRand = 0;
        public AudioSource deticatedSource;
    }

    public AudioSource sfxSource;

    public SFXData[] SFX;

    public void PlaySFX(string _name)
    {
        SFXData clip = SFX.Where(sfx => sfx.sfxName == _name).First();
        if(clip.deticatedSource && !clip.deticatedSource.isPlaying)
        {
            clip.deticatedSource.volume = clip.volume;
          //  clip.deticatedSource.pitch = Random.Range(-clip.pitchRand, clip.pitchRand);
            clip.deticatedSource.clip = clip.sfxClip;
            clip.deticatedSource.Play();
        }
        else if (!clip.deticatedSource)
        {
            sfxSource.volume = clip.volume;
           // sfxSource.pitch *= Random.Range(-clip.pitchRand, clip.pitchRand);
            sfxSource.PlayOneShot(clip.sfxClip);
                
        }
    }

    public void StopSFX(string _name)
    {
        SFXData clip = SFX.Where(sfx => sfx.sfxName == _name).First();
        if(clip.deticatedSource)
        {     
            clip.deticatedSource.Stop();
        }
       
    }
}
