using UnityEngine;
using UnityEngine.UI;
public class EnemyController : MonoBehaviour
{
    private float scale;
    private Vector3 vecScale;
    private GameObject[] food;
    private GameObject[] food1;
    private GameObject[] food2;
    private GameObject[] food3;
    private GameObject[] food4;
    private GameObject[] food5;
    private GameObject[] food6;
    private GameObject[] food7;
    private GameObject[] food8;
    private GameObject[] food9;
    private GameObject[] playerd;
    private GameObject nearest;
    private bool hasTarget;
    private Vector2 randVector;
    private Vector2 foodPos;
    private float speed;
    private float quotient;
    private float delta;
    public float mass;
    public SpriteRenderer spriteRend;
    public uint score;
  
  

    // Start is called before the first frame update
    void Start()
    {
        mass = 6;
        vecScale.Set(1, 1, 1);
        
        hasTarget = false;
        delta = 5;
        score = 6;
    }

    // Update is called once per frame
    void Update()
    {
        scale = mass / 200 + 0.95f;
        vecScale.Set(scale, scale, 1);
        transform.localScale = vecScale;
        if (!hasTarget)
            FindNearestFood();
        if (hasTarget)
        {
            foodPos = nearest.transform.position;
            foodPos -= (Vector2)transform.position;
            quotient = foodPos.magnitude / delta;
            foodPos /= quotient;
            speed = 1 / Mathf.Sqrt(scale);
            transform.Translate(foodPos * Time.deltaTime * speed);
        }
        mass -= 0.00000002f * mass * mass;
       
    }

    void FindNearestFood()
    {
        food = GameObject.FindGameObjectsWithTag("FoodBlue");
        food1 = GameObject.FindGameObjectsWithTag("FoodGold");
        food2 = GameObject.FindGameObjectsWithTag("FoodPink");
        food3 = GameObject.FindGameObjectsWithTag("FoodPurple");
        food4 = GameObject.FindGameObjectsWithTag("FoodRed");
        food5 = GameObject.FindGameObjectsWithTag("FoodTomato");
        food6 = GameObject.FindGameObjectsWithTag("FoodWhite");
        food7 = GameObject.FindGameObjectsWithTag("FoodYellow");
        food8 = GameObject.FindGameObjectsWithTag("Plasma");
        food9 = GameObject.FindGameObjectsWithTag("HoleBlue");
       playerd = GameObject.FindGameObjectsWithTag("Player");

        float distance = Mathf.Infinity;
        Vector2 position = transform.position;
        foreach (GameObject f in food)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in food1)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in food2)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in food3)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in food4)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in food5)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in food6)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in food7)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in food8)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in food9)
        {
            Vector2 diff = (Vector2)f.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }
        foreach (GameObject f in playerd)
        {
            Vector2 diff = (Vector2)f.transform.position + position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                nearest = f;
                hasTarget = true;
                distance = curDistance;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    if (collision.gameObject.tag == "FoodBlue" || collision.gameObject.tag == "FoodGold" || collision.gameObject.tag == "FoodPink" || collision.gameObject.tag == "FoodPurple" || collision.gameObject.tag == "FoodRed" || collision.gameObject.tag == "FoodTomato" || collision.gameObject.tag == "FoodWhite" || collision.gameObject.tag == "FoodYellow" || collision.gameObject.tag == "Dot" || collision.gameObject.tag == "Plasma")
            {
            hasTarget = false;
            mass++;
            score++;
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            collision.gameObject.transform.position = randVector;
        }
        
        
 
       else if (collision.gameObject.tag == "HoleBlue")
        {
            hasTarget = false;
            mass += 70;
            score+= 70;
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            collision.gameObject.transform.position = randVector;
        }

        else if (collision.gameObject.tag == "HoleBlack")
        {
            hasTarget = false;
            mass -= 70;
            score -= 70;
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            collision.gameObject.transform.position = randVector;
        }

        else if (collision.gameObject.tag == "HolePurple")
        {
            hasTarget = false;
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            collision.gameObject.transform.position = randVector;
        }


    }
}