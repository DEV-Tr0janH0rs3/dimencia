using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Linq;

public class Client : MonoBehaviour
{
    public GameObject playernew;
    int ClientNumber;
    float neshto;
    public GameObject[] players;
    public TcpClient client = new TcpClient();
    
    // Start is called before the first frame update
    void Start()
    {
        //players = GameObject.FindGameObjectsWithTag("Player");
        ThreadStart threada = new ThreadStart(StartTheServer);
        Thread qktredbrat = new Thread(threada);
        qktredbrat.Start();
    }

    public void StartTheServer()
    {

        // we set our IP address as server's address, and we also set the port: 9999

        client.Connect("192.168.0.105", 6959);  // this will start the server
        NetworkStream ns = client.GetStream();
        while (true)   //we wait for a connection
        {

            byte[] hello = new byte[100];

            while (client.Connected)  //while the client is connected, we look for incoming messages
            {
                byte[] msg = new byte[1024];     //the messages arrive as byte array
                ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client
                Debug.Log(Encoding.Default.GetString(msg)); //now , we write the message as string
                string gay = Encoding.Default.GetString(msg);
                if (gay.Contains("gg"))
                {
                    ClientNumber = 1;
                }
                else
                {
                    string part = gay.Substring(0, gay.IndexOf(']'));
                    neshto = float.Parse(part);
                }
            }
        }
    }

    public void themove()
    {
        playernew.transform.position = (new Vector3(neshto, playernew.transform.position.y, playernew.transform.position.z));
    }
    // Update is called once per frame
    void Update()
    {
        if (ClientNumber == 1)
        {
            ClientNumber = 0;
            playernew = Instantiate(playernew, new Vector3(148.34f, 1.37f, 190f), Quaternion.identity);
        }
        Vector3 pos = new Vector3(neshto, playernew.transform.position.y, playernew.transform.position.z);
        if (playernew != null)
        {
            playernew.transform.position = Vector3.Lerp(playernew.transform.position, pos, 1);
        }
        // NetworkStream ns = client.GetStream();
        // byte[] mesage = new byte[1024];
        //mesage = Encoding.Default.GetBytes((this.gameObject.transform.position.x).ToString());  //conversion string => byte array
        // ns.Read(mesage, 0, mesage.Length);
        // playernew.transform.position = (new Vector3(float.Parse(Encoding.Default.GetString(mesage)), 1.37f, 190f));

        // ns.Write(mesage, 0, mesage.Length);
    }
}
