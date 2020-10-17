using UnityEngine;
using System.Collections;

public class Shootables : MonoBehaviour {
	public int maxHealth = 3;
	public int currentHealth;

	//public HealthBar healthBar;

	private void Start()
	{
		currentHealth = maxHealth;
		//healthBar.SetMaxHealth(maxHealth);
	}

	public void Damage(int damageAmount)
	{

		currentHealth -= damageAmount;

		if (currentHealth <= 0)
		{
			gameObject.SetActive(false);
		}

	}
	void TakeDamage(int damage)
	{
		currentHealth -= damage;
        //healthBar.SetHealth(currentHealth);
	}
}

