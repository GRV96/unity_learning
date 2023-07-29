using UnityEngine;

public class GameStatus: MonoBehaviour {
	private int _enemiesEscaped;
	public int EnemiesEscaped {
		get { return _enemiesEscaped; }
		set { _enemiesEscaped = value; }
	}

	private int _enemiesKilled;
	public int EnemiesKilled {
		get { return _enemiesKilled; }
		set { _enemiesKilled = value; }
	}

	private bool _playerIsAlive;
	public bool PlayerIsAlive {
		get { return _playerIsAlive; }
		set { _playerIsAlive = value; }
	}

	void Start() {
		Reset();
	}

	void Reset() {
		_enemiesEscaped = 0;
		_enemiesKilled = 0;
		_playerIsAlive = true;
	}
}
