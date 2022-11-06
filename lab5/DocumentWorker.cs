using System;
using System.IO;
using System.Text;
namespace lab5
{
    class Program
    {
        private const string PRO_LICENSE = "111";
        private const string EXP_LICENSE = "222";

        static void Main(string[] args)
        {
            //ask license
            Console.WriteLine("Enter license key:");
            var license = Console.ReadLine();

            //create document worker
            DocumentWorker worker;
            switch (license)
            {
                case PRO_LICENSE: worker = new ProDocumentWorker(); break;
                case EXP_LICENSE: worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }

            //ask commands
            while (true)
            {
                Console.WriteLine("Введiть команду (o/e/s/q): ");
                switch (Console.ReadLine())
                {
                    case "o": worker.OpenDocument(); break;
                    case "e": worker.EditDocument(); break;
                    case "s": worker.SaveDocument(); break;
                    case "q": return;
                }
            }
        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            StreamReader streamReader = new StreamReader("file.txt");
            Console.WriteLine($"Документ вiдкритий\nВмiст файлу:\n{streamReader.ReadToEnd()}");
            streamReader.Close();
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Правка документа доступна в версiї Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне в версiї Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            string s;
            Console.Write("Введiть стрiчку яку бажаєте додати в файл: ");
            s = Console.ReadLine();
            File.AppendAllText("file.txt", $"{s}\n");
            Console.WriteLine("Документ вiдредагований");

        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений в старому форматi, збереження в iнших форматах доступне в версiї Експерт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            StreamReader streamReader = new StreamReader("file.txt");
            StreamWriter streamWriter = new StreamWriter("file1.doc");
            streamWriter.WriteLine(streamReader.ReadToEnd());
            Console.WriteLine("Документ збережений в новому форматi");
            streamReader.Close();
            streamWriter.Close();
        }
    }
}