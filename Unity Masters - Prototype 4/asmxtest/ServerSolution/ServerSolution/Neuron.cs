using System;
using System.Web.Services;
using System.Collections.Generic;
 

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
              //  Console.WriteLine("Finished with -" + num);
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