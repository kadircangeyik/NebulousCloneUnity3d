using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SpawnScript : MonoBehaviour
{
    private Vector2 randVector;
    public int enemiescount;
    public int holebluecount;
    public int holeblackcount;
    public int holepurplecount;
    public int FoodBlueCount;
    public int FoodGoldCount;
    public int FoodPinkCount;
    public int FoodPurpleCount;
    public int FoodRedCount;
    public int FoodTomatoCount;
    public int FoodWhiteCount;
    public int FoodYellowCount;
    public int PlasmaCount;
    public GameObject[] Enemies;
    public GameObject HoleBlue;
    public GameObject HoleBlack;
    public GameObject HolePurple;
    public GameObject FoodBlue;
    public GameObject FoodGold;
    public GameObject FoodPink;
    public GameObject FoodPurple;
    public GameObject FoodRed;
    public GameObject FoodTomato;
    public GameObject FoodWhite;
    public GameObject FoodYellow;
    public GameObject Plasma;
  
    private void Awake()
    {
        //Hole Blue
        for (int i = 0; i < holebluecount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(HoleBlue, randVector, Quaternion.identity);
        }
        //Hole Purple
        for (int i = 0; i < holepurplecount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(HolePurple, randVector, Quaternion.identity);
        }
        // Hole Black
        for (int i = 0; i < holeblackcount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(HoleBlack, randVector, Quaternion.identity);
        }
        //enemies
        for (int i = 0; i < enemiescount; i++)
        {

            Instantiate(Enemies[(int)Random.Range(0, Enemies.Length)], new Vector3(Random.Range(-15f, 15f),-15f, 15f), Quaternion.identity);
        }
        
        //FoodBlue
        for (int i = 0; i < FoodBlueCount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(FoodBlue, randVector, Quaternion.identity);
        }
        //FoodGold
        for (int i = 0; i < FoodGoldCount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(FoodGold, randVector, Quaternion.identity);
        }
        //FoodPink
        for (int i = 0; i < FoodPinkCount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(FoodPink, randVector, Quaternion.identity);
        }
        //FoodPurple
        for (int i = 0; i < FoodPurpleCount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(FoodPurple, randVector, Quaternion.identity);

        }
        //FoodRed
        for (int i = 0; i < FoodRedCount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(FoodRed, randVector, Quaternion.identity);
        }
        //FoodTomato
        for (int i = 0; i < FoodTomatoCount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(FoodTomato, randVector, Quaternion.identity);
        }
        //FoodWhite
        for (int i = 0; i < FoodWhiteCount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(FoodWhite, randVector, Quaternion.identity);
        }
        //FoodYellow
        for (int i = 0; i < FoodYellowCount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(FoodYellow, randVector, Quaternion.identity);

        }
        //Plasma
        for (int i = 0; i < PlasmaCount; i++)
        {
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            Instantiate(Plasma, randVector, Quaternion.identity);
        }
        
    }
}
