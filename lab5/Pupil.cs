using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Pupil
    {
        public virtual void Study()
        { }

        public virtual void Read()
        { }

        public virtual void Write()
        { }

        public virtual void Relax()
        { }
    }
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Чудовий учень: вчиться чудово");
        }
        public override void Read()
        {
            Console.WriteLine("Чудовий учень: читає чудово");
        }
        public override void Write()
        {
            Console.WriteLine("Чудовий учень: пише чудово");
        }
        public override void Relax()
        {
            Console.WriteLine("Чудовий учень: вiдпочиває чудово");
        }

    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Хороший учень: вчиться добре");
        }
        public override void Read()
        {
            Console.WriteLine("Хороший учень: читає добре");
        }
        public override void Write()
        {
            Console.WriteLine("Хороший учень: пише добре");
        }
        public override void Relax()
        {
            Console.WriteLine("Хороший учень: вiдпочиває добре");
        }

    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Поганий учень: вчиться погано");
        }
        public override void Read()
        {
            Console.WriteLine("Поганий учень: читає погано");
        }
        public override void Write()
        {
            Console.WriteLine("Поганий учень: пише погано");
        }
        public override void Relax()
        {
            Console.WriteLine("Поганий учень: вiдпочиває погано");
        }

    }
    class ClassRoom
    {
        Pupil[] arrPupil;

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            arrPupil = new Pupil[] { p1, p2, p3, p4 };
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            arrPupil = new Pupil[] { p1, p2, p3 };
        }
        public ClassRoom(Pupil p1, Pupil p2)
        {
            arrPupil = new Pupil[] { p1, p2 };
        }

        public void PrintInfoStudy()
        {
            Console.WriteLine("Вчиться: ");
            foreach (Pupil item in arrPupil)
                item.Study();
        }
        public void PrintInfoRead()
        {
            Console.WriteLine("Читає: ");
            foreach (Pupil item in arrPupil)
                item.Read();
        }
        public void PrintInfoWrite()
        {
            Console.WriteLine("Пише: ");
            foreach (Pupil item in arrPupil)
                item.Write();
        }
        public void PrintInfoRelax()
        {
            Console.WriteLine("Вiдпочиває: ");
            foreach (Pupil item in arrPupil)
                item.Relax();
        }
    }

    class Program
    {
        static void Main()
        {
            ClassRoom cRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new ExcelentPupil());

            cRoom.PrintInfoRead();
            cRoom.PrintInfoRelax();
            cRoom.PrintInfoStudy();
            cRoom.PrintInfoWrite();

            Console.ReadKey();
        }
    }
}
