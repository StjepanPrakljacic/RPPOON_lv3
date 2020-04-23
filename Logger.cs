using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_lv3
{
    class Logger
    {
        private string filename = "Default.txt";
        private Logger instance;

        public Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void SetFileName(string name)
        {
            this.filename = name;
        }

        public void LogToFile(string dataToWrite)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename))
            {
                writer.WriteLine(dataToWrite);
            }
        }
    }
}
// ako nije promjenjen path upisivati će na isto mjesto

