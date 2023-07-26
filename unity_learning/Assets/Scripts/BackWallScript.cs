using System;
using UnityEngine;

public class BackWallScript: MonoBehaviour {
	private const float SPAWN_TIME_INTERVAL = 1.5f; // seconds

	private int _nbSpawnPoints;
	private float _timer; // seconds
	private System.Random _randomizer;

	// Where the enemies will spawn
	private Vector3[] _spawnPoints = null;

	private System.Type EnemyScript =
			System.Type.GetType("EnemyScript,Assembly-CSharp");

	private void InitSpawnPoints(float pYCoord, float pZCoord) {
		float width = transform.localScale.x;
		int nbIntervals = _nbSpawnPoints + 1;
		float intervalWidth = width / nbIntervals;
		float firstSpawnX = -width/2 + intervalWidth;

		_spawnPoints = new Vector3[_nbSpawnPoints];
		_spawnPoints[0] = new Vector3(firstSpawnX, pYCoord, pZCoord);
		for(int i=1; i<_nbSpawnPoints; i++) {
			float xCoord = firstSpawnX + i * intervalWidth;
			_spawnPoints[i] = new Vector3(xCoord, pYCoord, pZCoord);
		}
	}

	private void SpawnEnemy() {
		int spawnPointIndex = _randomizer.Next(_nbSpawnPoints);
		GameObject enemy =
			GameObject.CreatePrimitive(PrimitiveType.Capsule);
		enemy.transform.position = _spawnPoints[spawnPointIndex];
		enemy.AddComponent(EnemyScript);
	}

	void Start() {
		_nbSpawnPoints = 4;
		_timer = 0;
		_randomizer = new System.Random();
		float zCoord = transform.position.z - transform.localScale.z/2 - 0.7f;
		print(zCoord);
		InitSpawnPoints(1.2f, zCoord);
	}

	void Update() {
		_timer += Time.deltaTime;

		if(_timer >= SPAWN_TIME_INTERVAL) {
			_timer = 0;
			SpawnEnemy();
		}
	}
}
