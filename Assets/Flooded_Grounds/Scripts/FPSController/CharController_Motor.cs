using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharController_Motor : MonoBehaviour {

	public float speed = 10.0f;
	public float sensitivity = 30.0f;
	public float WaterHeight = 15.5f;
	CharacterController character;
	public GameObject cam;
	public GameObject cam2;
	public GameObject cam3;
	public Canvas Wfilter;
	 [SerializeField]
    private Slider energyValue;
	float moveFB, moveLR;
	float rotX, rotY;
	public bool webGLRightClickRotation = true;
	float gravity = -9.8f;
	private GameObject selectedCam;


	void Start(){
		Messenger.AddListener(GameEvent.START_PAGE, resetCam);
		Messenger.AddListener(GameEvent.RESET_GAME, restartCam);
		Messenger.AddListener(GameEvent.GAME_OVER, resetCam);
		Messenger.AddListener(GameEvent.GAME_WIN, resetCam);
		Messenger.AddListener(GameEvent.NO_MORE_ENERGY,backToGhostD);
		//LockCursor ();
		character = GetComponent<CharacterController> ();
		selectedCam = cam;
		if (Application.isEditor) {
			webGLRightClickRotation = false;
			sensitivity = sensitivity * 1.5f;
		}
	}

	void changeCamera(){
		if(selectedCam==cam){
			
			selectedCam=cam2;
		}else if(selectedCam==cam2){
		
			selectedCam=cam3;

		}else{
		
			selectedCam=cam;
		}
	}

	void resetCam(){
		selectedCam.SetActive(false);
		selectedCam = cam;
		selectedCam.SetActive(false);
	}
	void restartCam(){
		resetCam();
		selectedCam.SetActive(true);
	}


	void CheckForWaterHeight(){
		if (transform.position.y < WaterHeight) {
			gravity = 0f;			
		} else {
			gravity = -9.8f;
		}
	}
	void backToGhostD(){
		    Image image = Wfilter.GetComponent<Image>();
			Color color = image.color;
			color.a = 0.392f;
			image.color = color;
	
			
	}


	void changeFilterLevel(){
		Image image = Wfilter.GetComponent<Image>();
		Color color = image.color;
		//Debug.Log(color.a);
		if(color.a<=0.0f){
					
				color.a =0.392f;
		}else{
				color.a = 0.0f;
				//Debug.Log(color.a);
				
		}	
		image.color = color;	

	}


	





	void Update(){
		if (Input.GetKeyDown(KeyCode.C))
		{
			
			selectedCam.SetActive(false);
			changeCamera();
			selectedCam.SetActive(true);

		}
		if (Input.GetKeyDown(KeyCode.E) && energyValue.value > 0.0f)
		{



			changeFilterLevel();
			Messenger.Broadcast(GameEvent.START_STOP_DECRASE, MessengerMode.DONT_REQUIRE_LISTENER);
		}
		
	

		moveFB = Input.GetAxis ("Horizontal") * speed;
		moveLR = Input.GetAxis ("Vertical") * speed;
		rotX = Input.GetAxis ("Mouse X") * sensitivity;
		rotY = Input.GetAxis ("Mouse Y") * sensitivity;

		//rotX = Input.GetKey (KeyCode.Joystick1Button4);
		//rotY = Input.GetKey (KeyCode.Joystick1Button5);

		CheckForWaterHeight ();


		Vector3 movement = new Vector3 (moveFB, gravity, moveLR);



		if (webGLRightClickRotation) {
			if (Input.GetKey (KeyCode.Mouse0)) {
				CameraRotation (selectedCam, rotX, rotY);
			}
		} else if (!webGLRightClickRotation) {
			CameraRotation (selectedCam, rotX, rotY);
		}

		movement = transform.rotation * movement;
		character.Move (movement * Time.deltaTime);
	}


	void CameraRotation(GameObject cam, float rotX, float rotY){		
		transform.Rotate (0, rotX * Time.deltaTime, 0);
		cam.transform.Rotate (-rotY * Time.deltaTime, 0, 0);
	}




}
