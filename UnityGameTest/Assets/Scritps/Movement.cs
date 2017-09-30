using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float m_speed;
	public Vector3 m_direction;

	// Use this for initialization
	void Start () {
		m_direction = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			if (m_direction == Vector3.forward) {
				m_direction = Vector3.left;
			} else {
				m_direction = Vector3.forward;
			}
		}

		float m_amount = m_speed * Time.deltaTime;

		transform.Translate (m_direction * m_amount);
	}
}
