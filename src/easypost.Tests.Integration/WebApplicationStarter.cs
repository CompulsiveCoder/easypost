using System;
using System.IO;
using easypost.Processes;
using System.Collections;
using System.Threading;

namespace easypost.Tests.Integration
{
    // TODO: Should this component be moved to a dedicated library?
    public class WebApplicationStarter
    {
        public ProcessStarter ProcessStarter = new ProcessStarter();

        public int Port = 0;

        public string DockerContainerId;

        public WebApplicationStarter ()
        {
        }

        public void Start(string rootDirectory)
        {
            Console.WriteLine ("Starting web application");

            LaunchProcess (rootDirectory);

        }

        public void LaunchProcess(string rootDirectory)
        {
            if (Port == 0)
                Port = PortFinder.GetFreeTcpPort ();
            
            var rootDirectoryPath = Path.GetFullPath (rootDirectory);

            Console.WriteLine ("Starting web application:");
            Console.WriteLine ("  " + rootDirectoryPath);

            var dockerRunCommand = String.Format (
                "docker run -d -t -p {0}:{0} -v {1}:/var/www compulsivecoder/ubuntu-mono /bin/bash -c 'cd /var/www && xsp4 --port {0}'",
                Port,
                rootDirectoryPath);

            Console.WriteLine ("Docker run command:");
            Console.WriteLine("  " + dockerRunCommand);

            ProcessStarter.Start (dockerRunCommand);

            Console.WriteLine (ProcessStarter.Output);

            if (!ProcessStarter.IsError) {
                var lines = ProcessStarter.Output.Trim ().Split ('\n');

                DockerContainerId = lines [lines.Length - 1];
            }

            ProcessStarter.OutputBuilder.Clear ();

            WaitToLoad ();
        }

        public void Stop()
        {
            ProcessStarter.Start ("bash",
                String.Format ("-c 'cd www && docker stop {0} && docker rm {0}'", DockerContainerId)
            );

            Console.WriteLine (ProcessStarter.Output);

            ProcessStarter.OutputBuilder.Clear ();
        }

        protected void WaitToLoad()
        {
            Thread.Sleep (2000); // TODO: Check if this delay can be reduced
        }

    }
}

