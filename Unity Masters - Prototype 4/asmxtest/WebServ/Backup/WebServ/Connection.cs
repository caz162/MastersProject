using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visual_Studio_NN
{
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
}
