using System;
using System.Web.Services;
using System.Collections.Generic;

	public enum NeuronPlace  {input, bias, hidden, output};
	public enum ActivationFunction { Null, Sigmoid, HyperbolicTangent, Cosine, Gaussian, Random };

[WebService (Namespace = "http://tempuri.org/MyService")]

public class MyService
{	
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
	public float RunNN(int num){
		MainTest t = new MainTest();
		float value1 = t.Run(num);
		if(num = 3){
			t.RecieveFitness(1);
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



