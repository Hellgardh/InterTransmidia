using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedroController_RB : MonoBehaviour
{
	public bool gamepad;

	public float speed = 5f;
	//public float jumpHeight;
	//public float groundDistance = 0.2f;
	//public LayerMask ground;
	//public Transform groundChecker;

	private Rigidbody rb;
	private Vector3 inputs = Vector3.zero;
	// private bool isGrounded = true;
	private Camera cam;
	private float rotationSpeed = 30f;

	private float deadzone = 0.25f;

	//private float fallMultiplier = 1.8f;

	void Awake ()
	{
		rb = GetComponent<Rigidbody>();
		cam = Camera.main;
	}

	void Update ()
	{
		//isGrounded = Physics.CheckSphere(groundChecker.position, groundDistance, ground);

		GetInputs();

		if (inputs != Vector3.zero)
		{
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(inputs), Time.deltaTime * rotationSpeed);
		}

		/*if (Input.GetButtonDown("Jump") || Input.GetButtonDown("Gamepad_LB") && isGrounded)
        {
            //rb.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }*/
	}

	private void FixedUpdate ()
	{
		rb.MovePosition(rb.position + inputs * speed * Time.fixedDeltaTime);
	}

	Vector3 GetInputs ()
	{
		inputs = Vector3.zero;
		/*if (!gamepad)
        {
            inputs.x = Input.GetAxis("PedroHorizontal");
            inputs.z = Input.GetAxis("PedroVertical");
        }

        else
        {
            inputs.x = Input.GetAxis("Gamepad_RStickX");
            inputs.z = Input.GetAxis("Gamepad_RStickY");
        }*/

		inputs = new Vector3(InputManager.P_Horizontal(), 0, InputManager.P_Vertical()); //InputManager: Script próprio de input para usar diferentes "controles" ao mesmo tempo

		inputs.x = InputManager.P_Horizontal();
		inputs.z = InputManager.P_Vertical();

		inputs = cam.transform.TransformDirection(inputs); //Converte as coordenadas de globais para a posição local da câmera
		inputs.y = 0; //Impede que a altura da câmera influencie no movimento

		if (inputs.sqrMagnitude > 1) //Impede que o player ande mais rápido na diagonal
		{
			inputs.Normalize();
		}

		if (inputs.magnitude < deadzone) inputs = Vector3.zero; //Cria uma scaled radial dead zone para o analógico, fazendo com que a dead zone seja gradual
		else inputs = inputs.normalized * ((inputs.magnitude - deadzone) / (1 - deadzone));

		return inputs;
	}

}
