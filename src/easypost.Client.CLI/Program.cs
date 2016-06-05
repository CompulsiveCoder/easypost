using System;

namespace easypost.CLI
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            var arguments = new Arguments (args);

            if (arguments.KeylessArguments.Length == 0)
                Help ();

            var cmd = arguments.KeylessArguments[0];

            Execute (cmd, arguments);
        }

        public static void Execute(string cmd, Arguments arguments)
        {
            switch(cmd)
            {
            case "Create":
                Create();
                break;
            case "post":
                Post();
                break;
            case "append":
                Append();
                break;
            case "delete":
                Delete();
                break;
            }               
        }

        public static void Create()
        {

            throw new NotImplementedException ();
            //var manager = new PostManager ();
        }

        public static void Post()
        {

            throw new NotImplementedException ();
            //var manager = new PostManager ();
        }

        public static void Append()
        {
            throw new NotImplementedException ();
        }

        public static void Delete()
        {
            throw new NotImplementedException ();
        }
            
        public static void Help()
        {
            throw new NotImplementedException();
        }
    }
}
