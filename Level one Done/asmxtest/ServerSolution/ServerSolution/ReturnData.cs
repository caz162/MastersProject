using System;

namespace ServerSolution
{
	public class ReturnData
	{
		float timeDelay;
		float[] outputs;
		
		public ReturnData(){
		
		}
		
		public ReturnData (float t, float[] o)
		{
			timeDelay = t;
			outputs = o;
			
		}
	}
}

