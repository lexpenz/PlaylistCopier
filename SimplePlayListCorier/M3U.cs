using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CopyShortListOfFiles
{
    class M3U: IDisposable
    {
        public M3U()
        {
            
        }
        public M3U(String pathToFile)
        {
            _pathToFile = pathToFile;
            _streamReader = new StreamReader(pathToFile);
        }

        public String GetNextFilePath()
        {
            if (!_streamReader.EndOfStream)
            {
                String newLine = _streamReader.ReadLine();
                if (newLine[0]!='#')
                {
                    return newLine;
                }
                else
                {
                    return GetNextFilePath();
                }
            }
            else
                return null;
        }

        private String _pathToFile { get; set; }
        private StreamReader _streamReader;

        public void Dispose()
        {
            _streamReader.Close();
        }
    }
}
