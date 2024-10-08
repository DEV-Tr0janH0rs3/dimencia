using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Linq;

public class ServerCreation : MonoBehaviour
{

    public string Message;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        ThreadStart threada = new ThreadStart(StartTheServer);
        Thread qktredbrat = new Thread(threada);
        qktredbrat.Start();
        StartCoroutine(InfiniteLoop());
    }
    void OnEnable(){
        StartCoroutine(InfiniteLoop());
    }

    public void StartTheServer()
    {
        Debug.Log("asd");
        TcpListener server = new TcpListener(IPAddress.Any, 9996);
        // we set our IP address as server's address, and we also set the port: 9999

        server.Start();  // this will start the server

        while (true)   //we wait for a connection
        {
            TcpClient client = server.AcceptTcpClient();  //if a connection exists, the server will accept it

            NetworkStream ns = client.GetStream(); //networkstream is used to send/receive messages

            byte[] hello = new byte[100];   //any message must be serialized (converted to byte array)
            hello = Encoding.Default.GetBytes("hello world");  //conversion string => byte array

            ns.Write(hello, 0, hello.Length);     //sending the message

            while (client.Connected)  //while the client is connected, we look for incoming messages
            {
                byte[] msg = new byte[1024];     //the messages arrive as byte array
                ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client
                Debug.Log(Encoding.Default.GetString(msg)); //now , we write the message as string
                Message = Encoding.Default.GetString(msg);
            }
        }
    }

    private IEnumerator InfiniteLoop()
    {
        WaitForSeconds waitTime = new WaitForSeconds(0.01f);
        while (true)
        {
            if(Message.Contains("a")){
            Message = "";
            Debug.Log("sel");
            GameObject p = Instantiate(Player, new Vector2(1, 1), Quaternion.identity);
            }
            yield return waitTime;
        }
    }
    // Update is called once per frame
    void Spawn()
    {
        GameObject p = Instantiate(Player, new Vector2(1, 1), Quaternion.identity);
    }
}
