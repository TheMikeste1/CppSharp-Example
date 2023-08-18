
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace bindings;

public class Lib : ILibrary
{
  void ILibrary.Postprocess(Driver driver, ASTContext ctx)
  {
  }

  void ILibrary.Preprocess(Driver driver, ASTContext ctx)
  {
  }

  void ILibrary.Setup(Driver driver)
  {
    var options = driver.Options;
    options.GeneratorKind = GeneratorKind.CSharp;
    options.OutputDir = "/home/michael/projects/test/bindings";

    var module = options.AddModule("Foo");
    module.IncludeDirs.Add("/home/michael/projects/test/cpp");
    module.Headers.Add("Foo.cpp");
    module.LibraryDirs.Add("/home/michael/projects/test/cpp");
    module.Libraries.Add("libFoo.so");
  }

  void ILibrary.SetupPasses(Driver driver)
  {
  }
}