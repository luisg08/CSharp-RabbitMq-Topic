using System;

namespace RequestRabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            Topicmessages topicmessages = new Topicmessages();
            do
            {
                Console.WriteLine("Enviar Mensagem?");
                opt = Console.ReadLine();
                if ((opt == "Sim") || (opt == "sim"))
                    topicmessages.SendMessage();
                else
                    Environment.Exit(0);
            } while (true);
            
        }
    }
}