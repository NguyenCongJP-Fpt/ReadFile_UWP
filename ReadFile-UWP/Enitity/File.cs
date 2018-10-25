using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile_UWP
{
    class File
    {
        private string _fileName;
        private string _content;

        public string FileName { get => _fileName; set => _fileName = value; }
        public string Content { get => _content; set => _content = value; }
    }
}
