using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class GameFlow : MonoBehaviour
{
    public float timeLeft = 30.0f; //set each level to be 60 seconds
    public TMP_Text timer;
    public int currentLevel;
    public int currentscore;
    public Light lightFirst;
    public Light lightSecond;
    public Light lightThird;
    public Light lightForth;
    public Light lightFifth;

    // For lighting color
    public float r = 1;
    public float g = 1;
    public float b = 1;

    // User's opinions score
    public int redScore;
    public int blueScore;

    // Opinions content
    public GameObject title;
    public GameObject opinion_1;
    public GameObject opinion_2;
    public GameObject opinion_3;
    public GameObject opinion_4;
    public GameObject opinion_5;
    public GameObject opinion_6;
    public GameObject opinion_7;
    public GameObject opinion_8;
    private string[] opinions1_3;
    private string[] opinions2_4;
    private string[] opinions2_2;
    private string[] opinions3_5;
    private string[] opinions3_3;
    private string[] opinions3_1;
    private string title1_3;
    private string title2_4;
    private string title2_2;
    private string title3_5;
    private string title3_3;
    private string title3_1;

    // Use this for initialization
    void Start()
    {
        timer = GetComponent<TMP_Text>();
        currentLevel = 1;
        currentscore = 3; // 3 is the neutral score

        // set up lighting
        lightFirst.color = new Color(r, g, b);
        lightSecond.color = new Color(r, g, b);
        lightThird.color = new Color(r, g, b);
        lightForth.color = new Color(r, g, b);
        lightFifth.color = new Color(r, g, b);

        // set up opinion score
        redScore = 0;
        blueScore = 0;

        // set up content
        opinions1_3 = new string[] {
            "\". . .to not only offer thoughts and prayers, but to actually be able to do something about it.\" HOLY SHIT, YES PLEASE! This is incredible!",
            "Its our turn #GunControlNow",
            "We will stand and fight for our Virginia family and friends. Americans have to stand together against a tyranny government. This is what the 2 amendment was for.",
            "This should be a wake up call to all Americans. Put these people in power and you ARE going to loose your constitutional rights."
        };
        opinions2_4 = new string[] {
            "Republicans are the most corrupted and races party and people are tired of the damage they’re doing around the country. So we all knew this was coming",
            "The revolution is coming",
            "I understand and empathise with his stance, however in a bid to win presidency over a country for which owning and proudly displaying firearms is firmly embedded in its culture, this was not strategic. Win their support the rebuild the system from the inside.",
            "What do you need those war guns at home for? If someone in the family get into a fight will used to kill his/her siblings. If they get mentally imbalance will run out to the street to kill people at random. A buy back plan is a fair solution.",
            "Beto with a ba in English from Columbia can be schooled by the actual senator from Texas, Ted cruz, JD, from Harvard , undergraduate from Princeton, on the 2ND AMENDMENT",
            "Funny thing is, beta Beto couldn't do it himself, he'd have to send in his employees armed by him with AR-15's to get the job done."
        };
        opinions2_2 = new string[] {
            "We should look at the rest of the world as they have 1% of the mass shootings so they obviously have no mental illness. It is just America that is mad",
            "BAN is not possible.......BAN is not a Solution. Three points Solution ----- 1- Teach its consequences 2- Don't glorify it as freedom 3- Create social pressure Our Leaders & Celebrities have to QUIT these GOOD habits to show their MERCY for our Kids, Youth and Women.",
            "97% of the mass murders in USA occurred in gun free zones.",
            "Your not getting my guns.",
            "Live free or die! Stop #fakenews Keep your God given inalienable rights! How many lies can you take from them",
            "Maybe because guns don’t cause violence they’re a tool used in violence. NTM when media lies about motives or presents just a fraction of the shooters motives to form a narrative it gives people pause to take action."
        };
        opinions3_1 = new string[] {
            "Trump warned you",
            "Gun control takes away the gun from the good guy. The bad guy who is not obeying the law, keeps his guns...but the good guys have no guns and no way to protect himself or his family.",
            "The same in #Venezuela. Gun control only favored the dictator Maduro to control anyone who opposes him.",
            "mass murders by guns may have decreased in Australia but stabbings ,car jackings ,home invasions ,rapes ,robberies ect are always rising.....give back our guns to law abiding citizens",
            "The next generation is so dumb they want the government to control the guns and they want less freedom. They will give up their freedom in exchange for the illusion of safety.",
            "For a hunter, the challenge is catching that deer even if it took more than 3 bullets. And people who are new at the sport aren’t going to get it the first time around.",
            "Protect #2ndAmendment",
            "The radical Left Undermining our Constitution: and threatening our 2A Freedom."
        };
        opinions3_3 = new string[] {
            "They have however passed a bill to construct a Thoughts & Prayers Machine",
            "These judges seem to be happy to order opening up new mega factories to increase production of candles instead.....",
            "The Judge is brought to you by the Terrorist organization aka the NRA.",
            "Except that New York City has even stricter gun control laws and one of the lowest rates of gun violence of any major city. One example does not make an argument.",
            "CHICAGO - more strick gun control = most gun violence gun control only takes guns out of the hands of law-abiding citizens and",
            "America is unique. Our very EXSISTENCE WAS BY FORCE OF ARMS. Our founders gave us the 2nd Amendment as an eternal gift.",
            "Gun laws are already in affect, criminals don't follow the law, its just restricting law biding citizens. #combatvet#combatready",
            "So ridiculous, seriously how much time was wasted on this nonsense?"
        };
        opinions3_5 = new string[] {
            "I mean, guns are pretty gay.... prove your manliness with fisticuffs like real men do.",
            "That won’t work. Infantrymen love guns and are very homoerotic. They sleep with their guns and beat off with gunpowder.",
            "We have always had bad people, now we have bad people with AR15s.",
            "Or...In order to buy ammunition you have to pass a universal background check, take classes, pass a test, and maintain an ammunition license. Also limit the amount of ammunition one person can own. Nothing in the second amendment about a right to own bullets.",
            "The lack of gun control really sparks creativity!",
            "In the past 4 decades from what I have witnessed, I have not seen one law passed by politicians that deter mass shootings.",
            "We shouldn’t even have to do all this.",
            "Absolutely nothing to like about these events. Your 228 year old outdated 2nd Amendment is largely responsible for this. The United States is trapped in a \"Spaghetti Western Time Warp\""
        };
        title1_3 = "Virginia governor to reintroduce gun control measures after Dems win state government control";
        title2_4 = "Beto O\"Rourke\"s bold statement on gun control: \"Hell yes\" he wants to take your AR-15";
        title2_2 = "The shootings came one after another. A well-known cycle followed: shooting, mourning, calls for change. But by Labor Day weekend, the debate about gun control had returned to a familiar stalemate.";
        title3_5 = "How do we control guns without gun control? Make guns gay.";
        title3_3 = "A Pennsylvania judge struck down 3 gun control ordinances, including an assault weapons ban, enacted by the City of Pittsburgh after the mass shooting at the Tree of Life synagogue last year";
        title3_1 = "Facts: In the U.K, guns are highly regulated. It is illegal to carry a knife longer than three inches. Despite these restrictions, violent crimes have now surpassed that of New York City. Gun control ≠ less gun violence.";

        // initialize the scene with 1-3 content
        title.GetComponent<TMP_Text>().text = title1_3;
        title.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level1-3-", 0));
        opinion_1.GetComponent<TMP_Text>().text = opinions1_3[0];
        opinion_1.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level1-3-", 1));
        opinion_1.GetComponent<OpinionObject>().opinionSide = 1;
        opinion_2.GetComponent<TMP_Text>().text = opinions1_3[1];
        opinion_2.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level1-3-", 2));
        opinion_2.GetComponent<OpinionObject>().opinionSide = 1;
        opinion_3.GetComponent<TMP_Text>().text = opinions1_3[2];
        opinion_3.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level1-3-", 3));
        opinion_3.GetComponent<OpinionObject>().opinionSide = -1;
        opinion_4.GetComponent<TMP_Text>().text = opinions1_3[3];
        opinion_4.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level1-3-", 4));
        opinion_4.GetComponent<OpinionObject>().opinionSide = -1;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timer.text = timeLeft.ToString("0");

        // TODO: update opinion scores, integrate with OVRGaze

        if (timeLeft <= 0)
        {
            currentLevel++;

            if (currentLevel == 2) {
                timeLeft = 45.0f;
                // Load content based on opinion scores
                if (redScore > blueScore)
                {
                    // load level 2_4 content and dynamicallty instantiate objects
                    title.GetComponent<TMP_Text>().text = title2_4;
                    title.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-4-", 0));
                    opinion_1.GetComponent<TMP_Text>().text = opinions2_4[0];
                    opinion_1.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-4-", 1));
                    opinion_1.GetComponent<OpinionObject>().opinionSide = 1;
                    opinion_2.GetComponent<TMP_Text>().text = opinions2_4[1];
                    opinion_2.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-4-", 2));
                    opinion_2.GetComponent<OpinionObject>().opinionSide = 1;
                    opinion_3.GetComponent<TMP_Text>().text = opinions2_4[2];
                    opinion_3.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-4-", 3));
                    opinion_3.GetComponent<OpinionObject>().opinionSide = 1;
                    opinion_4.GetComponent<TMP_Text>().text = opinions2_4[3];
                    opinion_4.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-4-", 4));
                    opinion_4.GetComponent<OpinionObject>().opinionSide = 1;
                    opinion_5.GetComponent<TMP_Text>().text = opinions2_4[4];
                    opinion_5.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-4-", 5));
                    opinion_5.GetComponent<OpinionObject>().opinionSide = -1;
                    opinion_6.GetComponent<TMP_Text>().text = opinions2_4[5];
                    opinion_6.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-4-", 6));
                    opinion_6.GetComponent<OpinionObject>().opinionSide = -1;

                    // Change lighting
                    r = 1f;
                    g = 0.75f;
                    b = 0.75f;

                    currentscore++;
                } else if (blueScore >= redScore)
                {
                    // load level 2-2 content and dynamicallty instantiate objects
                    title.GetComponent<TMP_Text>().text = title2_2;
                    title.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-2-", 0));
                    opinion_1.GetComponent<TMP_Text>().text = opinions2_2[0];
                    opinion_1.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-2-", 1));
                    opinion_1.GetComponent<OpinionObject>().opinionSide = 1;
                    opinion_2.GetComponent<TMP_Text>().text = opinions2_2[1];
                    opinion_2.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-2-", 2));
                    opinion_2.GetComponent<OpinionObject>().opinionSide = -1;
                    opinion_3.GetComponent<TMP_Text>().text = opinions2_2[2];
                    opinion_3.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-2-", 3));
                    opinion_3.GetComponent<OpinionObject>().opinionSide = -1;
                    opinion_4.GetComponent<TMP_Text>().text = opinions2_2[3];
                    opinion_4.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-2-", 4));
                    opinion_4.GetComponent<OpinionObject>().opinionSide = -1;
                    opinion_5.GetComponent<TMP_Text>().text = opinions2_2[4];
                    opinion_5.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-2-", 5));
                    opinion_5.GetComponent<OpinionObject>().opinionSide = -1;
                    opinion_6.GetComponent<TMP_Text>().text = opinions2_2[5];
                    opinion_6.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level2-2-", 6));
                    opinion_6.GetComponent<OpinionObject>().opinionSide = -1;

                    // Change lighting
                    r = 0.75f;
                    g = 0.75f;
                    b = 1f;

                    currentscore--; 
                }

                // update lighting
                lightFirst.color = new Color(r, g, b);
                lightSecond.color = new Color(r, g, b);
                lightThird.color = new Color(r, g, b);
                lightForth.color = new Color(r, g, b);
                lightFifth.color = new Color(r, g, b);

                // reset blueScore and redScore
                redScore = 0;
                blueScore = 0;
            }
            else if (currentLevel == 3) {
                timeLeft = 60.0f;

                if (currentscore == 4)
                {
                    if (redScore > blueScore)
                    {
                        // load level 3-5
                        title.GetComponent<TMP_Text>().text = title3_5;
                        title.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-5-", 0));
                        opinion_1.GetComponent<TMP_Text>().text = opinions3_5[0];
                        opinion_1.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-5-", 1));
                        opinion_1.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_2.GetComponent<TMP_Text>().text = opinions3_5[1];
                        opinion_2.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-5-", 2));
                        opinion_2.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_3.GetComponent<TMP_Text>().text = opinions3_5[2];
                        opinion_3.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-5-", 3));
                        opinion_3.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_4.GetComponent<TMP_Text>().text = opinions3_5[3];
                        opinion_4.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-5-", 4));
                        opinion_4.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_5.GetComponent<TMP_Text>().text = opinions3_5[4];
                        opinion_5.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-5-", 5));
                        opinion_5.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_6.GetComponent<TMP_Text>().text = opinions3_5[5];
                        opinion_6.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-5-", 6));
                        opinion_6.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_7.GetComponent<TMP_Text>().text = opinions3_5[6];
                        opinion_7.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-5-", 7));
                        opinion_7.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_8.GetComponent<TMP_Text>().text = opinions3_5[7];
                        opinion_8.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-5-", 8));
                        opinion_8.GetComponent<OpinionObject>().opinionSide = 1;
                        // change lighting
                        r = 1f;
                        g = 0.5f;
                        b = 0.5f;

                        currentscore++;
                    } else if (redScore <= blueScore)
                    {
                        // load level 3-3
                        title.GetComponent<TMP_Text>().text = title3_3;
                        title.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 0));
                        opinion_1.GetComponent<TMP_Text>().text = opinions3_3[0];
                        opinion_1.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 1));
                        opinion_1.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_2.GetComponent<TMP_Text>().text = opinions3_3[1];
                        opinion_2.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 2));
                        opinion_2.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_3.GetComponent<TMP_Text>().text = opinions3_3[2];
                        opinion_3.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 3));
                        opinion_3.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_4.GetComponent<TMP_Text>().text = opinions3_3[3];
                        opinion_4.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 4));
                        opinion_4.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_5.GetComponent<TMP_Text>().text = opinions3_3[4];
                        opinion_5.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 5));
                        opinion_5.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_6.GetComponent<TMP_Text>().text = opinions3_3[5];
                        opinion_6.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 6));
                        opinion_6.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_7.GetComponent<TMP_Text>().text = opinions3_3[6];
                        opinion_7.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 7));
                        opinion_7.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_8.GetComponent<TMP_Text>().text = opinions3_3[7];
                        opinion_8.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 8));
                        opinion_8.GetComponent<OpinionObject>().opinionSide = -1;

                        // change lighting
                        r = 0.75f;
                        g = 0.5f;
                        b = 0.75f;

                        currentscore--; 
                    }
                } else if (currentscore == 2)
                {
                    if (redScore > blueScore)
                    {
                        // load level 3-3
                        title.GetComponent<TMP_Text>().text = title3_3;
                        title.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 0));
                        opinion_1.GetComponent<TMP_Text>().text = opinions3_3[0];
                        opinion_1.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 1));
                        opinion_1.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_2.GetComponent<TMP_Text>().text = opinions3_3[1];
                        opinion_2.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 2));
                        opinion_2.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_3.GetComponent<TMP_Text>().text = opinions3_3[2];
                        opinion_3.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 3));
                        opinion_3.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_4.GetComponent<TMP_Text>().text = opinions3_3[3];
                        opinion_4.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 4));
                        opinion_4.GetComponent<OpinionObject>().opinionSide = 1;
                        opinion_5.GetComponent<TMP_Text>().text = opinions3_3[4];
                        opinion_5.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 5));
                        opinion_5.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_6.GetComponent<TMP_Text>().text = opinions3_3[5];
                        opinion_6.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 6));
                        opinion_6.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_7.GetComponent<TMP_Text>().text = opinions3_3[6];
                        opinion_7.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 7));
                        opinion_7.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_8.GetComponent<TMP_Text>().text = opinions3_3[7];
                        opinion_8.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-3-", 8));
                        opinion_8.GetComponent<OpinionObject>().opinionSide = -1;

                        // change lighting
                        r = 0.75f;
                        g = 0.5f;
                        b = 0.75f;

                        currentscore++;
                    } else if (redScore <= blueScore)
                    {
                        // load level 3-1
                        title.GetComponent<TMP_Text>().text = title3_1;
                        title.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-1-", 0));
                        opinion_1.GetComponent<TMP_Text>().text = opinions3_1[0];
                        opinion_1.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-1-", 1));
                        opinion_1.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_2.GetComponent<TMP_Text>().text = opinions3_1[1];
                        opinion_2.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-1-", 2));
                        opinion_2.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_3.GetComponent<TMP_Text>().text = opinions3_1[2];
                        opinion_3.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-1-", 3));
                        opinion_3.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_4.GetComponent<TMP_Text>().text = opinions3_1[3];
                        opinion_4.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-1-", 4));
                        opinion_4.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_5.GetComponent<TMP_Text>().text = opinions3_1[4];
                        opinion_5.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-1-", 5));
                        opinion_5.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_6.GetComponent<TMP_Text>().text = opinions3_1[5];
                        opinion_6.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-1-", 6));
                        opinion_6.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_7.GetComponent<TMP_Text>().text = opinions3_1[6];
                        opinion_7.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-1-", 7));
                        opinion_7.GetComponent<OpinionObject>().opinionSide = -1;
                        opinion_8.GetComponent<TMP_Text>().text = opinions3_1[7];
                        opinion_8.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(AudioSourcePath("Level3-1-", 8));
                        opinion_8.GetComponent<OpinionObject>().opinionSide = -1;

                        // change lighting
                        r = 0.5f;
                        g = 0.5f;
                        b = 1f;

                        currentscore--;
                    }
                } else
                {
                    // do nothing
                }

                // update lighting
                lightFirst.color = new Color(r, g, b);
                lightSecond.color = new Color(r, g, b);
                lightThird.color = new Color(r, g, b);
                lightForth.color = new Color(r, g, b);
                lightFifth.color = new Color(r, g, b);
            }
            else if (currentLevel > 3) {
                // Transit to the Data Screen
            }
        }
    }

    private string AudioSourcePath(string level, int index)
    {
        return level + index;
    }
}
