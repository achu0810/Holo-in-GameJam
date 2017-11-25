using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class AllyAttack : MonoBehaviour {

	public float attackDistance;
	[SerializeField]private GameObject enemyObject;
	private float funcResult;

	void Start () {

		// 1番近い敵を探す
		this.UpdateAsObservable ()
			.Subscribe (x => SearchEnemies());

		// Enemyが攻撃範囲にいれば攻撃
		this.UpdateAsObservable ()
			.Where (x => enemyObject != null)
			.Do (x => funcResult = AttackDistance())
			.Where (x => funcResult <= attackDistance)
			.Subscribe (x => {
				Debug.Log("test");
		});

	}

	float AttackDistance() {
		float result;
		result = Vector3.Distance (this.transform.position, enemyObject.transform.position);
		return result;
	}

	void SearchEnemies() {
		GameObject[] enemies;
		float minDistance = float.MaxValue;
		float tmpDistance;
		enemies = GameObject.FindGameObjectsWithTag("Enemy") as GameObject[];
		foreach(GameObject enemy in enemies) {
			tmpDistance = Vector3.Distance(this.transform.position, enemy.transform.position);
			if(tmpDistance < minDistance) {
				minDistance = tmpDistance;
				enemyObject = enemy.gameObject;
			}
		}
	}

}
