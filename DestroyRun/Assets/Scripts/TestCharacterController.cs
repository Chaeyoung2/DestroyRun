using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 50f;
    [SerializeField] private float jumpPower = 20f;
    [SerializeField] private float dashPower = 1.5f;
    public SpawnManager spawnManager;

    public bool jump = false;
    public bool run = false;
    public bool dash = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnerTriggerEntered();
    }

    void Move()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
        if(hMovement != 0 || vMovement != 0)
        {
            run = true;
        }
        else
        {
            run = false;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            dash = true;
        }
        else
        {
            dash = false;
        }

        if (jump && dash)
            transform.Translate(new Vector3(hMovement , jumpPower, vMovement * dashPower) * Time.deltaTime);
        else if (jump && !dash)
            transform.Translate(new Vector3(hMovement, jumpPower, vMovement) * Time.deltaTime);
        else if (!jump && dash)
            transform.Translate(new Vector3(hMovement, 0, vMovement * dashPower) * Time.deltaTime);
        else
            transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);

       
    }
}
