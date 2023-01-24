using System;
using System.Diagnostics;

Main();

     void Main()
      {
        
        
       System.Console.WriteLine("Type h to example");


        try
         {
            System.Console.WriteLine("Type the name of the process or service to be closed");
            string processName = Console.ReadLine();
              
               if(processName.ToLower() == "h")
                {
                    Help();
                   
                }

             
            var processes = Process.GetProcessesByName(processName);

            if(processes.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Process not found.");
                Console.ResetColor();
                Main();
            }
         
            if (processes.Length > 0) 
            {
                foreach (var process in processes)
                 {
                    process.Kill();
                 }
                  Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The process {processName} have been successfully killed.");
                 Console.ResetColor();
            } 

            
            else 
            {
                Process.Start("taskkill", "/F /IM " + processName);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The process {processName} have been successfully killed.");
                Console.ResetColor();
            }

        
        } catch (Exception e)
         {
             Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro: " + e.Message);
              Console.ResetColor();
        }
    }


    void Help()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        System.Console.WriteLine("Note: In some process you may need to add '.exe'. This is a example list os process that you can kill:");
        System.Console.WriteLine("To know the name of the process, open the Task Menager and search for the 'process name', or search it online.");
        System.Console.WriteLine();
        string[] list = 
        {
            "csrss",
            "wininit",
            "winlogon",
            "services",
            "lsass",
            "svchost",
            "smss",
            "explorer",
            "taskmgr",
            "spoolsv",
            "spotify",
            "mspaint",
            "calc",
            "notepad",
            "steam",
            "powershell"
            
        };


        foreach(var lista in list)
        { 
            System.Console.WriteLine(lista);
        }
          System.Console.WriteLine();

        Console.ResetColor();

      



    }





