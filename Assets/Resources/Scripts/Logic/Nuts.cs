using UnityEngine;
using System.Collections;

public class Nuts : MonoBehaviour {

    //Declaraçao das variaveis
    public static float speed;
    public int goldLife = 2;
    public static int life;
    public static int score;
	public AudioClip[] sounds;
	Animator anim;
	public AudioSource audio;
    bool mayFall;
    public static bool tagORight;
    string[] tags = new string[4] {"GoodFall", "BadFall", "GoldFall", "GoodFall" }
;

	//inicializaçao das variaveis
    void Start () {
        mayFall = false;
		audio = GetComponent<AudioSource> ();
		anim = this.GetComponent<Animator>();
        anim.SetInteger ("clicked", 0);
        anim.SetBool ("isGood", false);
        anim.SetBool ("isGolden", false);
        anim.SetBool ("isBad", false);
        life = 3;
        score = 0;
    }

 	//logica do jogo em tempo real
    void FixedUpdate() {

        if (this.gameObject.tag == "GoodStatic") {
            mayFall = false;
            anim.SetInteger ("clicked", 0);
            anim.SetBool ("isGood", false);
            anim.SetBool ("isGolden", false);
            anim.SetBool ("isBad", false);
            tagORight = true;
        }

        if (transform.position.y >= 6.5f) { 

            if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Noz") || anim.GetCurrentAnimatorStateInfo (0).IsName ("DarkNoz") || anim.GetCurrentAnimatorStateInfo (0).IsName ("IdleGoldRachada") || anim.GetCurrentAnimatorStateInfo (0).IsName ("GoldenNoz")) {
                this.gameObject.tag = "GoodStatic";
                transform.position = new Vector2 (transform.position.x, Random.Range (7.5f, 8f));

            }

            if (this.gameObject.tag == "GoodFall") {
                anim.SetBool ("isGood", true);
                anim.SetInteger ("clicked", 0);
                anim.SetBool ("isGolden", false);
                anim.SetBool ("isBad", false);
            }

            else if (this.gameObject.tag == "BadFall") {
                anim.SetBool ("isBad", true);
                anim.SetInteger ("clicked", 0);
                anim.SetBool ("isGood", false);
                anim.SetBool ("isGolden", false);
            }

            else if (this.gameObject.tag == "GoldFall") {
                anim.SetBool ("isGolden", true);
                anim.SetInteger ("clicked", 0);
                anim.SetBool ("isGood", false);
                anim.SetBool ("isBad", false);


            }
            
            mayFall = true;
        }


        if (this.gameObject.tag != "GoodStatic" && mayFall == true) {
            transform.Translate (Vector2.down * Time.deltaTime * speed);
        }

        //checando se saiu da tela
        if ((transform.position.y < -5.5f)) {
            //diminuindo a vida, caso seja uma noz boa
            if (gameObject.tag == "GoodFall") {
                life--;
            }

            //Se for uma noz dourada, da duas vidas pra noz dourada e inicializa numa posiçao aleatoria acima da tela
            if ((gameObject.tag == "GoldFall")) {
                goldLife = 2;
            }
            transform.position = new Vector2 (transform.position.x, Random.Range (7.5f, 8f));

            this.gameObject.tag = tags[Random.Range (0, tags.Length)];

        }

    }


	//Ao clicar
    void OnMouseDown() {

		//Se tiver a tag BadFall, tira um ponto e inicializa numa posiçao aleatoria acima da tela
        if (this.gameObject.tag == "BadFall") {
            anim.SetInteger ("clicked", 1);
            score--;
            mayFall = false;
            StartCoroutine (DelayBad());
			audio.PlayOneShot(sounds[1], 0.3f);
        }

		//Se tiver a tag GoodFall, acrescenta um ponto e inicializa numa posiçao aleatoria acima da tela
		if (this.gameObject.tag == "GoodFall")
        {
            anim.SetInteger ("clicked", 1);
            score++;
            mayFall = false;
            StartCoroutine (DelayGood());
			audio.PlayOneShot(sounds[0], 0.2f);
        }

		//Se tiver a tag GoldenFall, tira uma vida da noz
        if (this.gameObject.tag == "GoldFall")
        {
            goldLife--;
			//Se a noz tiver uma vida, muda a sprite
            if (goldLife == 1)
            {
                anim.SetInteger ("clicked", 1);
				audio.PlayOneShot(sounds[2], 0.3f);
            }

			//Se nao tiver vidas, muda a tag, sprite, da duas vidas a noz, da dois pontos e inicializa aleatoriamente acima da tela
            else if (goldLife == 0)
            {
                anim.SetInteger ("clicked", 2);
                score += 2;
                mayFall = false;
                StartCoroutine (DelayGolden());
				audio.PlayOneShot(sounds[3], 0.3f);
            }    
        }

    }


	IEnumerator DelayGood(){
		yield return new WaitForSeconds (.1f);
        this.gameObject.tag = "GoodStatic";
        this.gameObject.transform.position = new Vector2 (transform.position.x, Random.Range (7.5f, 8f));
        yield return new WaitForSeconds (.1f);
    }

	//Espera .15s e leva a noz ruim la pra cima
	IEnumerator DelayBad(){
        yield return new WaitForSeconds (.1f);
        this.gameObject.tag = "GoodStatic";
        this.gameObject.transform.position = new Vector2 (transform.position.x, Random.Range (7.5f, 8f));
        yield return new WaitForSeconds (.1f);
    }

	//Espera .15s e leva a noz dourada la pra cima
	IEnumerator DelayGolden(){
        yield return new WaitForSeconds (.1f);
        goldLife = 2;
        this.gameObject.tag = "GoodStatic";
        this.transform.position = new Vector2 (transform.position.x, Random.Range (7.5f, 8f));
        yield return new WaitForSeconds (.1f);
    }
	
}
