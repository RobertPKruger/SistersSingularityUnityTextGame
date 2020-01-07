using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextGameEngine1 : MonoBehaviour
{
	[SerializeField] Text textLocation;
	[SerializeField] Text textDescription;

	//[SerializeField] Panel buttonPanel;
	TextAdventure adventure;
	public GameObject buttonPrefab;
	public RectTransform parentPanel;

	// Use this for initialization
	void Start()
	{
		var sample = new SampleAdventure();
		adventure = new TextAdventure(sample.Locations);

		ChangeUI();
	}

	public void OnButtonClick(string name)
	{
		adventure.ChangeState(name);
		ChangeUI();
	}

	void ChangeUI()
	{
		textLocation.text = adventure.CurrentState.Name;
		textDescription.text = adventure.CurrentState.Description;

		foreach (Transform child in parentPanel.transform)
		{
			Destroy(child.gameObject);
		}

		foreach (string s in adventure.CurrentState.AdjacentLocations)
		{
			GameObject btn = Instantiate(buttonPrefab) as GameObject;
			btn.transform.SetParent(parentPanel,true);

			Button tempButton = btn.GetComponent<Button>();
			tempButton.GetComponentInChildren<Text>().text = s;
			tempButton.onClick.AddListener(() => OnButtonClick(s));
		}
	}

	// Update is called once per frame
	void Update()
	{

	}



}
