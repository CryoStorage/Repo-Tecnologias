using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour
{	
	[SerializeField]
	private int numberOfRacers;
	private List<Racer> racers = new List<Racer>();
	 
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
	

	// Start is called before the first frame update
	void Start()
    {
	    CreateRacers();
	    AddToList();
    }
    
	public void	CreateRacers()
	{

	
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
	
	public void ShowRacers()
	{
		for (int i = 0; i < racers.Capacity ; i++) 
		{
			Debug.Log(racers[i]);
			
		}
		
	}
	
	public void Race(Racer racer1, Racer racer2)
	{
		
		
	}
}
