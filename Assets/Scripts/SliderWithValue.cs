using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
[ExecuteInEditMode]
public class SliderWithValue : MonoBehaviour {

    [SerializeField] private Text text;
    [SerializeField] private string unit;
    [SerializeField] private byte decimals = 2;
    private Slider slider;

    void Awake() {
        slider = GetComponent<Slider>();
    }

    void OnEnable () {
        slider.onValueChanged.AddListener(ChangeValue);
        ChangeValue(slider.value);
    }

    void OnDisable() {
        slider.onValueChanged.RemoveAllListeners();
    }

    void ChangeValue(float value) {
        text.text = value.ToString("n" + decimals) + " " + unit;
    }

}
