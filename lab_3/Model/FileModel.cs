using System;
using System.Collections.Generic;
using System.IO;

namespace lab_3.Model
{
    public static class FileModel
    {
        public static void WriteFile(List<Student> students, List<Grades> grades, string file_path)
        {
            string file = "Студенты:";
            foreach (var el in students) 
                file += $"{Environment.NewLine}{el}";

            file += $"{Environment.NewLine}{Environment.NewLine}";

            file += "Оценки:";
            foreach (var el in grades) 
                file += $"{Environment.NewLine}{el}";

            using (var writer = new StreamWriter(file_path))
                writer.Write(file);
        }
    }
}
