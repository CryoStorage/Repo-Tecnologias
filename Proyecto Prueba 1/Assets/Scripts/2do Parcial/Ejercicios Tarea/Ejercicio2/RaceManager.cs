using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour
{	
	[SerializeField]
	private int numberOfRacers;
	public Racer[] racers;
	
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
	
	// Start is called before the first frame update
	/*void Start()
    {
	    CreateRacers();
	    AddToArray();
    }
    
	public void	CreateRacers()
	{
		bycicle = new Racer(26.92f, "bycicle");
		supra = new Racer(263f, "Supra");
		aventador = new Racer(350f, "aventador");
		schoolBus = new Racer(50f, "schoolBus");
		shermanTank = new Racer(46f, "shermanTank");
		lowRiderS = new Racer(193.12f, "lowRiderS");
		kawasakiNinja = new Racer(190f, "kawasakiNinja");
		teslaModel3 = new Racer(261f, "teslaModel3");
		mustang = new Racer(262f, "mustang");
		fordFocus = new Racer(208f, "fordFocus");
	
	}
	
	void AddToArray()
	{
		racers [0] = bycicle;
		racers [1] = supra;
		racers [2] = aventador;
		racers [3] = schoolBus;
		racers [4] = shermanTank;
		racers [5] = lowRiderS;
		racers [6] = kawasakiNinja;
		racers [7] = teslaModel3;
		racers [8] = mustang;
		racers [9] = fordFocus;
	}
	
	public void ShowRacers()
	{
		for (int i = 0; i < racers.Length ; i++) 
		{
			Debug.Log(racers[i]);
			
		}
		
	}
	
	public void Race(Racer racer1, Racer racer2)
	{
		
		
	}*/
}
