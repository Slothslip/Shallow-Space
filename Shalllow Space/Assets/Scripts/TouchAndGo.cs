using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAndGo : MonoBehaviour {

	public GameObject bulletPrefab;
	public GameObject LazerPrefab; // bullet one 
	public float reloadTime = 0.1f;
	float elapsedTime = 0f;
	public int WeaponType = 0;

	[SerializeField]
	float moveSpeed = 5f;

	Rigidbody2D rb;

	Touch touch;
	Vector3 touchPosition, whereToMove;
	bool isMoving = false;

	float previousDistanceToTouchPos, currentDistanceToTouchPos;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		WeaponType = 0;
	}
	
	void Update () {
		elapsedTime += Time.deltaTime;
		


		if (isMoving)
			currentDistanceToTouchPos = (touchPosition - transform.position).magnitude;
		
		if (Input.touchCount > 0) {
			touch = Input.GetTouch (0);

			if (touch.phase == TouchPhase.Began) {
					previousDistanceToTouchPos = 0;
					currentDistanceToTouchPos = 0;
					isMoving = true;
					touchPosition = Camera.main.ScreenToWorldPoint (touch.position);
					touchPosition.z = 0;
					whereToMove = (touchPosition - transform.position).normalized;
					rb.velocity = new Vector2 (whereToMove.x * moveSpeed, whereToMove.y * moveSpeed);
				if (elapsedTime > reloadTime && WeaponType == 0)
				{
					Vector3 spawnPos = transform.position;
					spawnPos += new Vector3(1.6f, -.4f, 0);
					Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

					elapsedTime = 0f;
				}
				else if (elapsedTime > reloadTime && WeaponType == 1)
                {
					Vector3 spawnPos = transform.position;
					spawnPos += new Vector3(1.6f, -.4f, 0);
					Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

					Vector3 spawnPosT = transform.position;
					spawnPosT += new Vector3(2f, 0f, 0);
					Instantiate(bulletPrefab, spawnPosT, Quaternion.identity);

					elapsedTime = 0f;
				}
				else if (elapsedTime > reloadTime && WeaponType == 2)
				{
					Vector3 spawnPos = transform.position;
					spawnPos += new Vector3(1.6f, -.4f, 0);
					Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

					Vector3 spawnPosT = transform.position;
					spawnPosT += new Vector3(2f, 0f, 0);
					Instantiate(bulletPrefab, spawnPosT, Quaternion.identity);

					Vector3 spawnPosTT = transform.position;
					spawnPosTT += new Vector3(2f, -.8f, 0);
					Instantiate(bulletPrefab, spawnPosTT, Quaternion.identity);

					elapsedTime = 0f;
					reloadTime = 0.3f;
				}
				else if (elapsedTime > reloadTime && WeaponType == 3)
				{
					Vector3 spawnPos = transform.position;
					spawnPos += new Vector3(5f, -.4f, 0);
					Instantiate(LazerPrefab, spawnPos, Quaternion.identity);

					reloadTime = 0.1f;
					elapsedTime = 0f;
				}
			}
			
		}

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (WeaponType == 0)
			{
				WeaponType = 1;
			}
			else if (WeaponType == 1)
			{
				WeaponType = 2;
			}
			else if (WeaponType == 2)
			{
				WeaponType = 3;
			}
			else if (WeaponType == 3)
			{
				WeaponType = 0;
			}
		}

		if (currentDistanceToTouchPos > previousDistanceToTouchPos) {
			isMoving = false;
			rb.velocity = Vector2.zero;

		}

		if (isMoving)
			previousDistanceToTouchPos = (touchPosition - transform.position).magnitude;

	}
}
