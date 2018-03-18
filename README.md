# Introduction 
fame is a project to help read and write AIFMD XML reports 
plus any tests and tools around that.

## Specifications
All specifications should be found on the website of the supervising or regulating organisation.

eg.
[ESMA Library 2013/1358](https://www.esma.europa.eu/databases-library/esma-library/2013%252F1358)
(http://www.finanssivalvonta.fi/en/Regulation/International_Projects/AIFMD/reporting/Pages/Default.aspx)

# Environment
I use [Visual Studio Code](https://code.visualstudio.com/) 
on [Arch Linux](https://www.archlinux.org/)

Code is written in [C#](https://docs.microsoft.com/en-us/dotnet/csharp/index) 7.0, targeting 
[.NET Standard 2.0](https://github.com/dotnet/standard/blob/master/docs/versions/netstandard2.0.md) / 
[.NET Core 2.0](https://docs.microsoft.com/en-us/dotnet/core/)

Test framework is [xUnit.net](https://xunit.github.io/)

## Diwen.Aifmd
.NET Standard 1.3 library

### License:
GNU Lesser General Public License v3.0

[http://www.gnu.org/licenses/gpl.txt](http://www.gnu.org/licenses/gpl.txt)

[http://www.gnu.org/licenses/lgpl.txt](http://www.gnu.org/licenses/lgpl.txt)


## Diwen.Aifmd.Test
.NET Core 2.0 test project with code and data for testing the library, also serving as documentation

### License
[Free Public License 1.0.0](https://opensource.org/licenses/FPL-1.0.0)