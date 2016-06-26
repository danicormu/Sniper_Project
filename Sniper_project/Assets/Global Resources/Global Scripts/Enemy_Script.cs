using UnityEngine;
using System.Collections;

public class Enemy_Script : MonoBehaviour {

	static Animator anim;
	public int maxHealth = 10;

	public int currentHealth;
	public float chaseRange = 0.0f;
	public float attackRange = 0.0f;
	public float attackCD = 0.0f;
	private float attackCDLeft;

	AudioSource playerAudio;
	public AudioClip deathClip;

	private GameObject playerToKill; 
	player playerHealth;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		currentHealth = maxHealth;
		playerToKill = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = playerToKill.GetComponent<player> ();
		playerAudio = GetComponent<AudioSource> ();
		}

	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (playerToKill.transform.position, this.transform.position) <= 60) {
			Vector3 direction = playerToKill.transform.position - this.transform.position;
			direction.y = 0;
			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);
			if (direction.magnitude > 40) {
				this.transform.Translate (0, 0, 0.05f);
				anim.SetBool ("Walk", true);
			} else {
				anim.SetTrigger ("Shoot");
				anim.SetBool ("Walk", false);
				attack ();
			}
		}else {
			anim.SetTrigger ("PlayerDead");
			anim.SetBool ("Walk", false);
		}

		if (attackCDLeft > 0.0f)
			attackCDLeft -= Time.deltaTime;

	}

	public void loseHealth(int damage){
		if(currentHealth > 0){
			currentHealth -= damage;
			playerAudio.Play ();
		}if (currentHealth == 0) {
			Die ();
		}
	}

	public void attack(){
		if(attackCDLeft <= 0.0f){
			playerHealth.loseHealth (1);
			attackCDLeft = attackCD;
		}
	}

	void Die(){
		anim.SetTrigger ("Dead");
		playerAudio.clip = deathClip;
		playerAudio.Play (); 
		Destroy (this.gameObject, 5.0f);
		}




}

