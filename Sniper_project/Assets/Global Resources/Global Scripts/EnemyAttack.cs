using UnityEngine;
using System.Collections;

[RequireComponent(typeof(DamageManager))]
[RequireComponent(typeof(CharacterController))]
public class EnemyAttack : MonoBehaviour {

    public int currentHealth;
    public float GravityMult = 1;
    public float Slip = 10;
    public float speed = 25;
    private float fallvelocity = 0;
    private Vector3 moveDirection;
    public float attackCD = 5f;
    player playerHealth;
    public Transform Myself;
    public float Speed = 3;
    public AudioClip[] footstepSound;
    public Vector3 targetPosition;
    public int timethink = 0;
    public string RunPose = "WalkForward";
    public string IdlePose = "Idle1";
    public string shoot = "ShootStraight";
    public string persuit = "RunForward";
    private GameObject playerToKill; 
    private int state = 0;
    private CharacterController characterController;

    // Esto que sigue es para ver si el enemigo me ataca a mi.
    public Vector3 playerPosition;
    public Vector3 enemyPosition;
    public float coolDown = 5f;

	// Use this for initialization
	void Start () {

        if (Myself == null)
            Myself = this.gameObject.transform;

        characterController = this.GetComponent<CharacterController>();
        Myself.GetComponent<Animation>().PlayQueued(IdlePose);
        playerToKill = GameObject.FindGameObjectWithTag("Player");
        playerHealth = playerToKill.GetComponent<player>();
	}

	
	// Update is called once per frame
	void Update () {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        enemyPosition = this.transform.position;
		if (timethink <= 0) {
			targetPosition = new Vector3 (Random.Range (-200, 200), 0, Random.Range (-200, 200));
			timethink = Random.Range (100, 500);
			state = Random.Range (0, 2);
		} else {
			timethink -= 1;
		}
		
   		isGrounded = GroundChecking ();
		targetPosition.y = transform.position.y;
		Quaternion rotationTarget = Quaternion.LookRotation ((targetPosition - this.transform.position).normalized);
		transform.rotation = Quaternion.Lerp (this.transform.rotation, rotationTarget, Time.deltaTime * 5);
        coolDown -= Time.deltaTime;
        // if que me permite saber si la el player esta cerca o no
        if (Vector3.Distance(enemyPosition, playerPosition) < 60)
        {
            Myself.GetComponent<Animation>().CrossFade(persuit, 0.5f);
            targetPosition = playerPosition;
            rotationTarget = Quaternion.LookRotation((targetPosition - this.transform.position).normalized);
            transform.rotation = Quaternion.Lerp(this.transform.rotation, rotationTarget, Time.deltaTime * 5);
            Vector3 direction = (targetPosition - transform.position).normalized;
            moveDirection = Vector3.Lerp(moveDirection, direction, Time.deltaTime * speed);
            if (Vector3.Distance(enemyPosition, playerPosition) < 30)
            {
                Myself.GetComponent<Animation>().CrossFade(shoot, 0.2f);
                targetPosition = playerPosition;
                rotationTarget = Quaternion.LookRotation((targetPosition - this.transform.position).normalized);
                transform.rotation = Quaternion.Lerp(this.transform.rotation, rotationTarget, Time.deltaTime * 5);
                direction = (targetPosition - transform.position).normalized;
                moveDirection = Vector3.zero;
                if (coolDown <= 0.0f)
                    attack();
            }
        }
        else 
        {
            switch (state)
            {
                case 0:
                    Myself.GetComponent<Animation>().CrossFade(RunPose, 0.3f);
                    Vector3 direction = (targetPosition - transform.position).normalized;
                    moveDirection = Vector3.Lerp(moveDirection, direction, Time.deltaTime * Slip);
                    break;
                case 1:
                    Myself.GetComponent<Animation>().CrossFade(IdlePose, 0.3f);
                    moveDirection = Vector3.zero;
                    break;
            }
        }



		

		moveDirection.y = fallvelocity;
		characterController.Move (moveDirection * Speed * Time.deltaTime);

        if (!isGrounded)
        {
            fallvelocity -= 90 * GravityMult * Time.deltaTime;
        }
        if (coolDown < 0.0f)
            coolDown = 3f;
	}


    public float DistanceToGround = 0.1f;
    bool isGrounded = false;

    public bool GroundChecking()
    {
        if (GetComponent<Collider>())
        {
            RaycastHit hit;
            if (characterController.isGrounded)
                return true;
            if (Physics.Raycast(GetComponent<Collider>().bounds.center, -Vector3.up, out hit, DistanceToGround + 0.1f))
            {
                return true;
            }
        }
        return false;

    }

    public void attack()
    {
        playerHealth.loseHealth(3);
        coolDown = 3f;
    }
}
