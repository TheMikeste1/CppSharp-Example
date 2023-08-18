# How to build and run with CppSharp

1. Compile cpp:
   1. `g++ -c  Foo.cpp  -shared -fPIC`
   2. `gcc -shared -o libFoo.so ./Foo.o ./Foo.hpp`
2. Run bindings_gen
   - From `test` (parent folder), run `dotnet run --project bindings_gen/bindings_gen.csproj`
3. Build exe
4. Copy `libFoo.so` to `bin/Debug/net7.0`
5. Run exe
