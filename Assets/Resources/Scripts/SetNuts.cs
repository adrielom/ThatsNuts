using UnityEngine;
using UnityEngine.UI;

public class SetNuts : Nuts {

    //declaraçao de variaveis
    int lastLevel;
    public GameObject[] nuts;
	public GameObject[] stars;
	public GameObject gameOverLayout;
	public GameObject pauseLayout;
	public GameObject nextLevel;
    public float countdownTime = 0f;
    public float gameOverTime = 90f;
    public static int quantHammer = 3;
	public static int levels = 1;
	public float timer = 10f;
	public static int quantSpdd = 3;
	public static int quantClock = 3;
	public static float countdown;
	public float demand;
	public static float totalMoney;
	public static float oneStar;
	public static float twoStar;
	public static float threeStar;
    public Text hammerT;
	public Text quantSpddT;
    public Text lifes;
    public Text scores;
	public Text clockT;
	public Text countdownT;

	//roda uma vez ao iniciar o jogo
	void Start(){
		//inicializando cronometro, layout do pause e do gameover, que ficam em stand by, esperando serem chamados.
		if (levels == 1){
			PlayerPrefs.SetInt("levels", 1);
		}
		else{
			levels = PlayerPrefs.GetInt ("levels");
		}
		countdown = 60;
		gameOverLayout.transform.position = new Vector3(transform.position.x, transform.position.y, -10000f);
		pauseLayout.transform.position = new Vector3 (transform.position.x, transform.position.y, -10000f);
		stars[0].gameObject.GetComponent<Image>().enabled = false; 
		stars[1].gameObject.GetComponent<Image>().enabled = false; 
		stars[2].gameObject.GetComponent<Image>().enabled = false; 
		nextLevel.GetComponent<Button>().enabled = false;

		//seleçao de level
		switch (levels) {
			case 1:
				demand = 50;
				oneStar = 50;
				twoStar = 60;
				threeStar = 70;
				levels = 1;
                SetNuts.speed = 2;
			break;

			case 2:
				demand = 55;
				oneStar = 55;
				twoStar = 65;
				threeStar = 80;
				levels = 2;
                SetNuts.speed = 2;  
            break;

			case 3:
				demand = 60;
				oneStar = 60;
				twoStar = 80;
				threeStar = 90;
				levels = 3;
                SetNuts.speed = 2.5f;
            break;

			case 4:
				demand = 65;
				oneStar = 65;
				twoStar = 85;
				threeStar = 105;
				levels = 4;
                SetNuts.speed = 2.5f;
            break;

			case 5:
				demand = 70;
				oneStar = 70;
				twoStar = 90;
				threeStar = 110;
				levels = 5;
                SetNuts.speed = 2.7f;
            break;

			case 6:
				demand = 75;
				oneStar = 75;
				twoStar = 95;
				threeStar = 115;
				levels = 6;
                SetNuts.speed = 2.8f;
            break;

			case 7:
				countdown = 80;
				demand = 80;
				oneStar = 80;
				twoStar = 100;
				threeStar = 120;
				levels = 7;
                SetNuts.speed = 2.9f;
            break;

			case 8:
				countdown = 80;
				demand = 85;
				oneStar = 85;
				twoStar = 105;
				threeStar = 125;
				levels = 8;
                SetNuts.speed = 3f;
            break;

			case 9:
				countdown = 80;
				demand = 90;
				oneStar = 90;
				twoStar = 110;
				threeStar = 130;
				levels = 9;
                SetNuts.speed = 3f;
            break;

			case 10:
				
				totalMoney = PlayerPrefs.GetFloat("score");
				levels = 10;
                SetNuts.speed = 3.5f;
            break;
		}
        

        PlayerPrefs.SetInt ("levels", levels);	
	}

	//Chamado a cada frame
    void FixedUpdate () {

		//coloca o hud na tela, atualiza o tempo do jogo



		if (levels > 9) {
			countdownT.text = "∞";
		} 
		else {
			countdownT.text = countdown.ToString ("F1");
			countdown -= Time.deltaTime;

		}
        lifes.text = life.ToString();
		scores.text = score.ToString();
		hammerT.text = "x " + quantHammer.ToString();
		clockT.text = "x " + quantClock.ToString ();
		quantSpddT.text = "x " + quantSpdd.ToString ();

		//checa se esta sem vidas, ou se o tempo acabou
		if ((life <= 0) || (countdown <= 0))
        {
			//limpa a tela, zera o cronometro, para as nozes, calcula o total de pontos e chama as estrelas de pontuaçao.
			countdown = 0;
			ClearScreen();
			speed = 0;
			if (levels < 10){
				totalMoney = score - demand;
                if (Nuts.score >= threeStar ){
					stars[0].gameObject.GetComponent<Image>().enabled = true;
					stars[1].gameObject.GetComponent<Image>().enabled = true; 
					stars[2].gameObject.GetComponent<Image>().enabled = true;
					nextLevel.GetComponent<Button>().enabled = true;
				}
				else if (Nuts.score >= twoStar){
					stars[0].gameObject.GetComponent<Image>().enabled = true; 
					stars[1].gameObject.GetComponent<Image>().enabled = true; 
					nextLevel.GetComponent<Button>().enabled = true;
					
				}
				else if (Nuts.score >= oneStar){
					stars[0].gameObject.GetComponent<Image>().enabled = true; 
					nextLevel.GetComponent<Button>().enabled = true;
					
				}
                PlayerPrefs.SetInt ("lastLevel", levels);
			}
			else if (levels == 10) {
                stars[0].gameObject.GetComponent<Image>().enabled = false;
				stars[1].gameObject.GetComponent<Image>().enabled = false; 
				stars[2].gameObject.GetComponent<Image>().enabled = false;
				nextLevel.GetComponent<Button>().interactable = false;
				PlayerPrefs.SetInt("totalMoney", score);
				PlayerPrefs.SetInt("levels", 10);
                PlayerPrefs.SetInt ("lastLevel", 10);
			}

			gameOverLayout.transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
		}

		//se as vidas ou o tempo nao forem 0
        else
        {
			//valores randomicos sao escolhidos
            int rand = Random.Range(0, 10);
            float randT = Random.Range(0f, 0.2f);
            countdownTime = SimpleTimer(randT);

			//se a posiçao for acima da tela, randomiza as sprites das nozes e da uma tag pra noz
            if (((nuts[rand].transform.position.y >= 6f) && countdownTime < 0))
            {
				countdownTime = randT;
				RandomizeSprites (nuts[rand]);
				IsGoodOrBad (nuts[rand]);

            }

			//power up do martelo
            if ((PowerUps.hammerTime == true) && (quantHammer > 0))
            {
				audio.GetComponent<AudioSource>().PlayOneShot(sounds[4], 1f);
                ClearScreenPowerup();
            }

			//powerup da velocidade
			if ((PowerUps.spddBool == true) && (quantSpdd > 0))
			{

				timer -= Time.deltaTime;

				if (timer >= 0){
					Nuts.speed = 1;
				}
				else{
					Nuts.speed = 1.5f;
					quantSpdd--;

					PowerUps.spddBool = false;
					audio.PlayOneShot(sounds[5], 1f);
				}
			
			//power up do boost de tempo
			}
			if ((PowerUps.clockBool == true) && (quantClock > 0)){
				audio.PlayOneShot(sounds[6], 1f);

				countdown += 15;
				PowerUps.clockBool = false;
				quantClock --;
			}

		}
		
	}


	//um cronometro que recebe a quantidade de seguntos e leva ate zero
    public float SimpleTimer(float t) {
        t -= Time.deltaTime;
        return t;
    }

	//retira todas as nozes da tela e leva elas pra uma posiçao aleatoria acima da tela
    public void ClearScreenPowerup()
    {
		//vetor de nozes
        for (int i = 0; i < nuts.Length; i++)
        {
			//posiçao aleatoria acima da tela
            nuts[i].transform.position = new Vector2((-5f + i)*0.5f, Random.Range(6f, 13f));

			//compara a tag e soma pontos as nozes boas
            if (nuts[i].tag == "GoodFall")
            { 
                score++;
            }
        }
		//desabilita o power up e diminui a quantidade de martelos
        PowerUps.hammerTime = false;
        quantHammer--;
    }

	//limpa a tela e coloca as nozes acima da tela
	public void ClearScreen()
	{
		for (int i = 0; i < nuts.Length; i++)
		{
			nuts[i].transform.position = new Vector2((-5f + i)*0.5f, Random.Range(6f, 13f));
		}
	}
    
	//um valor aleatorio e escolhido e dai sao escolhidas as sprites do objeto
	public void RandomizeSprites(GameObject rg) {
		int nt = Random.Range (0,5);
		switch (nt) {

			case 0:
				rg.gameObject.GetComponent<SpriteRenderer>().sprite = whiteSprite;
			break;
			case 1:
				rg.gameObject.GetComponent<SpriteRenderer>().sprite = goldenSprite;
			break;
			case 2:
				rg.gameObject.GetComponent<SpriteRenderer>().sprite = darkSprite;
			break;
			case 3:
				rg.gameObject.GetComponent<SpriteRenderer>().sprite = whiteSprite;
			break;
			case 4:
				rg.gameObject.GetComponent<SpriteRenderer>().sprite = whiteSprite;
			break;
		}

	}

	//checa qual sprite o objeto tem e da uma tag apropriada
	public void IsGoodOrBad(GameObject nt)
	{
		if (nt.gameObject.GetComponent<SpriteRenderer>().sprite == whiteSprite){
			nt.gameObject.tag = "GoodFall";
		}
		else if (nt.gameObject.GetComponent<SpriteRenderer>().sprite == darkSprite){
			nt.gameObject.tag = "BadFall";
		}
		else if (nt.gameObject.GetComponent<SpriteRenderer>().sprite == goldenSprite){
			nt.gameObject.tag = "GoldFall";
		}


	}

	
}
