using System;
using System.IO;
using libWiiSharp;


namespace WadMiiIsh
{

    static class Start
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Program p = new Program();
                p.WadMain(args);
            }   
            else
                Environment.Exit(0);
        }
    }

    class Program
    {

        public void WadMain(string[] args)
        {
            bool trucha = false;
            string id = "";
            string input = "";
            string output = "";

            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    switch (args[i])
                    {
                        case "-input":
                            input = args[i + 1];
                            break;
                        case "-output":
                            output = args[i + 1];
                            break;
                        case "-in":
                            input = args[i + 1];
                            break;
                        case "-out":
                            output = args[i + 1];
                            break;
                        case "-id":
                            id = args[i + 1].ToUpper();
                            break;
                        case "-trucha":
                            trucha = true;
                            break;
                        case "-sign":
                            trucha = true;
                            break;
                        default:
                            break;
                    }
                }
            }

            catch (Exception ex)
            {
                Environment.Exit(0);
            }

            if (Directory.Exists(input))
                this.doPack(new string[] { input, output }, true);
            else
                this.doUnpack(new string[] { input, output });
        }

        private void doUnpack(object files)
        {
            string input = ((string[])files)[0];
            string output = ((string[])files)[1];

            try
            {
                WAD w = new WAD();

                w.LoadFile(input);

                w.Unpack(output, false);

            }
            catch (Exception ex) { Environment.Exit(0); }
      
        }

        private void doPack(object files, bool trucha)
        {
            string input = ((string[])files)[0];
            string output = ((string[])files)[1];

            try
            {
                WAD w = new WAD();

                w.CreateNew(input);
                w.KeepOriginalFooter = true;

                w.FakeSign = trucha;
                w.Save(output);

            }
            catch (Exception ex) { return; }
        }
    }
}