using System.Collections.Generic;
using UnityEngine;

public enum SoundType {
    SHOOT,
    PROJECTILE,
    LASER,
    SWAP,
    DEATH,
    EYEATTACK,
    DAMAGETAKEN,
    DAMAGEDEALT,
    IMPACT,
    BOSSIMPACT,
    FLAPPING,
    ENEMY,
    LASERBULLET,

}

public class SoundCollection {
    private AudioClip[] clips;
    private int lastClipIndex;

    public SoundCollection(params string[] clipNames) {
        this.clips = new AudioClip[clipNames.Length];
        for (int i = 0; i < clips.Length; i++) {
            clips[i] = Resources.Load<AudioClip>(clipNames[i]);
            if (clips[i] == null) {
                Debug.Log($"can't find audio clip {clipNames[i]}");
            }
        }
        lastClipIndex = -1;
    }

    public AudioClip GetRandClip() {
        if (clips.Length == 0) {
            Debug.Log("No clips to give");
            return null;
        }
        else if (clips.Length == 1) {
            return clips[0];
        }
        else {
            int index = lastClipIndex;
            while (index == lastClipIndex) {
                index = Random.Range(0, clips.Length);
            }
            lastClipIndex = index;
            return clips[index];
        }
    }

}

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour {
    public float mainVolume = 1.0f;
    private Dictionary<SoundType, SoundCollection> sounds;
    private AudioSource audioSrc;

    public static SoundManager Instance { get; private set; }

    // unity life cycle
    private void Awake() {
        Instance = this;
        audioSrc = GetComponent<AudioSource>();
        sounds = new() {
            { SoundType.SHOOT, new(new string[] {"Fire_(1), Fire_(2), Fire_(3), Fire_(4), Fire_(5), Fire_(6)"}) },
            { SoundType.PROJECTILE, new(new string[] {"Projectile_(1), Projectile_(2), Projectile_(3), Projectile_(4), Projectile_(5)"}) },
            { SoundType.LASER, new(new string[] {"Laser"}) },
            { SoundType.SWAP, new(new string[] {"DimensionSwap"}) },
            { SoundType.DEATH, new(new string[] {"PhysicalEnemyImpact"}) },
            { SoundType.DAMAGETAKEN, new(new string[] {"BeenHit"}) },
            { SoundType.DAMAGEDEALT, new(new string[] {"Hit"}) },
            { SoundType.IMPACT, new(new string[] {"Impact"}) },
            { SoundType.BOSSIMPACT, new(new string[] {"Explosion"}) },
            { SoundType.FLAPPING, new(new string[] {"WingsFlapping"}) },
            { SoundType.ENEMY, new(new string[] {"CreatureSound, AnotherCreatureSound"}) },
            { SoundType.LASERBULLET, new(new string[] {"LaserBullet"}) },
        };
    }

    public static void Play(SoundType type, AudioSource audioSrc = null, float pitch = -1) {
        print("playing sound");
        if (Instance.sounds.ContainsKey(type)) {
            audioSrc ??= Instance.audioSrc;
            audioSrc.volume = Random.Range(0.70f, 1.0f) * Instance.mainVolume;
            audioSrc.pitch = pitch >= 0 ? pitch : Random.Range(0.75f, 1.25f);
            audioSrc.clip = Instance.sounds[type].GetRandClip();
            audioSrc.Play();
        }
    }
}