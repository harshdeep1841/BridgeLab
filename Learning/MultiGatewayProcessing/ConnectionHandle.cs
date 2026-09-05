namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.MultiGatewayProcessing;

using System;

    public class ConnectionHandle
    {
        public bool IsOpen { get; private set; }

        public ConnectionHandle()
        {
            
            IsOpen = true;
            Console.WriteLine("Connected");
        }

        public void Close()
        {
            
            if (!IsOpen)
            {
                
                throw new InvalidOperationException("Connection already closed");
            }
            

            IsOpen = false;
            Console.WriteLine("Connection closed.");
        }
    }
