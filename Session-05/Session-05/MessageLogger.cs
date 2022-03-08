using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {
        public Message[] Messages { get; set; }
        private int _indexOfMessges;

        public MessageLogger()
        {
            Messages = new Message[100];
            _indexOfMessges=0;
        }

        public void ReadAll()
        {
            for (int i = 0; i < _indexOfMessges; i++)
            {
                Console.WriteLine($" ID : {Messages[i].ID}, Time Stamp : {Messages[i].TimeStamp}, Message :{Messages[i].message}");
            }
        }

        public void Clear()
        {
            try
            {
                Messages[_indexOfMessges] = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            
        }

        public void Write(Message message)
        {
            Messages[_indexOfMessges] = message;
            _indexOfMessges++;
        }
    }
}
