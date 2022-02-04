using System.Collections;
using UnityEngine;

public class LaptopOpen : MonoBehaviour
{
	[SerializeField] public Animator _LaptopOpen;
	public bool _isOpened;
	public Transform Player;
	public GameObject LaptopCamera;
	public GameObject PlayerCamera;
	

	void Start()
	{
		_isOpened = false;
		
	}

	void OnMouseOver()
	{
		{
			if (Player)
			{
				float dist = Vector3.Distance(Player.position, transform.position);
				if (dist < 3)
				{
					if (_isOpened == false)
					{
						if (Input.GetKeyDown(KeyCode.E))
						{
							StartCoroutine(opening());
							
							
						}
					}
					else
					{
						if (_isOpened == true)
						{
							if (Input.GetKeyDown(KeyCode.E))
							{
								StartCoroutine(closing());
								
							}
						}

					}

				}
			}

		}

	}

	IEnumerator opening()
	{
		print("you are opening the laptop");
		_LaptopOpen.Play("OpenLaptop");
		LaptopCamera.SetActive(true); 
		PlayerCamera.SetActive(false);
		Cursor.lockState = CursorLockMode.None;
		_isOpened = true;
		yield return new WaitForSeconds(.5f);
	}

	IEnumerator closing()
	{
		print("you are closing the laptop");
		_LaptopOpen.Play("CloseLaptop");
		PlayerCamera.SetActive(true); 
		LaptopCamera. SetActive(false);
		Cursor.lockState = CursorLockMode.Locked;
		_isOpened = false;
		yield return new WaitForSeconds(.5f);
	}

}

