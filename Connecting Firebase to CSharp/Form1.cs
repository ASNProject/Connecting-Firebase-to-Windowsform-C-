using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Connecting_Firebase_to_CSharp
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kE5gZJFZXJLsKgQGYaTpL40690kkhOpJNC3UjjO8", //Masukkan Token Rahasia Firebase
            BasePath = "https://fir-csharp-cb339.firebaseio.com/" //Masukkan Link Firebase
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                label1.Text = "Connected Firebase";
                label1.ForeColor = Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
