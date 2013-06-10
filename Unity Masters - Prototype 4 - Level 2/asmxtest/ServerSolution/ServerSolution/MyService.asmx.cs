using System;
using System.Web.Services;

using System.Collections.Generic;

	public enum NeuronPlace  {input, bias, hidden, output};
	public enum ActivationFunction { Null, Sigmoid, HyperbolicTangent, Cosine, Gaussian, Random };

[WebService (Namespace = "http://tempuri.org/MyService")]

public class MyService
{	
	//Static variable for running the running the Neural net
	//Will be destroyed when second server is up
	static MainTest test = new MainTest();
	
	//Simple Add method. Returns a+b to unity.
	[WebMethod]
	public int Add(int a, int b){
		return a+b;
	}
	
	//Prints to the servers console window.
    [WebMethod]
    public void Print()
    {
       Console.WriteLine("working");
    }
	
	//Method for setting up the neural network.
	//Will flesh this out later
	[WebMethod]
	public void SetupNN(){
		test = new MainTest();
		test.defaultSetup();
	}
	
	//Method for changing the nerual net to the next chromosome.
	[WebMethod]
	public void NextItem(){
		test.ChangeChromosome();
	}
	
	//Running the nerual network
	[WebMethod]
	public float RunNN(int num){
		float value1 = test.Run(num);
		if(num == 3){
			test.RecieveFitness(1);
		}
		//Console.WriteLine(t.Run());
		return value1;
	}
	
	//Returns a random number between two numbers.
    [WebMethod]
    public int Rand(Random r, int max, int min)
    {
		
         return r.Next(min, max);
        
    }
}



