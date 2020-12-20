using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NewBehaviourScript : MonoBehaviour
{
    public float force;
    private List<Vector3> quillePositions;
    private List<Quaternion> quilleRotations;
    private Vector3 capsulePosition;
    public int l;
    public int count;
    public int quilleCount;
    public int r1;
    public int r2;
    public int r3;
    public int r4;
    public int r5;
    public int r6;
    public int r7;
    public int r8;
    public int r9;
    public int r10;
    public int r11;
    public int r12;
    public int qt;

    public GameObject quille1;
    public GameObject quille2;
    public GameObject quille3;
    public GameObject quille4;
    public GameObject quille5;
    public GameObject quille6;
    public GameObject quille7;
    public GameObject quille8;
    public GameObject quille9;
    public GameObject quille10;
    public GameObject quille11;
    public GameObject quille12;



    // Use this for initialization
    void Start()
    {
        print("Le jeu commence\n");
        l = 1;
        count = 3;



        //To check if the capsule has already counted
        r1 = 0;
        r2 = 0;
        r3 = 0;
        r4 = 0;
        r5 = 0;
        r6 = 0;
        r7 = 0;
        r8 = 0;
        r9 = 0;
        r10 = 0;
        r11 = 0;
        r12 = 0;
        quilleCount = 0;
        qt = 1;



        var quille = GameObject.FindGameObjectsWithTag("Cylinder");
        quillePositions = new List<Vector3>();
        quilleRotations = new List<Quaternion>();
        foreach (var pin in quille)
        {
            quillePositions.Add(pin.transform.position);
            quilleRotations.Add(pin.transform.rotation);
        }
        capsulePosition = GameObject.FindGameObjectWithTag("Capsule").transform.position;
    }



    // Update is called once per frame
    void Update()
    {
        if (quille1.transform.position.y < 1 & r1 == 0)
        {
            r1 = 1;
            quilleCount = quilleCount + 1;



        }
        if (quille2.transform.position.y < 1 & r2 == 0)
        {
            r2 = 1;
            quilleCount = quilleCount + 2;
        }
        if (quille3.transform.position.y < 1 & r3 == 0)
        {
            r3 = 1;
            quilleCount = quilleCount + 3;
        }
        if (quille4.transform.position.y < 1 & r4 == 0)
        {
            r4 = 1;
            quilleCount = quilleCount + 4;
        }
        if (quille5.transform.position.y < 1 & r5 == 0)
        {
            r5 = 1;
            quilleCount = quilleCount + 5;
        }
        if (quille6.transform.position.y < 1 & r6 == 0)
        {
            r6 = 1;
            quilleCount = quilleCount + 6;
        }
        if (quille7.transform.position.y < 1 & r7 == 0)
        {
            r7 = 1;
            quilleCount = quilleCount + 7;
        }
        if (quille8.transform.position.y < 1 & r8 == 0)
        {
            r8 = 1;
            quilleCount = quilleCount + 8;
        }
        if (quille9.transform.position.y < 1 & r9 == 0)
        {
            r9 = 1;
            quilleCount = quilleCount + 9;
        }
        if (quille10.transform.position.y < 1 & r10 == 0)
        {
            r10 = 1;
            quilleCount = quilleCount + 10;
        }
        if (quille11.transform.position.y < 1 & r11 == 0)
        {
            r11 = 1;
            quilleCount = quilleCount + 11;
        }
        if (quille12.transform.position.y < 1 & r12 == 0)
        {
            r12 = 1;
            quilleCount = quilleCount + 12;
        }
        if (quilleCount == 50)
        {
            print(" gagner....");

            print("quit");
            qt = 0;
        }
        if (quilleCount > 50)
        {
            print(" vous avez depassé 50 votre score repasse à 25");
            quilleCount = 25;



            ;
        }
    }
}
