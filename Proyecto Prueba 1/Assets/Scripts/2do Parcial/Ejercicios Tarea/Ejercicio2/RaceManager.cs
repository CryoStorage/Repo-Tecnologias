using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour
{	
	[SerializeField]private int numberOfRacers;
	private List<Racer> racers;
	Racer bycicle;
	Racer supra;
	Racer aventador;
	Racer schoolBus;
	Racer shermanTank;
	Racer lowRiderS;
	Racer kawasakiNinja;
	Racer teslaModel3;
	Racer mustang;
	Racer fordFocus;

	float getCapacity(List<Racer> list)
	{
		float cap = 0;
		foreach (Racer racer in racers)
		{
			if (racer.GetType() is Racer)
			{
				cap++;
			}
		}
		return cap;
			
	}
	
	float capacity;
	

	// Start is called before the first frame update
	void Start()
    {
	    CreateRacers();
	    AddToList();
	    CheckInput();
	    ShowRacers();
    }
    
	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		CheckInput();
	}
    
	public void	CreateRacers()
	{
		racers = new List<Racer>();
		Racer bycicle = new Racer(26.92f, "bycicle");
		Racer supra = new Racer(263f, "Supra");
		Racer aventador = new Racer(350f, "aventador");
		Racer schoolBus = new Racer(50f, "schoolBus");
		Racer shermanTank = new Racer(46f, "shermanTank");
		Racer lowRiderS = new Racer(193.12f, "lowRiderS");
		Racer kawasakiNinja = new Racer(190f, "kawasakiNinja");
		Racer teslaModel3 = new Racer(261f, "teslaModel3");
		Racer mustang = new Racer(262f, "mustang");
		Racer fordFocus = new Racer(208f, "fordFocus");
		capacity = getCapacity(racers);
	
	}
	
	void AddToList()
	{
		racers.Add(bycicle);
		racers.Add(supra);
		racers.Add(aventador);
		racers.Add(schoolBus);
		racers.Add(shermanTank);
		racers.Add(lowRiderS);
		racers.Add(kawasakiNinja);
		racers.Add(teslaModel3);
		racers.Add(mustang);
		racers.Add(fordFocus);
	}
	
	void CheckInput()
	{
		if (Input.GetKeyDown("q"))
		{
			ShowRacers();
		}
		
	}
	public void ShowRacers()
	{
	
		for (int i = 0; i < capacity ; i++) 
		{
			Debug.Log(racers[i]);
			
		}
		
	}
	
	public void Race(Racer racer1, Racer racer2)
	{
		
		
	}
}
