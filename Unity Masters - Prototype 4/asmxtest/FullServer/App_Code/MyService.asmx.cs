using System;
using System.Web.Services;
using System.Collections.Generic;

 public enum NeuronPlace  {input, bias, hidden, output};


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
	public float RunNN(){
		MainTest t = new MainTest();
		//Console.WriteLine(t.Run());
		return t.Run();
	}

    [WebMethod]
    public int Rand(Random r, int max, int min)
    {
         return r.Next(min, max);
        
    }
}

class Connection
    {
        float weight;
        Neuron start;
        Neuron end;

        public void SetWeight(float w)
        {
            weight = w;

        }

        public void SetConnections(Neuron inp, Neuron outp)
        {
            start = inp;
            end = outp;
        }

        public void SetConnections(Neuron outp)
        {
            end = outp;
        }

        public void PassData(float inp)
        {
            end.RecieveData(inp * weight);
        }

    }

  class Neuron
    {
        float inputNum;
        List<Connection> inputConnections = new List<Connection>();
        List<Connection> outputConnections = new List<Connection>();
        float outputNum = 0;
        NeuronPlace place;
        int counter = 0;

        public float GetOutput()
        {
            return outputNum;
        }

        public void SetPlace(NeuronPlace p)
        {
            place = p;
        }

        public void AddInputConnection(Connection c)
        {
            inputConnections.Add(c);
        }

        public void AddOutputConnection(Connection c)
        {
            outputConnections.Add(c);
        }

        void SendData(float num)
        {
            if (place == NeuronPlace.output)
            {
                Console.WriteLine("Finished with -" + num);
                outputNum = num;
            }
            else
            foreach (Connection c in outputConnections)
            {
                c.PassData(num);
            }
        }

        void Activation()
        {
            if (inputNum >= 1)
            {
                SendData(1);
            }
            else
            {
                SendData(0);
            }
        }

        public void RecieveData(float num)
        {
            counter++;
            if (place == NeuronPlace.input){
                if (counter > inputConnections.Count+1)
                {
                    inputNum += num;
                    Activation();
                }
                else
                {
                    inputNum += num;
                   // counter++;
                }

            }
            else
            if (counter >= inputConnections.Count)
            {
                inputNum += num;
               Activation();
            }
            else
            {
                inputNum += num;
                //counter++;
            }
        }
    }

  class MainTest
    {
        List<Connection> connections = new List<Connection>();
        List<Neuron> neurons = new List<Neuron>();
        List<float> weights = new List<float>();

        void Setup()
        {


            Connection input1_hidden1 = new Connection();
            Connection input1_hidden2 = new Connection();
            Connection input1_hidden3 = new Connection();
            Connection input1_hidden4 = new Connection();
            Connection input1_hidden5 = new Connection();

            Connection hidden1_output1 = new Connection();
            Connection hidden2_output1 = new Connection();
            Connection hidden3_output1 = new Connection();
            Connection hidden4_output1 = new Connection();
            Connection hidden5_output1 = new Connection();

            Connection bias1_input1 = new Connection();

            Neuron input1 = new Neuron();
            Neuron bias1 = new Neuron();
            Neuron hidden1 = new Neuron();
            Neuron hidden2 = new Neuron();
            Neuron hidden3 = new Neuron();
            Neuron hidden4 = new Neuron();
            Neuron hidden5 = new Neuron();

            Neuron output1 = new Neuron();



            input1_hidden1.SetConnections(input1, hidden1);
            input1_hidden2.SetConnections(input1, hidden2);
            input1_hidden3.SetConnections(input1, hidden3);
            input1_hidden4.SetConnections(input1, hidden4);
            input1_hidden5.SetConnections(input1, hidden5);

            hidden1_output1.SetConnections(hidden1, output1);
            hidden2_output1.SetConnections(hidden2, output1);
            hidden3_output1.SetConnections(hidden3, output1);
            hidden4_output1.SetConnections(hidden4, output1);
            hidden5_output1.SetConnections(hidden5, output1);

            bias1_input1.SetConnections(bias1, input1);

            bias1.SetPlace(NeuronPlace.bias);
            bias1.AddOutputConnection(bias1_input1);

            input1.SetPlace(NeuronPlace.input);
            input1.AddOutputConnection(input1_hidden1);
            input1.AddOutputConnection(input1_hidden2);
            input1.AddOutputConnection(input1_hidden3);
            input1.AddOutputConnection(input1_hidden4);
            input1.AddOutputConnection(input1_hidden5);

            hidden1.SetPlace(NeuronPlace.hidden);
            hidden1.AddInputConnection(input1_hidden1);
            hidden1.AddOutputConnection(hidden1_output1);

            hidden2.SetPlace(NeuronPlace.hidden);
            hidden2.AddInputConnection(input1_hidden2);
            hidden2.AddOutputConnection(hidden2_output1);

            hidden3.SetPlace(NeuronPlace.hidden);
            hidden3.AddInputConnection(input1_hidden3);
            hidden3.AddOutputConnection(hidden3_output1);

            hidden4.SetPlace(NeuronPlace.hidden);
            hidden4.AddInputConnection(input1_hidden4);
            hidden4.AddOutputConnection(hidden4_output1);

            hidden5.SetPlace(NeuronPlace.hidden);
            hidden5.AddInputConnection(input1_hidden5);
            hidden5.AddOutputConnection(hidden5_output1);

            output1.SetPlace(NeuronPlace.output);
            output1.AddInputConnection(hidden1_output1);
            output1.AddInputConnection(hidden2_output1);
            output1.AddInputConnection(hidden3_output1);
            output1.AddInputConnection(hidden4_output1);
            output1.AddInputConnection(hidden5_output1);


            connections.Add(input1_hidden1);
            connections.Add(input1_hidden2);
            connections.Add(input1_hidden3);
            connections.Add(input1_hidden4);
            connections.Add(input1_hidden5);
            connections.Add(bias1_input1);
            connections.Add(hidden1_output1);
            connections.Add(hidden2_output1);
            connections.Add(hidden3_output1);
            connections.Add(hidden4_output1);
            connections.Add(hidden5_output1);

            neurons.Add(input1);
            neurons.Add(bias1);
            neurons.Add(hidden1);
            neurons.Add(hidden2);
            neurons.Add(hidden3);
            neurons.Add(hidden4);
            neurons.Add(hidden5);
            neurons.Add(output1);
        }
        void SetWeights()
        {
            int i = 0;
            foreach (Connection c in connections)
            {
                c.SetWeight(weights[i]);
                i++;
            }
        }
        public float Run()
        {
            Setup();
            DefaultWeights();
            SetWeights();
            neurons[0].RecieveData(1);
            neurons[1].RecieveData(1);
            Console.WriteLine("Finished is " + neurons[neurons.Count-1].GetOutput());
    		return  6;   
	}

        void DefaultWeights()
        {
            foreach (Connection c in connections)
            {
                weights.Add(1);
            }
        }
    }