<<<<<<< HEAD
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Com base neste Script - vamos melhorar nosso carro e deixa-lo mais tunano 😜


//CRIAR UM JIP E UM CAMINHÃO.😱 
=======
using UnityEngine;
using UnityEngine.UI;
>>>>>>> ef67e72 (Adicionado Metralhadoras e  Menu do jogo)

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentSteerAngle;
<<<<<<< HEAD
    private float currentBreakForce;
    private bool isBreaking;
    private bool LightsOn = false;


    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRighttWheelCollider;
    [SerializeField] private WheelCollider RearLeftWheelCollider;
    [SerializeField] private WheelCollider RearRightWheelCollider;
    [SerializeField] private Light headlightLeft;
    [SerializeField] private Light headlightRight;


    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRighttWheelTransform;
    [SerializeField] private Transform RearLeftWheelTransformr;
    [SerializeField] private Transform RearRightWheelTransform;


    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteeringAngle;

=======
    private float currentBrakeForce;
    private bool isBraking;
    private bool lightsOn = false;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;
    [SerializeField] private Light headlightLeft;
    [SerializeField] private Light headlightRight;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;

    [SerializeField] private float motorForce;
    [SerializeField] private float brakeForce;
    [SerializeField] private float maxSteeringAngle;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletSpeed = 20f;
    [SerializeField] private Text scoreText;
    private int score = 0;

>>>>>>> ef67e72 (Adicionado Metralhadoras e  Menu do jogo)
    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
<<<<<<< HEAD
        RestartPosition();
        LuzToggle();
 
    }

    private void RestartPosition()
    {
        if (Input.GetKey("r"))
        {
            Debug.Log("RestartPosition");
            transform.position = new Vector3(3f, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    private void LuzToggle()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {

            LightsOn = !LightsOn;

            headlightLeft.enabled = LightsOn;
            headlightRight.enabled = LightsOn;
=======
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shoot();
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartPosition();
        }
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            ToggleLights();
>>>>>>> ef67e72 (Adicionado Metralhadoras e  Menu do jogo)
        }
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
<<<<<<< HEAD
        isBreaking = Input.GetKey(KeyCode.Space);
=======
        isBraking = Input.GetKey(KeyCode.Space);
>>>>>>> ef67e72 (Adicionado Metralhadoras e  Menu do jogo)
    }

    private void HandleMotor()
    {
<<<<<<< HEAD
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRighttWheelCollider.motorTorque = verticalInput * motorForce;
        RearLeftWheelCollider.motorTorque = verticalInput * motorForce;
        RearRightWheelCollider.motorTorque = verticalInput * motorForce;
        currentBreakForce = isBreaking ? breakForce : 0f;
        ApplyBreaking();
    }

    private void ApplyBreaking()
    {
        frontRighttWheelCollider.brakeTorque = currentBreakForce;
        frontLeftWheelCollider.brakeTorque = currentBreakForce;
        RearLeftWheelCollider.brakeTorque = currentBreakForce;
        RearRightWheelCollider.brakeTorque = currentBreakForce;
=======
        float torque = verticalInput * motorForce;
        frontLeftWheelCollider.motorTorque = torque;
        frontRightWheelCollider.motorTorque = torque;
        rearLeftWheelCollider.motorTorque = torque;
        rearRightWheelCollider.motorTorque = torque;

        currentBrakeForce = isBraking ? brakeForce : 0f;
        ApplyBraking();
    }

    private void ApplyBraking()
    {
        frontLeftWheelCollider.brakeTorque = currentBrakeForce;
        frontRightWheelCollider.brakeTorque = currentBrakeForce;
        rearLeftWheelCollider.brakeTorque = currentBrakeForce;
        rearRightWheelCollider.brakeTorque = currentBrakeForce;
>>>>>>> ef67e72 (Adicionado Metralhadoras e  Menu do jogo)
    }

    private void HandleSteering()
    {
        currentSteerAngle = maxSteeringAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = currentSteerAngle;
<<<<<<< HEAD
        frontRighttWheelCollider.steerAngle = currentSteerAngle;
=======
        frontRightWheelCollider.steerAngle = currentSteerAngle;
>>>>>>> ef67e72 (Adicionado Metralhadoras e  Menu do jogo)
    }

    private void UpdateWheels()
    {
<<<<<<< HEAD
        UpdateSingleWheelCollider(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheelCollider(frontRighttWheelCollider, frontRighttWheelTransform);
        UpdateSingleWheelCollider(RearRightWheelCollider, RearRightWheelTransform);
        UpdateSingleWheelCollider(RearLeftWheelCollider, RearLeftWheelTransformr);

    }

    private void UpdateSingleWheelCollider(WheelCollider wheelCollider, Transform wheelTransform)
=======
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
>>>>>>> ef67e72 (Adicionado Metralhadoras e  Menu do jogo)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }

<<<<<<< HEAD
}
=======
    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();

        if (bulletRb != null)
        {
            bulletRb.linearVelocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }

    private void RestartPosition()
    {
        Debug.Log("Reiniciando Posição");
        transform.position = new Vector3(3f, transform.position.y, transform.position.z);
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    private void ToggleLights()
    {
        lightsOn = !lightsOn;
        headlightLeft.enabled = lightsOn;
        headlightRight.enabled = lightsOn;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Pontos: " + score;
    }
}
>>>>>>> ef67e72 (Adicionado Metralhadoras e  Menu do jogo)
