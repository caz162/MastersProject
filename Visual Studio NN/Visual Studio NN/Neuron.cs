using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visual_Studio_NN
{
    public enum NeuronPlace  {input, bias, hidden, output};

    class Neuron
    {
        float inputNum;
        List<Connection> inputConnections = new List<Connection>();
        List<Connection> outputConnections = new List<Connection>();
        NeuronPlace place;
        int counter = 0;

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
                    SendData(inputNum);
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
                SendData(inputNum);
            }
            else
            {
                inputNum += num;
                //counter++;
            }
        }
    }
}
