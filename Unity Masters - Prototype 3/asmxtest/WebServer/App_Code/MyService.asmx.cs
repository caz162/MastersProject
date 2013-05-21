using System;
using System.Web.Services;

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
    public int Random(Random r, int max, int min)
    {
         return r.Next(min, max);
        
    }
}