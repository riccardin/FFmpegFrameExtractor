using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: Program <input_video_file> <output_directory>");
            return;
        }

        string inputVideoFile = args[0];
        string outputDirectory = args[1];

        ExtractFrames(inputVideoFile, outputDirectory);
    }

    static void ExtractFrames(string inputVideoFile, string outputDirectory)
    {
        string ffmpegPath = "ffmpeg"; // Assumes ffmpeg is in the system PATH
        string arguments = $"-i {inputVideoFile} -vf \"select='gt(scene,0.3)',showinfo\" -vsync vfr {outputDirectory}/frame_%04d.png";

        ProcessStartInfo processStartInfo = new ProcessStartInfo(ffmpegPath, arguments)
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (Process process = new Process())
        {
            process.StartInfo = processStartInfo;
            process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
            process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data);

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
        }
    }
}
