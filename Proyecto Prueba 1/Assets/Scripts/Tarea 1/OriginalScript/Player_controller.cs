using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
	private CharacterController PlayerController;
	private SpriteRenderer PlayerRenderer;
	public Animator PlayerAnimator;
	float GravityForce = 10.5f;
	float JumpForce;
	float BackstepForce = 15f;
	//	float JumpMaxForce = 10f;
	float PlayerSpeed = .19f;
	public float AttackRange = .5f;
	public Transform AttackPoint;
	public LayerMask EnemyLayers;
	private Vector3 moveDirection;
	
	bool isJumping;
	bool isBackStepping;
	//bool grounded;

	
	/*	private Coroutine corJump;
	
	private IEnumerator CorJump()
	{
		float distanceJumped = 0;
		
		while(distanceJumped < JumpMaxForce)
		{
			//Debug.Log("enter");
			distanceJumped += JumpForce;
			yield return new WaitForSeconds(0.1f);
			moveDirection += new Vector3 ( 0, JumpForce, 0 );
			Debug.Log(JumpForce);
		}
	}*/
	// Awake se ejecuta cuando se empieza a cargar la instancia
	void Awake()
	{

		Prepare();

	}
	//Update se checa cada frame
	void Update()
	{

		
		CheckInput();
		CheckHits();
		ApplyGravity();
		Movement();
	}
	
	void Movement()
	{
		Move (moveDirection);
	}
	
	void CheckInput()
	{
		// si el axis horizontal es mayor a 0 mueve al jugador hacia la derecha
		if (Input.GetAxis("Horizontal") > 0)
		{
			moveDirection = new Vector3 (PlayerSpeed, 0 , 0);
			//Move (new Vector3 (PlayerSpeed, 0 , 0));
			PlayerRenderer.flipX = false;
		}
		
		// si el axis horizontal es menor a 0 mueve al jugador hacia la izquierda
		if (Input.GetAxis("Horizontal") < 0)
		{
			moveDirection = new Vector3 (-PlayerSpeed, 0 , 0);
			//Move(new Vector3 (-PlayerSpeed , 0, 0 ));
			PlayerRenderer.flipX = true;
		}
		
		if (Input.GetAxis("Horizontal") == 0)
		{
			moveDirection = Vector3.zero;
			//Move(new Vector3 (-PlayerSpeed , 0, 0 ));
		}
		
		if (Input.GetButton ("Jump"))
		{
			//Debug.Log("PressedJump");
			Jump();
		}
		
		if (Input.GetButton ("Fire1"))
		{
			Attack();
		}
		
		/*if (Input.GetMouseButtonUp("Fire1"))
		{
			PlayerAnimator.SetTrigger("Stop");
			
		}*/
		
		if (Input.GetKeyDown(KeyCode.Q))
		{
			Backstep();
		}
	}
	

	void Jump()
	{		
		if (PlayerController.isGrounded)
		{
			isJumping = true;
			Move( new Vector3 ( 0, 1 * (Time.fixedDeltaTime), 0 ));
			
			
			/*	if(corJump != null)
			{
				StopCoroutine(corJump);
			}
			corJump = StartCoroutine(CorJump ());
		Debug.Log("Jumping");
			*/
		}
		
	}
	
	void Backstep()
	{
		if (PlayerController.isGrounded)
		{
			isBackStepping = true;
			Move( new Vector3 ( -6, 1 * (Time.fixedDeltaTime), 0 ));
		}
		//PlayerAnimator.SetTrigger("Backstep");
	}
	
	void Block()
	{
		//PlayerAnimator.SetTrigger("Block");
		//	Debug.Log("Blocking!");
		
	}
	
	void BlockHigh()
	{
		//PlayerAnimator.SetTrigger("Block_High");
		//	Debug.Log("High Block!");
		
	}
	
	void ApplyGravity()
	{	//aplica una fuerza constante hacia abajo
		moveDirection += new Vector3(0, -GravityForce * (Time.fixedDeltaTime * .5f), 0);
		
		RaycastHit hit; 
		if(Physics.Raycast (transform.position, Vector3.down, out hit))
		{
			float dis = Vector3.Distance(transform.position, hit.point);
			if( dis <= .78f)
			{
				//grounded = true;
			}else
			{
				//	grounded = false;
			}
		}
		
			
		if(PlayerController.isGrounded)
		{
			//	grounded = false;
			JumpForce = 1f;
			isBackStepping = false;
		}
		
		if(isJumping)
		{
			Move( new Vector3 ( 0, JumpForce -=  (Time.fixedDeltaTime), 0 ));
		}
		
		if(isBackStepping)
		{
			if (PlayerRenderer.flipX == true)
			{
				Move( new Vector3 ( BackstepForce,0, 0 ));
			} else
			{
				Move( new Vector3 ( -BackstepForce, 0, 0 ));
			}
			//Move( new Vector3 ( BackstepDistance, JumpForce -=  (Time.fixedDeltaTime), 0 ));*/
		}

	}
	
	void Attack()
	{
		PlayerAnimator.Play("Player_Attack");
	}
	
	void CheckHits()
	{
		Collider2D[] HitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, EnemyLayers);
		
		foreach (Collider2D Enemy in HitEnemies)
		{

		}
		
	}
	
	void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
		if (AttackPoint == null	)
		{
			return;
		}
		
	}
		
	public void	 Move(Vector3 direction)
	{
		PlayerController.Move(direction * PlayerSpeed);
	}
	
	
	void Prepare()
	{	//checa si el controlador de personaje es nulo
		if (PlayerController == null)
		{
			try 
			{	//si lo es 
				PlayerController = GetComponent<CharacterController>();
			}catch{
					Debug.LogError ("No se encontró PlayerController en la instancia");
				  }	
		} 
		
		if (PlayerRenderer == null)
		{
			try {
				PlayerRenderer = GetComponent<SpriteRenderer>();
			}catch
			{
				Debug.LogError	("No se encontró sprite renderer en la instancia");
			}
		}
	}
}
