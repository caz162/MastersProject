using System;
using System.Web.Services;
using System.Collections.Generic;
 


class Chromosome : IComparable<Chromosome>
{
	
	    public float  fitness = 0;
        public List<double> genes;
        public List<ActivationFunction> funcGenes;
        public int id;

        public int CompareTo(Chromosome other)
        {
           return fitness.CompareTo(other.fitness);
        }
        public Chromosome(int i)
        {
            id = i;
            genes = new List<double>();
            funcGenes = new List<ActivationFunction>();
        }

        public void AddGene(double d){
            genes.Add(d);
        }
        public void AddfuncGene(ActivationFunction a)
        {
            funcGenes.Add(a);
        }

        public int GetSize()
        {
            return genes.Count;
        }

        public void IncreaseFitness(float fit)
        {
            fitness = fit;
        }
	
}