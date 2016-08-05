using UnityEngine;
using System;

public class Restart : MonoBehaviour  {

    [SerializeField] private PlayerController jogador;

    public void RestartGame() {
		if (jogador != true)
        {
            Application.LoadLevel(0);
        }

    }
}
