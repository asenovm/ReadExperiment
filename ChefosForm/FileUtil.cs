using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Read
{
    public class FileUtil
    {

        private FileUtil() { 
            //blank
        }

        public static void WriteToFile(string value, string outputFile) {
            StreamWriter SW = File.AppendText(outputFile);
            SW.Write(value);
            SW.Close();
        }

        public static void WriteToFile(double time, string outputFile) {
            StreamWriter SW = File.AppendText(outputFile);

            StringBuilder builder = new StringBuilder();
            builder.Append(time);
            builder.Append(" ");

            SW.Write(builder.ToString());
            SW.Close();
        }

        public static void WriteToFile(Notification notification, long time, string outputFile) {
            StreamWriter SW= File.AppendText(outputFile);
            StringBuilder builder = new StringBuilder();
            builder.Append(notification.GetSenderId());
            builder.Append(" ");
            builder.Append(notification.GetSenderServerId());
            builder.Append(" ");
            builder.Append(notification.GetSupplier());
            builder.Append(" ");
            builder.Append(notification.Satisfaction.ToString());
            builder.Append(" ");
            builder.Append(time.ToString());
            builder.Append(" ");
            SW.WriteLine(builder.ToString());
            SW.Close();
        }

        public static void WriteToFile(string supplier, string choiceTime, string nextTime, string dsChoiceTime, string dsChoice, string nextWatch, string outputFile) {
            StreamWriter SW = File.AppendText(outputFile);
            StringBuilder builder = new StringBuilder();
            builder.Append(supplier);
            builder.Append(" ");
            builder.Append(choiceTime);
            builder.Append(" ");
            builder.Append(nextTime);
            builder.Append(" ");
            builder.Append(dsChoiceTime);
            builder.Append(" ");
            builder.Append(dsChoice);
            builder.Append(" ");
            builder.Append(nextWatch);
            builder.Append(" ");
            SW.WriteLine(builder.ToString());
            SW.Close();
        }

        public static void WriteToFile(string age, string gender, string major, string outputFileName) {
            StreamWriter writer = File.AppendText(outputFileName);
            StringBuilder builder = new StringBuilder();
            builder.Append(age);
            builder.Append(" ");
            builder.Append(gender);
            builder.Append(" ");
            builder.Append(major);
            writer.WriteLine(builder.ToString());
            writer.Close();
        }
    }
}
