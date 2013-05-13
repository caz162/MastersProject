using System;
using System.Collections;
using System.ServiceModel;

public class MyService : IMyService
{
	public int Add(int n1, int n2){
		return n1 + n2;
	}

}