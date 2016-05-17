using UnityEngine;
using System.Collections;

public class Nuts : MonoBehaviour {

	//Declaraçao das variaveis

    public static float speed;
    public Sprite brokenSprite;
    public Sprite whiteSprite;
	public Sprite darkSprite;
	public Sprite goldenSprite;
    public int goldLife = 2;
    public static int life;
    public static int score;
	public bool isGood = false;
	public bool isBad = false;
	public bool isGolden = false;
	public AudioClip[] sounds;
	Animator anim;
	public AudioSource audio;

	//inicializaçao das variaveis
    void Start () {
	
		audio = GetComponent<AudioSource> ();
		anim = this.GetComponent<Animator>();
		this.anim.enabled = false;
        life = 3;
        score = 0;

    }

 	//logica do jogo em tempo real
    void FixedUpdate() {


		if (this.gameObject.transform.position.y >= 6f) {
			this.anim.enabled = false;
		}

		//dando velocidade as nozes, caso seja diferente da tag goodstatic
        if(gameObject.tag != "GoodStatic" )
            transform.Translate(Vector2.down * Time.deltaTime * speed);

		//checando se saiu da tela
        if ((transform.position.y < -5.5f))
        {
			//diminuindo a vida, caso seja uma noz boa
            if(gameObject.tag == "GoodFall") {
                life--;
            }

			//levando a noz pra uma posiçao randomica em cima da tela
            transform.position = new Vector2(transform.position.x, Random.Range(7f, 8f));

			//Se for uma noz dourada, da duas vidas pra noz dourada e inicializa numa posiçao aleatoria acima da tela
            if ((gameObject.tag == "GoldFall"))
            {
                goldLife = 2;
				gameObject.GetComponent<SpriteRenderer>().sprite = goldenSprite;	
                transform.position = new Vector2(transform.position.x, Random.Range(7f, 8f));
            }
            
        }

     }


	//Ao clicar
    void OnMouseDown() {

		//Se tiver a tag BadFall, tira um ponto e inicializa numa posiçao aleatoria acima da tela
        if (this.gameObject.tag == "BadFall") {
			this.anim.enabled = true;
			anim.Play("DarkNoz");
			score--;
			StartCoroutine(DelayBad());
			gameObject.tag = "GoodStatic";
			audio.PlayOneShot(sounds[1], 0.3f);
        }

		//Se tiver a tag GoodFall, acrescenta um ponto e inicializa numa posiçao aleatoria acima da tela
		if (this.gameObject.tag == "GoodFall")
        {
			this.anim.enabled = true;
			anim.Play("Noz");
			score++;
			StartCoroutine(DelayGood());
			gameObject.tag = "GoodStatic";
			audio.PlayOneShot(sounds[0], 0.2f);
        }

		//Se tiver a tag GoldenFall, tira uma vida da noz
        if (this.gameObject.tag == "GoldFall")
        {
            goldLife--;
			//Se a noz tiver uma vida, muda a sprite
            if (goldLife == 1)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = brokenSprite;
				audio.PlayOneShot(sounds[2], 0.3f);
            }

			//Se nao tiver vidas, muda a tag, sprite, da duas vidas a noz, da dois pontos e inicializa aleatoriamente acima da tela
            else if (goldLife == 0)
            {
				this.anim.enabled = true;
				anim.Play("GoldenNoz");
				score += 2;
				StartCoroutine(DelayGolden());
                gameObject.tag = "GoodStatic";
				audio.PlayOneShot(sounds[3], 0.3f);
            }    
        }

    }


	IEnumerator DelayGood(){
		yield return new WaitForSeconds (.3f);
		anim.Stop ();
		this.gameObject.transform.position = new Vector2 (transform.position.x, Random.Range (7f, 8f));
	}

	//Espera .15s e leva a noz ruim la pra cima
	IEnumerator DelayBad(){
		yield return new WaitForSeconds (.3f);
		anim.Stop ();
		this.gameObject.transform.position = new Vector2(transform.position.x, Random.Range(7f, 8f));
	}

	//Espera .15s e leva a noz dourada la pra cima
	IEnumerator DelayGolden(){
		yield return new WaitForSeconds (.3f);
		anim.Stop ();
		transform.position = new Vector2(transform.position.x, Random.Range(7f, 8f));
		goldLife = 2;
		gameObject.GetComponent<SpriteRenderer>().sprite = goldenSprite;	
	}
	
}
