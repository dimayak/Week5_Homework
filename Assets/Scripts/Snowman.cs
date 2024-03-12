using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Snowman : MonoBehaviour
{
    [SerializeField] private Transform _top;
    [SerializeField] private Transform _middle;
    [SerializeField] private Transform _bottom;
    [SerializeField] private Transform _leftHand;
    [SerializeField] private Transform _rightHand;

    [SerializeField] private Slider _topSlider;
    [SerializeField] private Slider _middleSlider;
    [SerializeField] private Slider _bottomSlider;

    [SerializeField] private List<GameObject> _allCaps = new();
    [SerializeField] private TMP_Dropdown _capDropDown;
    [SerializeField] private Toggle _defaultMaterialToggle;

    private void Start()
    {
        _topSlider.value = _top.localScale.x;
        _middleSlider.value = _middle.localScale.x;
        _bottomSlider.value = _bottom.localScale.x;
        _capDropDown.value = _allCaps.Count;
        _defaultMaterialToggle.isOn = true;
    }

    public void SetTopSize(float value)
    {
        _top.localScale = Vector3.one * value;
    }

    public void SetMiddleSize(float value)
    {
        _middle.localScale = Vector3.one * value;
    }

    public void SetBottomSize(float value)
    {
        _bottom.localScale = Vector3.one * value;
    }

    public void SetCap(int index)
    {
        for (int i = 0; i < _allCaps.Count; ++i)
        {
            if (index == i)
            {
                _allCaps[i].SetActive(true);
            }
            else
            {
                _allCaps[i].SetActive(false);
            }
        }
    }

    public void SetMaterial(Material material)
    {
        _top.GetComponent<Renderer>().material = material;
        _middle.GetComponent<Renderer>().material = material;
        _bottom.GetComponent<Renderer>().material = material;
        _leftHand.GetComponent<Renderer>().material = material;
        _rightHand.GetComponent<Renderer>().material = material;
    }
}
