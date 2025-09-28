using ProgramChooser;
using System.Reflection;

var chooser = new MainProgram(Assembly.GetExecutingAssembly());
chooser.ChooseAndRun();
