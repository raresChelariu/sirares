using System.Windows.Forms;
using System.IO;
using Client;
using System.Collections.Generic;
using Crypto;

namespace NodeB
{
    public partial class Form1 : Form
    {
        private ClientBehavior client;
        private SecurityAlgorithm alg;
        public Form1()
        {
            InitializeComponent();
            client = new ClientBehavior(BlockCipherMode.CFB);
            
        }

        
    }
}