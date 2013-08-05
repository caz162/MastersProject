using System;
using System.Web.Services;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

class MainTest
{
	List<Connection> connections = new List<Connection> ();
	List<Neuron> neurons = new List<Neuron> ();
	List<Chromosome> population = new List<Chromosome> ();
	List<float> weights = new List<float> ();
	Random r = new Random ();
	int id = 0;
	int current = 0;
	bool newPop = false;
	float crossoverRate = 0.25f;
	int popSize = 10;
	float mutationRate = 0.08f;
	bool canRun = false;
	int generations = 10;
	int genCounter = 0;
	
	void Setup ()
	{

		Connection input1_hidden1 = new Connection ();
		Connection input1_hidden2 = new Connection ();
		Connection input1_hidden3 = new Connection ();
		Connection input1_hidden4 = new Connection ();
		Connection input1_hidden5 = new Connection ();
		
		Connection input2_hidden1 = new Connection ();
		Connection input2_hidden2 = new Connection ();
		Connection input2_hidden3 = new Connection ();
		Connection input2_hidden4 = new Connection ();
		Connection input2_hidden5 = new Connection ();
		
		Connection input3_hidden1 = new Connection ();
		Connection input3_hidden2 = new Connection ();
		Connection input3_hidden3 = new Connection ();
		Connection input3_hidden4 = new Connection ();
		Connection input3_hidden5 = new Connection ();

		Connection hidden1_output1 = new Connection ();
		Connection hidden2_output1 = new Connection ();
		Connection hidden3_output1 = new Connection ();
		Connection hidden4_output1 = new Connection ();
		Connection hidden5_output1 = new Connection ();
		
		Connection hidden1_output2 = new Connection ();
		Connection hidden2_output2 = new Connection ();
		Connection hidden3_output2 = new Connection ();
		Connection hidden4_output2 = new Connection ();
		Connection hidden5_output2 = new Connection ();

		Connection bias1_input1 = new Connection ();
		Connection bias2_input2 = new Connection ();
		Connection bias3_input3 = new Connection ();

		Neuron input1 = new Neuron ();
		Neuron bias1 = new Neuron ();
		
		Neuron input2 = new Neuron ();
		Neuron bias2 = new Neuron ();
		
		
		Neuron input3 = new Neuron ();
		Neuron bias3 = new Neuron ();
		
		Neuron hidden1 = new Neuron ();
		Neuron hidden2 = new Neuron ();
		Neuron hidden3 = new Neuron ();
		Neuron hidden4 = new Neuron ();
		Neuron hidden5 = new Neuron ();

		Neuron output1 = new Neuron ();
		Neuron output2 = new Neuron ();


		input1_hidden1.SetConnections (input1, hidden1);
		input1_hidden2.SetConnections (input1, hidden2);
		input1_hidden3.SetConnections (input1, hidden3);
		input1_hidden4.SetConnections (input1, hidden4);
		input1_hidden5.SetConnections (input1, hidden5);
		
		input2_hidden1.SetConnections (input2, hidden1);
		input2_hidden2.SetConnections (input2, hidden2);
		input2_hidden3.SetConnections (input2, hidden3);
		input2_hidden4.SetConnections (input2, hidden4);
		input2_hidden5.SetConnections (input2, hidden5);
		
		input3_hidden1.SetConnections (input3, hidden1);
		input3_hidden2.SetConnections (input3, hidden2);
		input3_hidden3.SetConnections (input3, hidden3);
		input3_hidden4.SetConnections (input3, hidden4);
		input3_hidden5.SetConnections (input3, hidden5);

		hidden1_output1.SetConnections (hidden1, output1);
		hidden2_output1.SetConnections (hidden2, output1);
		hidden3_output1.SetConnections (hidden3, output1);
		hidden4_output1.SetConnections (hidden4, output1);
		hidden5_output1.SetConnections (hidden5, output1);
		
		hidden1_output2.SetConnections (hidden1, output2);
		hidden2_output2.SetConnections (hidden2, output2);
		hidden3_output2.SetConnections (hidden3, output2);
		hidden4_output2.SetConnections (hidden4, output2);
		hidden5_output2.SetConnections (hidden5, output2);

		bias1_input1.SetConnections (bias1, input1);
		bias2_input2.SetConnections (bias2, input2);
		bias3_input3.SetConnections (bias3, input3);
		
		bias1.SetPlace (NeuronPlace.bias);
		bias1.AddOutputConnection (bias1_input1);
		
		bias2.SetPlace (NeuronPlace.bias);
		bias2.AddOutputConnection (bias2_input2);
		
		bias3.SetPlace (NeuronPlace.bias);
		bias3.AddOutputConnection (bias3_input3);
		
		
		input1.SetPlace (NeuronPlace.input);
		input1.AddOutputConnection (input1_hidden1);
		input1.AddOutputConnection (input1_hidden2);
		input1.AddOutputConnection (input1_hidden3);
		input1.AddOutputConnection (input1_hidden4);
		input1.AddOutputConnection (input1_hidden5);
		
		input2.SetPlace (NeuronPlace.input);
		input2.AddOutputConnection (input2_hidden1);
		input2.AddOutputConnection (input2_hidden2);
		input2.AddOutputConnection (input2_hidden3);
		input2.AddOutputConnection (input2_hidden4);
		input2.AddOutputConnection (input2_hidden5);
		
		input3.SetPlace (NeuronPlace.input);
		input3.AddOutputConnection (input3_hidden1);
		input3.AddOutputConnection (input3_hidden2);
		input3.AddOutputConnection (input3_hidden3);
		input3.AddOutputConnection (input3_hidden4);
		input3.AddOutputConnection (input3_hidden5);

		hidden1.SetPlace (NeuronPlace.hidden);
		hidden1.AddInputConnection (input1_hidden1);
		hidden1.AddInputConnection (input2_hidden1);
		hidden1.AddInputConnection (input3_hidden1);
		hidden1.AddOutputConnection (hidden1_output1);
		hidden1.AddOutputConnection (hidden1_output2);

		hidden2.SetPlace (NeuronPlace.hidden);
		hidden2.AddInputConnection (input1_hidden2);
		hidden2.AddInputConnection (input2_hidden2);
		hidden2.AddInputConnection (input3_hidden2);
		hidden2.AddOutputConnection (hidden2_output1);
		hidden2.AddOutputConnection (hidden2_output2);

		hidden3.SetPlace (NeuronPlace.hidden);
		hidden3.AddInputConnection (input1_hidden3);
		hidden3.AddInputConnection (input2_hidden3);
		hidden2.AddInputConnection (input3_hidden3);
		hidden3.AddOutputConnection (hidden3_output1);
		hidden3.AddOutputConnection (hidden3_output2);

		hidden4.SetPlace (NeuronPlace.hidden);
		hidden4.AddInputConnection (input1_hidden4);
		hidden4.AddInputConnection (input2_hidden4);
		hidden4.AddInputConnection (input3_hidden4);		
		hidden4.AddOutputConnection (hidden4_output1);
		hidden4.AddOutputConnection (hidden4_output2);

		hidden5.SetPlace (NeuronPlace.hidden);
		hidden5.AddInputConnection (input1_hidden5);
		hidden5.AddInputConnection (input2_hidden5);
		hidden5.AddInputConnection (input3_hidden5);
		hidden5.AddOutputConnection (hidden5_output1);
		hidden5.AddOutputConnection (hidden5_output2);

		output1.SetPlace (NeuronPlace.output);
		output1.AddInputConnection (hidden1_output1);
		output1.AddInputConnection (hidden2_output1);
		output1.AddInputConnection (hidden3_output1);
		output1.AddInputConnection (hidden4_output1);
		output1.AddInputConnection (hidden5_output1);
		
		output2.SetPlace (NeuronPlace.output);
		output2.AddInputConnection (hidden1_output2);
		output2.AddInputConnection (hidden2_output2);
		output2.AddInputConnection (hidden3_output2);
		output2.AddInputConnection (hidden4_output2);
		output2.AddInputConnection (hidden5_output2);


		connections.Add (input1_hidden1);
		connections.Add (input1_hidden2);
		connections.Add (input1_hidden3);
		connections.Add (input1_hidden4);
		connections.Add (input1_hidden5);
		
		connections.Add (input2_hidden1);
		connections.Add (input2_hidden2);
		connections.Add (input2_hidden3);
		connections.Add (input2_hidden4);
		connections.Add (input2_hidden5);
		
		connections.Add (input3_hidden1);
		connections.Add (input3_hidden2);
		connections.Add (input3_hidden3);
		connections.Add (input3_hidden4);
		connections.Add (input3_hidden5);
		
		connections.Add (bias1_input1);
		connections.Add (bias2_input2);
		connections.Add (bias3_input3);
		
		connections.Add (hidden1_output1);
		connections.Add (hidden2_output1);
		connections.Add (hidden3_output1);
		connections.Add (hidden4_output1);
		connections.Add (hidden5_output1);
			
		connections.Add (hidden1_output2);
		connections.Add (hidden2_output2);
		connections.Add (hidden3_output2);
		connections.Add (hidden4_output2);
		connections.Add (hidden5_output2);

		neurons.Add (input1);
		neurons.Add (bias1);
		
		neurons.Add (input2);
		neurons.Add (bias2);
		
		neurons.Add (input3);
		neurons.Add (bias3);
		
		neurons.Add (hidden1);
		neurons.Add (hidden2);
		neurons.Add (hidden3);
		neurons.Add (hidden4);
		neurons.Add (hidden5);
		
		
		neurons.Add (output1);
		neurons.Add (output2);
		
		canRun = true;
	}
	
	void SetWeights ()
	{
		int i = 0;
		foreach (Connection c in connections) {
			c.SetWeight ((float)population [current].genes [i]);
			i++;
		}
	}
	
	public void defaultSetup ()
	{
		Setup ();	
		
		DefaultWeights ();
		GeneratePopulation (popSize);
		
		SetWeights ();
		//SetWeights();
	}
	
	public void Save ()
	{
		StreamWriter sw = new StreamWriter ("file.txt");
		for (int i=0; i<population[current].genes.Count; i++) {
			sw.WriteLine (population [current].genes [i]);
		}
		
		sw.Close ();

	}
	
	public float[] Run (int num1, int num2, int num3, bool hit)
	{
		//Console.WriteLine("recieved data"+num1);
		//Console.WriteLine("recieved data"+num2);
		//Console.WriteLine("recieved data"+num3);
		/*	if(num1 == 3){
			Console.WriteLine("increasing fitness");
			RecieveFitness(1);	
		}
			*/
		for (int i =0; i<6; i+=2) {
			if (i == 0) {
				neurons [0 + i].RecieveData (num1);
			}
			if (i == 2) {
				neurons [0 + i].RecieveData (num2);
			}
			if (i == 4) {
				neurons [0 + i].RecieveData (num3);
			}
			neurons [1 + i].RecieveData (1);
			
		}
		
		//  Console.WriteLine("Finished is " + neurons[neurons.Count-1].GetOutput());
		if(hit){
			//Console.WriteLine("fitness");
			Console.WriteLine ("adding");
				RecieveFitness(1);
		}
		float [] returns = new float[2];
		//Console.WriteLine(neurons [neurons.Count - 1].GetOutput ());
		returns [0] = neurons [neurons.Count - 1].GetOutput ();
		//Console.WriteLine(neurons [neurons.Count - 2].GetOutput ());
		returns [1] = neurons [neurons.Count - 2].GetOutput ();
		
		return returns; 
	}
	
	public void GeneratePopulation (int size)
	{
		for (int i = 0; i<size; i++) {
			Chromosome c = new Chromosome (id);
			for (int j=0; j<connections.Count; j++) {
				c.AddGene (r.Next (-10, 10));
				
			}
			population.Add (c);
			id++;
		}
	}
	
	public void ChangeChromosome ()
	{
		Console.WriteLine ("Fitness " + population [current].fitness);
		Console.WriteLine ("population member" + current);
		Console.WriteLine ("generation" + genCounter);
		
		if (genCounter < generations) {
			current++;
			DefaultWeights ();
		
		
			if (current >= popSize) {
				List<Chromosome> newPop = new List<Chromosome> ();
				population.Sort ();
				population.Reverse();
				Console.WriteLine ("Fitnesses");
				for (int i=0; i<population.Count; i++) {
					Console.WriteLine ("" + population [i].fitness);	
				}
				/*
				using (StreamWriter writer = new StreamWriter("results.txt",true)) {
					writer.WriteLine (population [0].fitness);
					writer.Close ();
				}
				*/
				int removeAmount = (int)(popSize * crossoverRate);
				for (int i = 0; i < popSize; i++) {
					if (i >= removeAmount)
						population.RemoveAt (removeAmount);
				}
				for (int i =0; i<(current - (current*crossoverRate)); i++) {
					Chromosome p1 = TSelection ();
					Chromosome p2 = TSelection ();
					while (p1.id == p2.id) {
						p2 = TSelection ();
					}
					Chromosome child = Crossover (p1, p2);
					Chromosome mChild = Mutation (child);
					newPop.Add (mChild);
				}
				for (int i=0; i< newPop.Count; i++) {
					population.Add (newPop [i]);	
				}
				current = (int)(current * crossoverRate);
				genCounter++;
			}	
		
		
		
			SetWeights ();
		} else {
			population.Sort ();
			population.Reverse();
			current = 0;
			Save ();
			SetWeights ();
		}
	}
	
	public Chromosome TSelection ()
	{
		Chromosome parent1;
		Chromosome parent2;
		
		parent1 = population [r.Next (0, population.Count)];
		parent2 = population [r.Next (0, population.Count)];
			
		while (parent2.id == parent1.id) {
			parent2 = population [r.Next (0, population.Count)];
			
		}
		if (parent1.fitness > parent2.fitness) {
			return parent1;
			
			
		} else {
			return parent2;	
			
		}
	}
	
	public Chromosome Crossover (Chromosome parent1, Chromosome parent2)
	{
		int random = r.Next (parent1.genes.Count);
		Chromosome child = new Chromosome (id);
		id++;
		
		for (int i =0; i< random; i++) {
			child.AddGene (parent1.genes [i]);	
		}
		for (int i = random; i<parent1.genes.Count; i++) {
			child.AddGene (parent2.genes [i]);	
		}
		
		return child;
	}
	
	public Chromosome Mutation (Chromosome original)
	{
		Chromosome mChild = new Chromosome (original.id);
		for (int i =0; i<original.genes.Count; i++) {
			if (r.NextDouble () < mutationRate) {
				mChild.AddGene (r.NextDouble ());	
			} else {
				mChild.AddGene (original.genes [i]);	
			}
				
		}
		return mChild;
			
		
	}
	
	public void RecieveFitness (int fit)
	{
		population [current].IncreaseFitness (fit);
		Console.WriteLine ("Fitness has increased by " + population [current].fitness);
	}
	
	void DefaultWeights ()
	{
		foreach (Connection c in connections) {
			weights.Add (1);
		}
	}
	
}