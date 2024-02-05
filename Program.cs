using System;
using System.IO;
using System.IO.Compression;

namespace comLoader
{
    class Program
    {
        static Char[] facilityId_001_04 = new Char[04];
        static Char[] type_005_04 = new Char[04];
        static Char[] navaid_12_04 = new Char[04];
        static Char[] radioCall_215_26 = new Char[26];
        static Char[] fssIdent_389_30 = new Char[30];
        static Char[] freq01_241_09 = new Char[09];
        static Char[] freq02_250_09 = new Char[09];
        static Char[] freq03_259_09 = new Char[09];
        static Char[] freq04_268_09 = new Char[09];
        static Char[] freq05_277_09 = new Char[09];
        static Char[] freq06_286_09 = new Char[09];
        static Char[] freq07_295_09 = new Char[09];
        static Char[] freq08_304_09 = new Char[09];
        static Char[] freq09_313_09 = new Char[09];
        static Char[] freq10_322_09 = new Char[09];
        static Char[] freq11_331_09 = new Char[09];
        static Char[] freq12_340_09 = new Char[09];
        static Char[] freq13_349_09 = new Char[09];
        static Char[] freq14_358_09 = new Char[09];
        static Char[] freq15_367_09 = new Char[09];
        static Char[] freq16_376_09 = new Char[09];

        static StreamWriter ofile = new StreamWriter("comStation.txt");

        static void Main(String[] args)
        {
            String userprofileFolder = Environment.GetEnvironmentVariable("USERPROFILE");
            String[] fileEntries = Directory.GetFiles(userprofileFolder + "\\Downloads\\", "28DaySubscription*.zip");

            ZipArchive archive = ZipFile.OpenRead(fileEntries[0]);
            ZipArchiveEntry entry = archive.GetEntry("COM.txt");
            entry.ExtractToFile("COM.txt", true);

            StreamReader file = new StreamReader("COM.txt");

            String rec = file.ReadLine();

            while (!file.EndOfStream)
            {
                ProcessRecord(rec);
                rec = file.ReadLine();
            }

            ProcessRecord(rec);

            file.Close();
            ofile.Close();

        }

        static void ProcessRecord(String record)
        {
            facilityId_001_04 = record.ToCharArray(0, 4);
            type_005_04 = record.ToCharArray(4, 4);
            navaid_12_04 = record.ToCharArray(11, 4);
            radioCall_215_26 = record.ToCharArray(214, 26);
            fssIdent_389_30 = record.ToCharArray(388, 30);
            freq01_241_09 = record.ToCharArray(240, 9);

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(240, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(249, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(258, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(267, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(276, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(285, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(294, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(303, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(312, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(321, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(330, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(339, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(348, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(357, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(366, 9)).Trim());

            FormatWriteFrequency(new String(facilityId_001_04).Trim(), new String(type_005_04).Trim(), new String(navaid_12_04).Trim(), new String(radioCall_215_26).Trim(), new String(fssIdent_389_30).Trim(), new String(record.ToCharArray(375, 9)).Trim());

        }

        static void FormatWriteFrequency(String facilityId, String type, String navaid, String radioCall, String fssIdent, String freq)
        {
            if (freq != "")
            {
                ofile.Write(facilityId);
                ofile.Write('~');

                ofile.Write(type);
                ofile.Write('~');

                ofile.Write(navaid);
                ofile.Write('~');

                ofile.Write(radioCall);
                ofile.Write('~');

                ofile.Write(fssIdent);
                ofile.Write('~');

                String[] s = freq.Split('R');
                ofile.Write(s[0].PadRight(7, '0'));
                if(s.Length > 1)
                {
                    ofile.Write("R");
                }
                ofile.Write(ofile.NewLine);
            }

        }

    }
}
