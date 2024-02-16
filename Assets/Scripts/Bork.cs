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
    private int headphonesRandomizer = 0;
    [SerializeField] private GameObject doggoWithHeadphones;
    [SerializeField] private GameObject doggoWithBow;
    [SerializeField] private GameObject doNotPress;
    private bool levelBeCleared = false;

    // Start is called before the first frame update
    void Start()
    {
        // Map audio source
        audioSource = GetComponent<AudioSource>();

        // Reset bork count
        PlayerPrefs.SetInt("BorkCount", 0);

        // Check if level Be has been cleared
        levelBeCleared = (PlayerPrefs.GetInt("Be") != 0);

        // Randomize headphones on Level Select screen
        if (SceneManager.GetActiveScene().name == "LevelSelect")
        { RandomizeHeadphones(); }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Randomize doggo headphones and bow
    private void RandomizeHeadphones()
    {
        // If level Be is complete, activate doggo bow
        if (levelBeCleared)
        {
            headphonesRandomizer = Random.Range(0, 3);
            if (headphonesRandomizer == 1)
            {
                doggoWithHeadphones.SetActive(true);
                doggoWithBow.SetActive(false);
            }
            else if (headphonesRandomizer == 2)
            {
                doggoWithHeadphones.SetActive(false);
                doggoWithBow.SetActive(true);
            }
            else
            {
                doggoWithHeadphones.SetActive(false);
                doggoWithBow.SetActive(false);
            }
        }
        // If level Be is not clear, cycle between headphones only
        else
        {
            headphonesRandomizer = Random.Range(0, 2);
            if (headphonesRandomizer == 1)
            { doggoWithHeadphones.SetActive(true); }
            else
            { doggoWithHeadphones.SetActive(false); }
        }
    }

    // Bork on button press
    public void BorkBork()
    {
        //Play a random bork sound
        borkNumber = Random.Range(0, bork.B_Bork.Length);
        audioSource.PlayOneShot(bork.B_Bork[borkNumber]);

        // Toggle headphones
        RandomizeHeadphones();

        // Mark doggo as borked
        PlayerPrefs.SetInt("BorkCount", PlayerPrefs.GetInt("BorkCount") + 1);

        // If bork count hi enough, activate doNotPress
        if (PlayerPrefs.GetInt("BorkCount") > 100)
        { doNotPress.SetActive(true); }
    }

    // Sing or whisper on button press
    public void BorkWord(string word)
    {

        // Map bork library - bork random sound

        if (word == "ALWAYS")
        {
            borkNumber = Random.Range(0, bork.B_ALWAYS.Length);
            audioSource.PlayOneShot(bork.B_ALWAYS[borkNumber]);
        }

        if (word == "AND")
        {
            borkNumber = Random.Range(0, bork.B_AND.Length);
            audioSource.PlayOneShot(bork.B_AND[borkNumber]);
        }

        if (word == "anne")
        {
            borkNumber = Random.Range(0, bork.B_anne.Length);
            audioSource.PlayOneShot(bork.B_anne[borkNumber]);
        }

        if (word == "are")
        {
            borkNumber = Random.Range(0, bork.B_are.Length);
            audioSource.PlayOneShot(bork.B_are[borkNumber]);
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

        if (word == "curse")
        {
            borkNumber = Random.Range(0, bork.B_curse.Length);
            audioSource.PlayOneShot(bork.B_curse[borkNumber]);
        }

        if (word == "CURSE")
        {
            borkNumber = Random.Range(0, bork.B_CURSE.Length);
            audioSource.PlayOneShot(bork.B_CURSE[borkNumber]);
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

        if (word == "ENJOY")
        {
            borkNumber = Random.Range(0, bork.B_ENJOY.Length);
            audioSource.PlayOneShot(bork.B_ENJOY[borkNumber]);
        }

        if (word == "FINE")
        {
            borkNumber = Random.Range(0, bork.B_FINE.Length);
            audioSource.PlayOneShot(bork.B_FINE[borkNumber]);
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

        if (word == "I")
        {
            borkNumber = Random.Range(0, bork.B_I.Length);
            audioSource.PlayOneShot(bork.B_I[borkNumber]);
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

        if (word == "loquacious")
        {
            borkNumber = Random.Range(0, bork.B_loquacious.Length);
            audioSource.PlayOneShot(bork.B_loquacious[borkNumber]);
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

        if (word == "my")
        {
            borkNumber = Random.Range(0, bork.B_my.Length);
            audioSource.PlayOneShot(bork.B_my[borkNumber]);
        }

        if (word == "MYSELF")
        {
            borkNumber = Random.Range(0, bork.B_MYSELF.Length);
            audioSource.PlayOneShot(bork.B_MYSELF[borkNumber]);
        }

        if (word == "nature")
        {
            borkNumber = Random.Range(0, bork.B_nature.Length);
            audioSource.PlayOneShot(bork.B_nature[borkNumber]);
        }

        if (word == "NATURE")
        {
            borkNumber = Random.Range(0, bork.B_NATURE.Length);
            audioSource.PlayOneShot(bork.B_NATURE[borkNumber]);
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

        if (word == "PEACE")
        {
            borkNumber = Random.Range(0, bork.B_PEACE.Length);
            audioSource.PlayOneShot(bork.B_PEACE[borkNumber]);
        }

        if (word == "PERSONAL")
        {
            borkNumber = Random.Range(0, bork.B_PERSONAL.Length);
            audioSource.PlayOneShot(bork.B_PERSONAL[borkNumber]);
        }

        if (word == "pray")
        {
            borkNumber = Random.Range(0, bork.B_pray.Length);
            audioSource.PlayOneShot(bork.B_pray[borkNumber]);
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

        if (word == "safe")
        {
            borkNumber = Random.Range(0, bork.B_safe.Length);
            audioSource.PlayOneShot(bork.B_safe[borkNumber]);
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

        if (word == "THE")
        {
            borkNumber = Random.Range(0, bork.B_THE.Length);
            audioSource.PlayOneShot(bork.B_THE[borkNumber]);
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

        if (word == "whisper")
        {
            borkNumber = Random.Range(0, bork.B_whisper.Length);
            audioSource.PlayOneShot(bork.B_whisper[borkNumber]);
        }

        if (word == "WHISPERS")
        {
            borkNumber = Random.Range(0, bork.B_WHISPERS.Length);
            audioSource.PlayOneShot(bork.B_WHISPERS[borkNumber]);
        }

        if (word == "WORLD")
        {
            borkNumber = Random.Range(0, bork.B_WORLD.Length);
            audioSource.PlayOneShot(bork.B_WORLD[borkNumber]);
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
