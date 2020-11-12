using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Client;
using Crypto;

namespace NodeA
{
    public partial class Form1 : Form
    {
        public ClientBehavior Client;
        public Form1()
        {
            InitializeComponent();
            Client = new ClientBehavior(BlockCipherMode.CFB);
        } 

        private void buttonBrowseFile_Click(object sender, System.EventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2
            };
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Error at selecting a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var filePath = dialog.FileName;
            var bytesOfFile = File.ReadAllBytes(filePath);

            labelPath.Text = filePath;
            labelFileSize.Text = bytesOfFile.Length.ToString();

            const int BlockSize = 16;
            const int Chunk8BlocksSize = 8 * BlockSize;

            var noBlocks = bytesOfFile.Length / BlockSize;
            var endOfFullBlocks = bytesOfFile.Length / BlockSize * BlockSize;

            byte[] chunkFor8Blocks;
            
            chunkFor8Blocks = new byte[Chunk8BlocksSize];
            for (var i = 0; i < endOfFullBlocks; i += BlockSize)
            {
                for (var j = 0; j < Chunk8BlocksSize; j++)
                    chunkFor8Blocks[j] = bytesOfFile[i + j];
                var list = GetListFromChunk(chunkFor8Blocks);
                    
            }
            

        }
        private List<Block> GetListFromChunk(byte[] given)
        {
            var result = new List<Block>();

            return result;
        }
    }
}