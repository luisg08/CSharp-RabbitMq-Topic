using RabbitMQ.Client;
using System;
using System.Text;

public class Topicmessages
{
    public void SendMessage()
    {
        //Conexão com o CloudAMQP
        var connectionFactory = new ConnectionFactory();

        connectionFactory.Uri = new Uri("amqps://ucrhweyl:eYCN6txHd4NPy_blBoKJIwKo1apxm3E5@jackal.rmq.cloudamqp.com/ucrhweyl");
        connectionFactory.AutomaticRecoveryEnabled = true;

        var connection = connectionFactory.CreateConnection();
        var model = connection.CreateModel();
        var properties = model.CreateBasicProperties();

        properties.Persistent = false;

        byte[] messagebuffer = Encoding.Default.GetBytes("Fila1");
        model.BasicPublish("topic.exchange", "Menssagem.Fila1.test", properties, messagebuffer);
        Console.WriteLine("RabbitMq Topic.");
        Console.WriteLine("Mensagem enviada\n\n");
    }
}