using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "audioData_", menuName = "Data/Audio Data")]
public class AudioData : ScriptableObject
{
    // Map audio data words
    [SerializeField] private AudioClip[] b_ALWAYS;
    public AudioClip[] B_ALWAYS => b_ALWAYS;
    [SerializeField] private AudioClip[] b_AND;
    public AudioClip[] B_AND => b_AND;
    [SerializeField] private AudioClip[] b_anne;
    public AudioClip[] B_anne => b_anne;
    [SerializeField] private AudioClip[] b_are;
    public AudioClip[] B_are => b_are;
    [SerializeField] private AudioClip[] b_beware;
    public AudioClip[] B_beware => b_beware;
    [SerializeField] private AudioClip[] b_BIG;
    public AudioClip[] B_BIG => b_BIG;
    [SerializeField] private AudioClip[] b_Bork;
    public AudioClip[] B_Bork => b_Bork;
    [SerializeField] private AudioClip[] b_bridget;
    public AudioClip[] B_bridget => b_bridget;
    [SerializeField] private AudioClip[] b_brown;
    public AudioClip[] B_brown => b_brown;
    [SerializeField] private AudioClip[] b_curse;
    public AudioClip[] B_curse => b_curse;
    [SerializeField] private AudioClip[] b_CURSE;
    public AudioClip[] B_CURSE => b_CURSE;
    [SerializeField] private AudioClip[] b_EASY;
    public AudioClip[] B_EASY => b_EASY;
    [SerializeField] private AudioClip[] b_easy;
    public AudioClip[] B_easy => b_easy;
    [SerializeField] private AudioClip[] b_ENJOY;
    public AudioClip[] B_ENJOY => b_ENJOY;
    [SerializeField] private AudioClip[] b_FINE;
    public AudioClip[] B_FINE => b_FINE;
    [SerializeField] private AudioClip[] b_FOLLOW;
    public AudioClip[] B_FOLLOW => b_FOLLOW;
    [SerializeField] private AudioClip[] b_follow;
    public AudioClip[] B_follow => b_follow;
    [SerializeField] private AudioClip[] b_FOR;
    public AudioClip[] B_FOR => b_FOR;
    [SerializeField] private AudioClip[] b_for;
    public AudioClip[] B_for => b_for;
    [SerializeField] private AudioClip[] b_golden;
    public AudioClip[] B_golden => b_golden;
    [SerializeField] private AudioClip[] b_GOOD;
    public AudioClip[] B_GOOD => b_GOOD;
    [SerializeField] private AudioClip[] b_good;
    public AudioClip[] B_good => b_good;
    [SerializeField] private AudioClip[] b_GREEN;
    public AudioClip[] B_GREEN => b_GREEN;
    [SerializeField] private AudioClip[] b_HARD;
    public AudioClip[] B_HARD => b_HARD;
    [SerializeField] private AudioClip[] b_i;
    public AudioClip[] B_i => b_i;
    [SerializeField] private AudioClip[] b_I;
    public AudioClip[] B_I => b_I;
    [SerializeField] private AudioClip[] b_IS;
    public AudioClip[] B_IS => b_IS;
    [SerializeField] private AudioClip[] b_is;
    public AudioClip[] B_is => b_is;
    [SerializeField] private AudioClip[] b_LIKE;
    public AudioClip[] B_LIKE => b_LIKE;
    [SerializeField] private AudioClip[] b_loquacious;
    public AudioClip[] B_loquacious => b_loquacious;
    [SerializeField] private AudioClip[] b_LOVE;
    public AudioClip[] B_LOVE => b_LOVE;
    [SerializeField] private AudioClip[] b_love;
    public AudioClip[] B_love => b_love;
    [SerializeField] private AudioClip[] b_MAYBE;
    public AudioClip[] B_MAYBE => b_MAYBE;
    [SerializeField] private AudioClip[] b_MESSAGES;
    public AudioClip[] B_MESSAGES => b_MESSAGES;
    [SerializeField] private AudioClip[] b_my;
    public AudioClip[] B_my => b_my;
    [SerializeField] private AudioClip[] b_MYSELF;
    public AudioClip[] B_MYSELF => b_MYSELF;
    [SerializeField] private AudioClip[] b_nature;
    public AudioClip[] B_nature => b_nature;
    [SerializeField] private AudioClip[] b_NATURE;
    public AudioClip[] B_NATURE => b_NATURE;
    [SerializeField] private AudioClip[] b_NOPE;
    public AudioClip[] B_NOPE => b_NOPE;
    [SerializeField] private AudioClip[] b_NOT;
    public AudioClip[] B_NOT => b_NOT;
    [SerializeField] private AudioClip[] b_NOTHING;
    public AudioClip[] B_NOTHING => b_NOTHING;
    [SerializeField] private AudioClip[] b_PEACE;
    public AudioClip[] B_PEACE => b_PEACE;
    [SerializeField] private AudioClip[] b_PERSONAL;
    public AudioClip[] B_PERSONAL => b_PERSONAL;
    [SerializeField] private AudioClip[] b_pray;
    public AudioClip[] B_pray => b_pray;
    [SerializeField] private AudioClip[] b_quickly;
    public AudioClip[] B_quickly => b_quickly;
    [SerializeField] private AudioClip[] b_RED;
    public AudioClip[] B_RED => b_RED;
    [SerializeField] private AudioClip[] b_red;
    public AudioClip[] B_red => b_red;
    [SerializeField] private AudioClip[] b_safe;
    public AudioClip[] B_safe => b_safe;
    [SerializeField] private AudioClip[] b_secret;
    public AudioClip[] B_secret => b_secret;
    [SerializeField] private AudioClip[] b_SMALL;
    public AudioClip[] B_SMALL => b_SMALL;
    [SerializeField] private AudioClip[] b_SOMETIMES;
    public AudioClip[] B_SOMETIMES => b_SOMETIMES;
    [SerializeField] private AudioClip[] b_SORRY;
    public AudioClip[] B_SORRY => b_SORRY;
    [SerializeField] private AudioClip[] b_squirrels;
    public AudioClip[] B_squirrels => b_squirrels;
    [SerializeField] private AudioClip[] b_STARS;
    public AudioClip[] B_STARS => b_STARS;
    [SerializeField] private AudioClip[] b_TAP;
    public AudioClip[] B_TAP => b_TAP;
    [SerializeField] private AudioClip[] b_tap;
    public AudioClip[] B_tap => b_tap;
    [SerializeField] private AudioClip[] b_the;
    public AudioClip[] B_the => b_the;
    [SerializeField] private AudioClip[] b_THE;
    public AudioClip[] B_THE => b_THE;
    [SerializeField] private AudioClip[] b_THIS;
    public AudioClip[] B_THIS => b_THIS;
    [SerializeField] private AudioClip[] b_this;
    public AudioClip[] B_this => b_this;
    [SerializeField] private AudioClip[] b_TIME;
    public AudioClip[] B_TIME => b_TIME;
    [SerializeField] private AudioClip[] b_time;
    public AudioClip[] B_time => b_time;
    [SerializeField] private AudioClip[] b_too;
    public AudioClip[] B_too => b_too;
    [SerializeField] private AudioClip[] b_whisper;
    public AudioClip[] B_whisper => b_whisper;
    [SerializeField] private AudioClip[] b_WHISPERS;
    public AudioClip[] B_WHISPERS => b_WHISPERS;
    [SerializeField] private AudioClip[] b_WORLD;
    public AudioClip[] B_WORLD => b_WORLD;
    [SerializeField] private AudioClip[] b_YELLOW;
    public AudioClip[] B_YELLOW => b_YELLOW;
    [SerializeField] private AudioClip[] b_yellow;
    public AudioClip[] B_yellow => b_yellow;
    [SerializeField] private AudioClip[] b_you;
    public AudioClip[] B_you => b_you;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
