using System;
using System.Web.Services;

using System.Collections.Generic;

	public enum NeuronPlace  {input, bias, hidden, output};
	public enum ActivationFunction { Null, Sigmoid, HyperbolicTangent, Cosine, Gaussian, Random };

[WebService (Namespace = "http://tempuri.org/MyService")]

public class MyService
{	
	//[WebAttribute]
	static MainTest test = new MainTest();
	
	
	[WebMethod]
	public int Add(int a, int b){
		return a+b;
	}

    [WebMethod]
    public void Print()
    {
       Console.WriteLine("working");
    }
	
	[WebMethod]
	public void SetupNN(){
		test = new MainTest();
		test.defaultSetup();
	}
	
	[WebMethod]
	public void NextItem(){
		test.ChangeChromosome();
	}
	
	[WebMethod]
	public float[] RunNN(int num1, int num2, int num3){
		float[] value1 = test.Run(num1,num2,num3);
		if(num == 3){
			test.RecieveFitness(1);
		}
		//Console.WriteLine(t.Run());
		return value1;
	}

    [WebMethod]
    public int Rand(Random r, int max, int min)
    {
		
         return r.Next(min, max);
        
    }
}



