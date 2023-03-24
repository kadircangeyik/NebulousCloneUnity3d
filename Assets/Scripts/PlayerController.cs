using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{

    private Vector2 mousePos;
    private Vector2 randVector;
    private Vector3 vecScale;
    private float camSize;
    private float scale;
    private bool isAlive;
    private bool onPause;
    private uint score;
    public uint plasma;
    private Vector2 playerPos;
    
    public Slider sliderInstance;
    public static float BucketsCount;
    public float mass;
    public Camera cam;
    public float speed;
    public SpriteRenderer spriteRend;
    public SpriteRenderer spriteRender;
    public GameObject panel;
    public Text scoreText;
    public Text scoreText2;
    public Text plasmaText;
    public Text menuText;
    public Text levelText;
    public Text UpdateLevel;
    public int level;
    public GameObject levelupdate;
    public TextMeshPro playernametmpro;
    public TextMeshPro levelTextPlayer;
    public TMP_InputField usernameinputtmpro;
    public GameObject playerdot;
    
    public GameObject player;
    public GameObject PlayerCamera;
    public GameObject MapCamera;
    public AudioSource audioPlayer;
    public AudioSource audioPlayer1;
    public AudioSource audioPlayer2;
    public AudioSource audioPlayer3;

    public void dns()
    {
        panel.SetActive(false);
        mass = 6;
        vecScale.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f), Random.Range(-15f, 15f));
        camSize = 5;
        speed = 0.9F;
        isAlive = true;
        PlayerCamera.SetActive(true);
        MapCamera.SetActive(false);
        onPause = false;
        
        score = 6;
        scoreText.text = score.ToString();
        scoreText2.text = score.ToString();
        level = 1;
        playernametmpro.text = PlayerPrefs.GetString("nickname");
        sliderInstance.minValue = 0;
        sliderInstance.maxValue = 100;
        sliderInstance.wholeNumbers = true;
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
        spriteRender = gameObject.GetComponent<SpriteRenderer>();
    }
   
    
    void Update()
    {
        if (!onPause && isAlive)
        {
            scale = mass / 200 + 0.95f;
            vecScale.Set(scale, scale, 1);
            transform.localScale = vecScale;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos -= (Vector2)transform.position;
            speed = 1 / Mathf.Sqrt(scale);
            transform.Translate(mousePos * Time.deltaTime * speed);
            playerPos = transform.position;
            if (playerPos.x < -16f)
                playerPos.x = -16f;
            if (playerPos.x > 16f)
                playerPos.x = 16f;
            if (playerPos.y < -16f)
                playerPos.y = -16f;
            if (playerPos.y > 16f)
                playerPos.y = 16f;
            if (playerPos != (Vector2)transform.position)
                transform.position = playerPos;
            mass -= 0.00000002f * mass * mass;
            if (mass < 1)
                mass = 1;
            if (cam.orthographicSize > camSize)
            {
                if (cam.orthographicSize - 1 > camSize)
                    cam.orthographicSize = camSize;
                else
                    cam.orthographicSize -= 0.0001f;
            }
            else if (cam.orthographicSize < camSize)
            {
                if (cam.orthographicSize + 1 < camSize)
                    cam.orthographicSize = camSize;
                else
                    cam.orthographicSize += 0.0001f;
            }
        }
        if (isAlive && Input.GetKeyDown(KeyCode.Escape))
        {

            menuText.text = "MENU";
            panel.SetActive(!onPause);
            onPause = !onPause;
            

        }
        if (sliderInstance.value == sliderInstance.maxValue)
        {
            BucketsCount = sliderInstance.minValue;
            sliderInstance.value = BucketsCount;
            level += 1;
            levelText.text = "Level: "+ level.ToString();
            levelTextPlayer.text = level.ToString();
            UpdateLevel.text = "LEVEL" + level.ToString();
            levelupdate.SetActive(true);
            sliderInstance.maxValue += 100;
            Invoke("HideShowGameobject", 2);

        }
        if (score <= 6)
        {
            score = 6;
        }
    }
    void HideShowGameobject()
    {
        if (levelupdate.active)
            levelupdate.SetActive(false);
        else
            levelupdate.SetActive(true);
    }
    public void change(Sprite differentSprite)
    {
        spriteRend.sprite = differentSprite; //sets sprite renderers sprite
        spriteRender.sprite = differentSprite; //sets sprite renderers sprite
    }
    public void btndot()
    {
        randVector.Set(playerPos.x+= 1f, playerPos.y+=1f);
        Instantiate(playerdot, randVector, Quaternion.identity);
        mass -= 30f;
        score -= 1;
        scoreText.text = score.ToString();
        scoreText2.text = score.ToString();
       
    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dot")
        {
            audioPlayer.Play();
            mass += 5f;
            score += 1;
            scoreText.text = score.ToString();
            scoreText2.text = score.ToString();
            collision.gameObject.transform.position = randVector;
            camSize += 0.01f;
        }

        if (collision.gameObject.tag == "FoodBlue"|| collision.gameObject.tag == "FoodGold" || collision.gameObject.tag == "FoodPink" || collision.gameObject.tag == "FoodPurple" || collision.gameObject.tag == "FoodRed" || collision.gameObject.tag == "FoodTomato"|| collision.gameObject.tag == "FoodWhite"|| collision.gameObject.tag == "FoodYellow")
        {
            audioPlayer.Play();
            BucketsCount += 5;
            sliderInstance.value = BucketsCount;
            mass ++;
            score ++;
            scoreText.text = score.ToString();
            scoreText2.text = score.ToString();
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            collision.gameObject.transform.position = randVector;
            camSize += 0.01f;
        }
        else if (collision.gameObject.tag == "HoleBlue")
        {
            audioPlayer1.Play();
            BucketsCount += 25;
            sliderInstance.value = BucketsCount;
            mass += 5;
            score += 90;
            scoreText.text = score.ToString();
            scoreText2.text = score.ToString();
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            collision.gameObject.transform.position = randVector;
            camSize += 0.05f;
        }
        else if (collision.gameObject.tag == "HolePurple")
        {
            audioPlayer2.Play();     
            BucketsCount += 25;
            sliderInstance.value = BucketsCount;
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            collision.gameObject.transform.position = randVector;
  
        }
        else if (collision.gameObject.tag == "HoleBlack")
        {
            audioPlayer3.Play();
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            collision.gameObject.transform.position = randVector;
            
            if (score <= 120)
            {
                score = 6;
                scoreText.text = score.ToString();
                camSize = 5;
                mass = 6f;
            }
            else
                score -= 120;
                scoreText.text = score.ToString();
                scoreText2.text = score.ToString();
                camSize -= 1.2f;
                mass -= 120f;
        }
        else if (collision.gameObject.tag == "Plasma")
        {
            audioPlayer.Play();
            BucketsCount += 8;
            sliderInstance.value = BucketsCount;
            mass ++;
            score += 5;
            scoreText.text = score.ToString();
            scoreText2.text = score.ToString();
            plasma += 1;
            plasmaText.text = plasma.ToString();
            randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
            collision.gameObject.transform.position = randVector;
            camSize += 0.01f;
        }
        else if (collision.gameObject.tag == "Fight")
        {
            EnemyController enemy = collision.gameObject.GetComponent<EnemyController>();
            if (enemy.mass < mass * 1.2f)
            {
                BucketsCount += enemy.score;
                sliderInstance.value = BucketsCount;
                mass += enemy.mass;
                score += enemy.score;
                scoreText.text = score.ToString();
                scoreText2.text = score.ToString();
                camSize += enemy.mass * 0.001f;
                
                randVector.Set(Random.Range(-15f, 15f), Random.Range(-15f, 15f));
                collision.gameObject.transform.position = randVector;
                enemy.mass = 6;
                
                enemy.score = 6;

            }
            else if (enemy.mass * 1.2f > mass)
            {
                PlayerCamera.SetActive(false);
                MapCamera.SetActive(true);
                panel.SetActive(true);
                isAlive = false;
                
            }
        }
    }
    
   
    public void Create()
    {
        playernametmpro.text = usernameinputtmpro.text;
        PlayerPrefs.SetString("nickname", playernametmpro.text);
        PlayerPrefs.Save();
    }
}
