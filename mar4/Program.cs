namespace mar4;
class Program
{
    public class Message{
        public string contents;
        public int priority;
        public Message(string content, int prio) {
            this.priority = prio;
            this.contents = content;
        }
    }

    public delegate void MessageHandler(Message message);



    public class Publisher {
       public event MessageHandler MessageEvent;    

       public void SendMessage(Message message) {
            if (MessageEvent != null) {
                MessageEvent(message);
            }
       }
    }

    public class Subscriber {
        int priority;

        public Subscriber(int threshold) {
           this.priority = threshold;
        }

        public void OnMessageReceiver(Message message) {
            if (message.priority <= this.priority) {
                Console.WriteLine("Received message: {0} of priority {1}", message.contents, message.priority);
            }
        }
    }

    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber1 = new Subscriber(1);
        Subscriber subscriber2 = new Subscriber(2);

        publisher.MessageEvent += subscriber1.OnMessageReceiver;
        publisher.MessageEvent += subscriber2.OnMessageReceiver;

        publisher.SendMessage(new Message("this is a prio 2 message", 2));
        publisher.SendMessage(new Message("this is a prio 1 message", 1));
        
    }
}
