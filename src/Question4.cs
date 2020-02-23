using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentTest
{
    public class Question4
    {
        public void AlexaSettings()
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa

            alexa.Configure(x =>
            {
                x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
                x.OwnerName = "Bob Marley";
            });

            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service

            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();

        }

        public class Alexa
        {
            private Message _message;
            public Alexa()
            {
                _message = new Message();
                _message.GreetingMessage = "Hello, i am Alexa";
            }

            public string Talk()
            {
                return _message.GreetingMessage.Replace("{OwnerName}", _message.OwnerName);
            }

            public void Configure(Action<Message> message)
            {
                message.Invoke(_message);
            }

            public class Message
            {
                public string GreetingMessage { get; set; }
                public string OwnerName { get; set; }
            }
        }
    }
    
    
}
