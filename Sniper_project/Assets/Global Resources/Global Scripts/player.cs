using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player : MonoBehaviour {

	public float attackRange = 0.0f;
	public float attackCD = 0.0f;
	public int maxHealth = 0;
	public int currentHealth;
	public float attackCDLeft;
	AudioSource playerAudio;
	bool isDamaged;
	bool isDeath;
    public GameObject GameOverMenu;
    public GameObject GameOverScene;
    public Camera GameOverCamera;
	public Slider healthSlider;
	public Image damageImage;
	public float flashSpeed = 5f;
	public Color flashColor = new Color (1f, 0f, 0f, 0.1f);


	public AudioClip deathClip;
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		playerAudio = GetComponent<AudioSource> ();
		attackCDLeft = attackCD;
        GameOverMenu.SetActive(false);
        GameOverScene.SetActive(false);
		}

	// Update is called once per frame
	void Update () {
		    //isDead ();

		if (isDamaged && !isDeath) {
			damageImage.color = flashColor;
		} else {
			damageImage.color = Color.Lerp (damageImage.color , Color.clear, flashSpeed * Time.deltaTime);
		}

		isDamaged = false;
		isDeath = false;

		attackEnemy ();
	}		


	public void attackEnemy(){
		if (attackCDLeft > 0.0f)
			attackCDLeft -= Time.deltaTime;

		if (Input.GetMouseButtonDown (0)) {	
			if (getNearEnemy () != null) {
				if (Vector3.Distance (transform.position, getNearEnemy ().transform.position) <= attackRange) {
						//killEnemy ();
						attackCDLeft = attackCD;	
				}
			}
		}	
	}

	GameObject getNearEnemy(){
		GameObject nearest = null;
		foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy")){
			if(nearest == null || Vector3.Distance(transform.position, enemy.transform.position) < Vector3.Distance(transform.position, nearest.transform.position)){
				nearest = enemy;
			}
		}
		return nearest;
	}

    public void loseHealth(int damage)
    {
        isDamaged = true;
        playerAudio.Play();
        currentHealth -= damage;
        healthSlider.value = currentHealth;
        if (currentHealth <= 0f)
            isDead();

        
    }

    //void killEnemy(){
    //    if(attackCDLeft <= 2.5f){
    //        getNearEnemy ().GetComponent<EnemyAttack> ().loseHealth(5);
    //    }

    //}

	void isDead(){
		
        isDeath = true;
		playerAudio.clip = deathClip;
		playerAudio.Play ();
        Destroy (this.gameObject);
        GameOverScene.SetActive(true);
        GameOverCamera =Camera.main;
        GameOverMenu.SetActive(true);
        MouseLock.MouseLocked = false;
	}
		
}
