using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/DoorSounds")]
public class DoorSounds : ScriptableObject
{
    [SerializeField] private AudioField[] audioField;

    public AudioClip GetAudioClipByType(AudioType audioType)
    {
        return audioField.First(x => x.audioType == audioType).audioClip;
    }
}

public enum AudioType
{
    OpenDoor, CloseDoor
}

[Serializable]
public class AudioField
{
    public AudioType audioType;
    public AudioClip audioClip;
}
