using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bork : MonoBehaviour
{
    // Map audio
    private AudioSource audioSource;

    // Create arrays for audio clips
    [SerializeField] private AudioData bork;

    // Variables for Bork functions
    private int borkNumber = 0;
    [SerializeField] private GameObject doggoWithHeadphones;

    // Start is called before the first frame update
    void Start()
    {
        // Map audio source
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Bork on button press
    public void BorkBork()
    {
        //Play a random bork sound
        borkNumber = Random.Range(0, bork.B_Bork.Length);
        audioSource.PlayOneShot(bork.B_Bork[borkNumber]);

        // Mark doggo as borked
        PlayerPrefs.SetInt("BorkCount", PlayerPrefs.GetInt("BorkCount") + 1);

        // Toggle headphones
        doggoWithHeadphones.SetActive(!doggoWithHeadphones.activeInHierarchy);
    }

    // Sing or whisper on button press
    public void BorkWord(string word)
    {

        // Map bork library - bork random sound

        if (word == "anne")
        {
            borkNumber = Random.Range(0, bork.B_anne.Length);
            audioSource.PlayOneShot(bork.B_anne[borkNumber]);
        }

        if (word == "beware")
        {
            borkNumber = Random.Range(0, bork.B_beware.Length);
            audioSource.PlayOneShot(bork.B_beware[borkNumber]);
        }

        if (word == "BIG")
        {
            borkNumber = Random.Range(0, bork.B_BIG.Length);
            audioSource.PlayOneShot(bork.B_BIG[borkNumber]);
        }

        if (word == "bridget")
        {
            borkNumber = Random.Range(0, bork.B_bridget.Length);
            audioSource.PlayOneShot(bork.B_bridget[borkNumber]);
        }

        if (word == "brown")
        {
            borkNumber = Random.Range(0, bork.B_brown.Length);
            audioSource.PlayOneShot(bork.B_brown[borkNumber]);
        }

        if (word == "EASY")
        {
            borkNumber = Random.Range(0, bork.B_EASY.Length);
            audioSource.PlayOneShot(bork.B_EASY[borkNumber]);
        }

        if (word == "easy")
        {
            borkNumber = Random.Range(0, bork.B_easy.Length);
            audioSource.PlayOneShot(bork.B_easy[borkNumber]);
        }

        if (word == "FOLLOW")
        {
            borkNumber = Random.Range(0, bork.B_FOLLOW.Length);
            audioSource.PlayOneShot(bork.B_FOLLOW[borkNumber]);
        }

        if (word == "follow")
        {
            borkNumber = Random.Range(0, bork.B_follow.Length);
            audioSource.PlayOneShot(bork.B_follow[borkNumber]);
        }

        if (word == "FOR")
        {
            borkNumber = Random.Range(0, bork.B_FOR.Length);
            audioSource.PlayOneShot(bork.B_FOR[borkNumber]);
        }

        if (word == "for")
        {
            borkNumber = Random.Range(0, bork.B_for.Length);
            audioSource.PlayOneShot(bork.B_for[borkNumber]);
        }

        if (word == "golden")
        {
            borkNumber = Random.Range(0, bork.B_golden.Length);
            audioSource.PlayOneShot(bork.B_golden[borkNumber]);
        }

        if (word == "GOOD")
        {
            borkNumber = Random.Range(0, bork.B_GOOD.Length);
            audioSource.PlayOneShot(bork.B_GOOD[borkNumber]);
        }

        if (word == "good")
        {
            borkNumber = Random.Range(0, bork.B_good.Length);
            audioSource.PlayOneShot(bork.B_good[borkNumber]);
        }

        if (word == "GREEN")
        {
            borkNumber = Random.Range(0, bork.B_GREEN.Length);
            audioSource.PlayOneShot(bork.B_GREEN[borkNumber]);
        }

        if (word == "HARD")
        {
            borkNumber = Random.Range(0, bork.B_HARD.Length);
            audioSource.PlayOneShot(bork.B_HARD[borkNumber]);
        }

        if (word == "i")
        {
            borkNumber = Random.Range(0, bork.B_i.Length);
            audioSource.PlayOneShot(bork.B_i[borkNumber]);
        }

        if (word == "IS")
        {
            borkNumber = Random.Range(0, bork.B_IS.Length);
            audioSource.PlayOneShot(bork.B_IS[borkNumber]);
        }

        if (word == "is")
        {
            borkNumber = Random.Range(0, bork.B_is.Length);
            audioSource.PlayOneShot(bork.B_is[borkNumber]);
        }

        if (word == "LIKE")
        {
            borkNumber = Random.Range(0, bork.B_LIKE.Length);
            audioSource.PlayOneShot(bork.B_LIKE[borkNumber]);
        }

        if (word == "LOVE")
        {
            borkNumber = Random.Range(0, bork.B_LOVE.Length);
            audioSource.PlayOneShot(bork.B_LOVE[borkNumber]);
        }

        if (word == "love")
        {
            borkNumber = Random.Range(0, bork.B_love.Length);
            audioSource.PlayOneShot(bork.B_love[borkNumber]);
        }

        if (word == "MAYBE")
        {
            borkNumber = Random.Range(0, bork.B_MAYBE.Length);
            audioSource.PlayOneShot(bork.B_MAYBE[borkNumber]);
        }

        if (word == "MESSAGES")
        {
            borkNumber = Random.Range(0, bork.B_MESSAGES.Length);
            audioSource.PlayOneShot(bork.B_MESSAGES[borkNumber]);
        }

        if (word == "NOPE")
        {
            borkNumber = Random.Range(0, bork.B_NOPE.Length);
            audioSource.PlayOneShot(bork.B_NOPE[borkNumber]);
        }

        if (word == "NOT")
        {
            borkNumber = Random.Range(0, bork.B_NOT.Length);
            audioSource.PlayOneShot(bork.B_NOT[borkNumber]);
        }

        if (word == "NOTHING")
        {
            borkNumber = Random.Range(0, bork.B_NOTHING.Length);
            audioSource.PlayOneShot(bork.B_NOTHING[borkNumber]);
        }

        if (word == "PERSONAL")
        {
            borkNumber = Random.Range(0, bork.B_PERSONAL.Length);
            audioSource.PlayOneShot(bork.B_PERSONAL[borkNumber]);
        }

        if (word == "quickly")
        {
            borkNumber = Random.Range(0, bork.B_quickly.Length);
            audioSource.PlayOneShot(bork.B_quickly[borkNumber]);
        }

        if (word == "RED")
        {
            borkNumber = Random.Range(0, bork.B_RED.Length);
            audioSource.PlayOneShot(bork.B_RED[borkNumber]);
        }

        if (word == "red")
        {
            borkNumber = Random.Range(0, bork.B_red.Length);
            audioSource.PlayOneShot(bork.B_red[borkNumber]);
        }

        if (word == "secret")
        {
            borkNumber = Random.Range(0, bork.B_secret.Length);
            audioSource.PlayOneShot(bork.B_secret[borkNumber]);
        }

        if (word == "SMALL")
        {
            borkNumber = Random.Range(0, bork.B_SMALL.Length);
            audioSource.PlayOneShot(bork.B_SMALL[borkNumber]);
        }

        if (word == "SOMETIMES")
        {
            borkNumber = Random.Range(0, bork.B_SOMETIMES.Length);
            audioSource.PlayOneShot(bork.B_SOMETIMES[borkNumber]);
        }

        if (word == "SORRY")
        {
            borkNumber = Random.Range(0, bork.B_SORRY.Length);
            audioSource.PlayOneShot(bork.B_SORRY[borkNumber]);
        }

        if (word == "squirrels")
        {
            borkNumber = Random.Range(0, bork.B_squirrels.Length);
            audioSource.PlayOneShot(bork.B_squirrels[borkNumber]);
        }

        if (word == "STARS")
        {
            borkNumber = Random.Range(0, bork.B_STARS.Length);
            audioSource.PlayOneShot(bork.B_STARS[borkNumber]);
        }

        if (word == "TAP")
        {
            borkNumber = Random.Range(0, bork.B_TAP.Length);
            audioSource.PlayOneShot(bork.B_TAP[borkNumber]);
        }

        if (word == "tap")
        {
            borkNumber = Random.Range(0, bork.B_tap.Length);
            audioSource.PlayOneShot(bork.B_tap[borkNumber]);
        }

        if (word == "the")
        {
            borkNumber = Random.Range(0, bork.B_the.Length);
            audioSource.PlayOneShot(bork.B_the[borkNumber]);
        }

        if (word == "THIS")
        {
            borkNumber = Random.Range(0, bork.B_THIS.Length);
            audioSource.PlayOneShot(bork.B_THIS[borkNumber]);
        }

        if (word == "this")
        {
            borkNumber = Random.Range(0, bork.B_this.Length);
            audioSource.PlayOneShot(bork.B_this[borkNumber]);
        }

        if (word == "TIME")
        {
            borkNumber = Random.Range(0, bork.B_TIME.Length);
            audioSource.PlayOneShot(bork.B_TIME[borkNumber]);
        }

        if (word == "time")
        {
            borkNumber = Random.Range(0, bork.B_time.Length);
            audioSource.PlayOneShot(bork.B_time[borkNumber]);
        }

        if (word == "too")
        {
            borkNumber = Random.Range(0, bork.B_too.Length);
            audioSource.PlayOneShot(bork.B_too[borkNumber]);
        }

        if (word == "WHISPERS")
        {
            borkNumber = Random.Range(0, bork.B_WHISPERS.Length);
            audioSource.PlayOneShot(bork.B_WHISPERS[borkNumber]);
        }

        if (word == "YELLOW")
        {
            borkNumber = Random.Range(0, bork.B_YELLOW.Length);
            audioSource.PlayOneShot(bork.B_YELLOW[borkNumber]);
        }

        if (word == "yellow")
        {
            borkNumber = Random.Range(0, bork.B_yellow.Length);
            audioSource.PlayOneShot(bork.B_yellow[borkNumber]);
        }

        if (word == "you")
        {
            borkNumber = Random.Range(0, bork.B_you.Length);
            audioSource.PlayOneShot(bork.B_you[borkNumber]);
        }
    }
}
