using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardia : MonoBehaviour {

	public float Vel = 5;
	public float Espera = .3f;
	public float VelGiro = 90;

	public Transform Camino;

	void Start() {

		Vector3[] Puntos = new Vector3[Camino.childCount];
		for (int i = 0; i < Puntos.Length; i++) {
			Puntos [i] = Camino.GetChild (i).position;
			Puntos [i] = new Vector3 (Puntos [i].x, transform.position.y, Puntos [i].z);
		}

		StartCoroutine (SeguirCamino (Puntos));

	}

	IEnumerator SeguirCamino(Vector3[] Puntos) {
		transform.position = Puntos [0];

		int targetWaypointIndex = 1;
		Vector3 targetWaypoint = Puntos [targetWaypointIndex];
		transform.LookAt (targetWaypoint);

		while (true) {
			transform.position = Vector3.MoveTowards (transform.position, targetWaypoint, Vel * Time.deltaTime);
			if (transform.position == targetWaypoint) {
				targetWaypointIndex = (targetWaypointIndex + 1) % Puntos.Length;
				targetWaypoint = Puntos [targetWaypointIndex];
				yield return new WaitForSeconds (Espera);
				yield return StartCoroutine (Girarse (targetWaypoint));
			}
			yield return null;
		}
	}

	IEnumerator Girarse(Vector3 lookTarget) {
		Vector3 dirMirar = (lookTarget - transform.position).normalized;
		float targetAngle = 90 - Mathf.Atan2 (dirMirar.z, dirMirar.x) * Mathf.Rad2Deg;

		while (Mathf.Abs(Mathf.DeltaAngle(transform.eulerAngles.y, targetAngle)) > 0.05f) {
			float angle = Mathf.MoveTowardsAngle (transform.eulerAngles.y, targetAngle, VelGiro * Time.deltaTime);
			transform.eulerAngles = Vector3.up * angle;
			yield return null;
		}
	}

	void OnDrawGizmos() {
		Vector3 posInicio = Camino.GetChild (0).position;
		Vector3 posFinal = posInicio;

		foreach (Transform Punto in Camino) {
			Gizmos.DrawSphere (Punto.position, .3f);
			Gizmos.DrawLine (posFinal, Punto.position);
			posFinal = Punto.position;
		}
		Gizmos.DrawLine (posFinal, posInicio);
	}

}