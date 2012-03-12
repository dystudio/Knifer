﻿using Gimela.Toolkit.CommandLines.Foundation;

namespace Gimela.Toolkit.CommandLines.Checksum
{
  class Program
  {
    static void Main(string[] args)
    {
      using (CommandLine command = new ChecksumCommandLine(args))
      {
        CommandLineBootstrap.Start(command);
      }
    }
  }
}
