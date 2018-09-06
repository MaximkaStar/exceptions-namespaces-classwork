using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Models;
using static System.Console;

namespace exeptions_namespaces_classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            checked
            { }
            unchecked
            { }

            ReadLine();

            try
            {
                user.CreateData();
            }
            catch (WebException networkException)
            {
                WriteLine(networkException.Message);
            }
            catch (IOException exception)
            {
                WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                WriteLine(exception.Message);
            }
            finally { }

            ReadLine();
        }
    }
}
