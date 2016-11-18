using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour 
{

	public int enemyMaxHealth;
	public int enemyCurrentHealth;
	private PlayerStats thePlayerStats;

	public int expToGive;

	public string enemyQuestName;
	private QuestManager theQM;
	private SFXManager sfxMan;

	// Use this for initialization
	void Start () 
	{

		enemyCurrentHealth = enemyMaxHealth;

		thePlayerStats = FindObjectOfType<PlayerStats>();
		theQM = FindObjectOfType<QuestManager> ();
		sfxMan = FindObjectOfType<SFXManager> ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (enemyCurrentHealth <= 0) 
		{
			theQM.enemyKilled = enemyQuestName;

			Destroy (gameObject);

			thePlayerStats.AddExperience (expToGive);
		}

	}

	public void HurtEnemy(int damageToGive)
	{
		enemyCurrentHealth -= damageToGive;
		sfxMan.slimeHurt.Play ();

	}

	public void SetMaxHealth()
	{
		enemyCurrentHealth = enemyMaxHealth;

	}
}
