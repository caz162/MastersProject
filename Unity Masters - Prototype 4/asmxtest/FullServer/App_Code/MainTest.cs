using System;
using System.Web.Services;
using System.Collections.Generic;

 
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
        public float Run(int num)
        {
            Setup();
            DefaultWeights();
            SetWeights();
            neurons[0].RecieveData(num);
            neurons[1].RecieveData(num);
          //  Console.WriteLine("Finished is " + neurons[neurons.Count-1].GetOutput());
    		return neurons[neurons.Count-1].GetOutput() ;   
	}

        void DefaultWeights()
        {
            foreach (Connection c in connections)
            {
                weights.Add(1);
            }
        }
    }