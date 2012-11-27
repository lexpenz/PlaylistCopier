using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyShortListOfFiles;

namespace SimplePlayListCorier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        String fileAddress = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //получаем адрес файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileAddress = openFileDialog.FileName;
                _tbFile.Text = fileAddress;
            }
        }
        String folderAddress = "";
        private void _btnOpenFolder_Click(object sender, EventArgs e)
        {
            //узнаем адрес назначения
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.RootFolder = Environment.SpecialFolder.Personal;
            if (openFolderDialog.ShowDialog() == DialogResult.OK)
            {
                folderAddress = openFolderDialog.SelectedPath;
                _tbFolder.Text = folderAddress;
            }
        }

        private void _btnCopy_Click(object sender, EventArgs e)
        {
            //получаем из m3u список файлов
            M3U m3uFile = new M3U(fileAddress);

            //копируем файлы из списка по адресу
            String musicFileAddress = m3uFile.GetNextFilePath();
            while (musicFileAddress != null)
            {
                FileInfo fileInfo = new FileInfo(musicFileAddress);
                try
                {

                    File.Copy(musicFileAddress, folderAddress + @"\" + fileInfo.Name);
                }
                catch (Exception exception)
                {
                }
                musicFileAddress = m3uFile.GetNextFilePath();
            }
        }
    }
}
