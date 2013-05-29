using System;
using System.Web.Services;
using System.Collections.Generic;

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
