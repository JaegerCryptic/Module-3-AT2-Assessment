using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRobot
{
    class RandomAccess
    {
        public static int Column { get; set; }
        public static int Row { get; set; }
        public static string Name { get; set; }
        public static int pos = 0;

       public static void MainMethod(string StudentName, int StudentRow, int StudentColumn)
        {
            Name = StudentName;
            Row = StudentRow;
            Column = StudentColumn;

            ReadFromFile("Student.txt");
            AddRecord();
        }

        static void AddRecord()
        {
            Students stu = new Students(Name, Row, Column);
            DialogResult dialogResult = MessageBox.Show("Do you want to add a new student?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pos += 1;
                WriteToFile("Student.txt", stu, pos, stu.RecSize);
                MessageBox.Show(" " + Name +" Has been saved.");
            }
            else if (dialogResult == DialogResult.No)
            {
                // do nothing
            }
        }

        static void WriteToFile(string fileName, Students obj, int pos, int size)
        {
            FileStream fout;

            BinaryWriter bw;

            fout = new FileStream(fileName, FileMode.Append, FileAccess.Write);

            bw = new BinaryWriter(fout);

            fout.Position = pos * size;

            bw.Write(obj.Names);
            bw.Write(obj.Row.ToString());
            bw.Write(obj.Column.ToString());

            bw.Close();
            fout.Close();
        }

        static void ReadFromFile(string fileName)
        {
            FileStream fn;
            BinaryReader br;

            Students stu = new Students(Name, Row, Column);

            int currentRecord = 0;

            //try to open file

            try
            {
                fn = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                br = new BinaryReader(fn);

                int i;
                for(i = 1; i <= (int)(fn.Length) / stu.RecSize; i++)
                {
                    currentRecord += 1;

                    fn.Seek(currentRecord * stu.RecSize, 0);

                    stu.Names = br.ReadString().ToString();
                    stu.Row = br.ReadInt32();
                    stu.Column = br.ReadInt32();
                }

                pos = currentRecord;

                br.Close();
                fn.Close();
            }
            catch (Exception e)
            {

            }
        }
        static void FindFromFile(string fileName, int index)
        {
            FileStream fn;
            BinaryReader br;

            Students stu = new Students(Name, Row, Column);

            int currentRecord = index;

            try
            {
                fn = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                br = new BinaryReader(fn);

                currentRecord = index;

                fn.Seek(currentRecord * stu.RecSize, 0);

                stu.Names = br.ReadString().ToString();
                stu.Row = br.ReadInt32();
                stu.Column = br.ReadInt32();

                pos = currentRecord;

                br.Close();
                fn.Close();


            }
            catch(Exception e)
            {

            }
        }
    }
}
