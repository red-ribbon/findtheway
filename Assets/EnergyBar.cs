using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour {

	private RectTransform rt;
	private float totalEnergy;

	public float value = 100f;

	// Use this for initialization
	void Start () {
		this.rt = GetComponent<RectTransform> ();
		this.totalEnergy = rt.sizeDelta.x;
	}

	void Update() {
		float valor = 100.0f - this.value;
		setPercentageOfEnergy (valor);
	}

	//newValue es el porcentaje restante
	private void setPercentageOfEnergy(float newValue) {
		float x = (newValue * totalEnergy) / 100;
		float y = rt.localPosition.y;
		float z = rt.localPosition.z;

		rt.localPosition = new Vector3 (-x, y, z);
	}


}
